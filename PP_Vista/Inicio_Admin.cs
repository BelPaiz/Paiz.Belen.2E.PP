using PP_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Vista
{
    public partial class frm_inicioAdmin : Form
    {
        private Admin _usuario;
        private List<Alumno> _alumnos = new List<Alumno>();
        private List<Profesor> _profes = new List<Profesor>();
        private List<Admin> _administ = new List<Admin>();
        public List<Materia> _materias = new List<Materia>();
        int idSeleccionadoAlumno;
        private Alumno alumnoSeleccionado;
        int idProfeSeleccion = 0;
        int idMateriaSeleccion = 0;
        private Usuario nuevoUsuario;
        private Materia materiaInscripcion;

        private frm_inicioAdmin()
        {
            InitializeComponent();
        }
        public frm_inicioAdmin(Admin user, List<Alumno> alumns, List<Profesor> prof, List<Admin>adminds, List<Materia> materias) : this()
        {
            _usuario = user;
            _alumnos = alumns;
            _profes = prof;
            _administ = adminds;
            _materias = materias;
        }

        private void frm_inicioAdmin_Load(object sender, EventArgs e)
        {
            this.lbl_bienvenida.Text = _usuario.Saludar();

            RecargarListaAlumnos();
            RecargarListaProfesores();
            RecargarListaMaterias();
        }

        private void frm_inicioAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dtg_listaAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if(n != -1)
            {
                string value = (string)dtg_listaAlumnos.Rows[n].Cells[0].Value;

                int idSeleccion;
                int.TryParse(value, out idSeleccion);
                idSeleccionadoAlumno = idSeleccion;
                foreach (Alumno alumno in _alumnos)
                {
                    if (idSeleccion == alumno.Id)
                    {
                        alumnoSeleccionado = alumno;
                        foreach(Cursada c in alumno.Cursada)
                        {
                            rtb_alumnos.Text = c.MostrarMateriaEnCurso();
                        }                        
                        break;
                    }
                }
            }
        }

        private void btn_cambiarEstado_Click(object sender, EventArgs e)
        {
            int estado =(int) nUd_estado.Value;
            foreach (Alumno alumno in _alumnos)
            {
                if (idSeleccionadoAlumno == alumno.Id)
                {
                    foreach (Cursada c in alumno.Cursada)
                    {
                        c.Estado = estado;
                        rtb_alumnos.Text = c.MostrarMateriaEnCurso();
                    }
                    break;
                }
            }
        }

        private void dtg_listaProfes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                string value = (string)dtg_listaProfes.Rows[n].Cells[0].Value;

                int idSeleccion;
                int.TryParse(value, out idSeleccion);
                idProfeSeleccion = idSeleccion;
                foreach(Profesor pro in _profes)
                {
                    if(idSeleccion == pro.Id)
                    {
                        rtb_materiasCargo.Text = pro.MostrarListaMaterias();
                    }
                }
            }
        }

        private void dtg_listaMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                string value = (string)dtg_listaMaterias.Rows[n].Cells[0].Value;
                int idSeleccion;
                int.TryParse(value, out idSeleccion);
                idMateriaSeleccion = idSeleccion; 
            }
        }

        private void btn_agregarMateriaProfe_Click(object sender, EventArgs e)
        {
            if(idProfeSeleccion != 0)
            {
                if(idMateriaSeleccion != 0)
                {
                    foreach (Profesor pro in _profes)
                    {
                        if (idProfeSeleccion == pro.Id)
                        {
                            pro.AnadirMateriaProfe(idMateriaSeleccion, _materias);
                            rtb_materiasCargo.Text = pro.MostrarListaMaterias();
                            lbl_Info.Text = "Materia asignada con exito";
                        }
                    }
                }
                else
                {
                    lbl_Info.Text = "Debe seleccionar una materia";
                }
                
            }
            else
            {
                lbl_Info.Text = "Debe seleccionar un profesor";
            }
            
        }

        private void altaNuevaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMateria frmAltaMateria = new AltaMateria(_profes, _materias);
            DialogResult resultado = frmAltaMateria.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                _materias.Add(frmAltaMateria.GetMateria());
                dtg_listaMaterias.Rows.Clear();
                RecargarListaMaterias();
            }
            else
            {
                MessageBox.Show("Carga Cancelada", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void altaNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuario frm_altaUsuario = new AltaUsuario();
            DialogResult result = frm_altaUsuario.ShowDialog();
            if(result == DialogResult.OK)
            {
                nuevoUsuario = frm_altaUsuario.GetUsuario();
                if (BuscarDni(nuevoUsuario))
                {
                    MessageBox.Show("El usuario que intenta crear ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    switch(nuevoUsuario.Tipo)
                    {
                        case "admin":
                            _administ.Add((Admin)nuevoUsuario);
                            break;
                        case "profe":
                            _profes.Add((Profesor)nuevoUsuario);
                            dtg_listaProfes.Rows.Clear();
                            RecargarListaProfesores();
                            break;
                        case "alumno":
                            _alumnos.Add((Alumno)nuevoUsuario);
                            dtg_listaAlumnos.Rows.Clear();
                            RecargarListaAlumnos();
                            break;
                    }
                }             
            }
        }
        /// <summary>
        /// Rellena la informacion de la lista de materias en los data grid view
        /// </summary>
        private void RecargarListaMaterias()
        {
            foreach (Materia mater in _materias)
            {
                int j = dtg_listaMaterias.Rows.Add();
                dtg_listaMaterias.Rows[j].Cells[0].Value = mater.MostrarId();
                dtg_listaMaterias.Rows[j].Cells[1].Value = mater.Nombre;
                dtg_listaMaterias.Rows[j].Cells[2].Value = mater.Cuatrim;
            }
        }
        /// <summary>
        ///  Rellena la informacion de la lista de profesores en los data grid view
        /// </summary>
        private void RecargarListaProfesores()
        {
            foreach (Profesor prof in _profes)
            {
                int i = dtg_listaProfes.Rows.Add();
                dtg_listaProfes.Rows[i].Cells[0].Value = prof.MostrarId();
                dtg_listaProfes.Rows[i].Cells[1].Value = prof.MostrarNombreCompleto();
            }
        }
        /// <summary>
        ///  Rellena la informacion de la lista de alumnos en los data grid view
        /// </summary>
        private void RecargarListaAlumnos()
        {
            foreach (Alumno alumno in _alumnos)
            {
                int n = dtg_listaAlumnos.Rows.Add();
                dtg_listaAlumnos.Rows[n].Cells[0].Value = alumno.MostrarId();
                dtg_listaAlumnos.Rows[n].Cells[1].Value = alumno.MostrarNombreCompleto();
            }
        }
        /// <summary>
        /// Busca el dni del nuevo usuario en las diferentes listas para comprobar si ya existe
        /// </summary>
        /// <param name="nUsuario"></param>
        /// <returns></returns> false si no existe usuario con ese dni, true caso contrario
        private bool BuscarDni(Usuario nUsuario)
        {
            bool retorno = false;
            foreach(Admin a in _administ)
            {
                if(nUsuario.Dni == a.Dni)
                {
                    retorno = true;
                }
            }
            foreach(Profesor p in _profes)
            {
                if (nUsuario.Dni == p.Dni)
                {
                    retorno = true;
                }
            }
            foreach(Alumno a in _alumnos)
            {
                if (nUsuario.Dni == a.Dni)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inscribirAlumnoAMateriaToolStripMenuItem_Click(object sender, EventArgs e) //PUNTO EXTRA DEL PARCIAL
        {
            InscripcionMaterias frm_inscripcionMaterias = new InscripcionMaterias(_materias, alumnoSeleccionado);
            DialogResult resultado = frm_inscripcionMaterias.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                materiaInscripcion = frm_inscripcionMaterias.GetMateria();
                if (alumnoSeleccionado.Cursada.Count < 2)
                {
                    alumnoSeleccionado.AnadirCursada(materiaInscripcion.Nombre);
                    ActualizarListaAlumnos();
                    dtg_listaAlumnos.Rows.Clear();
                    RecargarListaAlumnos();
                    rtb_alumnos.Text = alumnoSeleccionado.MostrarListaCursada();
                   
                    lbl_infoInscripcion.Text = "Incripcion exitosa!";

                }
                else
                {
                    lbl_infoInscripcion.Text = "Solo puede cursar 2 \nmaterias simultaneamente";
                }

            }
            else
            {
                lbl_infoInscripcion.Text = "Incripcion cancelada por el usuario";
            }
        }
        private void ActualizarListaAlumnos()
        {
            foreach (Alumno al in _alumnos)
            {
                if (al.Id == alumnoSeleccionado.Id)
                {
                    _alumnos.Remove(al);
                    _alumnos.Add(alumnoSeleccionado);
                    break;
                }
            }
        }
    }
}
