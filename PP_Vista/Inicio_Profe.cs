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
    public partial class frm_Inicio_Profe : Form
    {
        Profesor usuario;

        List<Materia> materias = new List<Materia>();
        List<Alumno> alumnos = new List<Alumno>();
        List<Examen> examenes = new List<Examen>();

        Materia materiaSeleccionada;
        E_instanciasExamen examenSeleccionado = (E_instanciasExamen)(-1);
        Alumno alumnoSeleccionado;

        public frm_Inicio_Profe()
        {
            InitializeComponent();
        }
        public frm_Inicio_Profe(Profesor profe) :this()
        {
            usuario = profe;
            materias = usuario.Materias;

        }

        private void frm_Inicio_Profe_Load(object sender, EventArgs e)
        {
            this.lbl_bienvenida.Text = usuario.Saludar();
            RecargarListaMaterias();
        }

        private void frm_Inicio_Profe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_nuevoExamen_Click(object sender, EventArgs e)
        {
            if(materiaSeleccionada != null)
            {
                NuevoExamen frm_nuevoExamen = new NuevoExamen();
                DialogResult resultado = frm_nuevoExamen.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    materiaSeleccionada.AgregarExamen(frm_nuevoExamen.GetExamen());
                    lbl_cargaExamen.Text = "Carga de nuevo examen\nExitosa";
                    dtg_examenes.Rows.Clear();
                    RecargarListaExamenes();
                }
                else
                {
                    lbl_cargaExamen.Text = "Carga de nuevo examen\nCancelada";
                }
            }
            else
            {
                lbl_cargaExamen.Text = "Debe seleccionar una materia";
            }
            
        }

        private void dtg_materias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                string value = (string)dtg_materias.Rows[n].Cells[0].Value;

                int idSeleccion;
                int.TryParse(value, out idSeleccion);
                materiaSeleccionada = usuario.GetMateria(idSeleccion);
                alumnos.Clear();
                dtg_alumnos.Rows.Clear();
                ExtraerAlumnosDeMaterias();
                RecargarListaAlumnos();
                RecargarListaExamenes();
            }
        }

        private void btn_guardarNotas_Click(object sender, EventArgs e)
        {
            if (materiaSeleccionada != null)
            {
                if(examenSeleccionado >= 0)
                {
                    if (alumnoSeleccionado == null)
                    {
                        lbl_cargaExamen.Text = "Seleccione Alumno";
                    }
                    else
                    {
                        int nota = (int)nUd_notaNueva.Value;
                        alumnoSeleccionado.EncontrarCursada(materiaSeleccionada.Nombre).ModificarNotaExamen(examenSeleccionado, nota);
                        lbl_cargaExamen.Text = "Notas guardadas con Exito!";
                        dtg_alumnos.Rows.Clear();
                        ActualizarListaAlumnos();
                        RecargarListaAlumnos();
                    }
                }
                else
                {
                    lbl_cargaExamen.Text = "ERROR debe seleccionar examen";
                }
            }
            else
            {
                lbl_cargaExamen.Text = "ERROR debe seleccionar materia";
            }
            
           
        }

        private void dtg_examenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(examenes.Count > 0)
            {
                int n = e.RowIndex;
                if (n != -1)
                {
                    string value = (string)dtg_examenes.Rows[n].Cells[0].Value;
                    examenSeleccionado = Enum.Parse<E_instanciasExamen>(value);
                    dtg_alumnos.Rows.Clear();
                    RecargarListaAlumnos();
                }
            }
            else
            {
                lbl_cargaExamen.Text = "No hay examenes creados en esta materia";
            }
            
        }

        private void dtg_alumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(examenSeleccionado >= 0)
            {
                int n = e.RowIndex;
                if (n != -1)
                {
                    string value = (string)dtg_alumnos.Rows[n].Cells[0].Value;

                    int idSeleccion;
                    int.TryParse(value, out idSeleccion);
                    alumnoSeleccionado = materiaSeleccionada.BuscarAlumno(idSeleccion);
                }
            }
            else
            {
                lbl_cargaExamen.Text = "Debe seleccionar Examen";
            }
            

        }
        /// <summary>
        /// actualiza la informacion de las listas de alumnos
        /// </summary>
        private void ActualizarListaAlumnos()
        {
            foreach (Alumno al in alumnos)
            {
                if(al.Id == alumnoSeleccionado.Id)
                {
                    alumnos.Remove(al);
                    alumnos.Add(alumnoSeleccionado);
                    break;
                }
            }
        }
        /// <summary>
        /// Rellena la informacion de los data grid view con las listas de alumnos
        /// </summary>
        private void RecargarListaAlumnos()
        {
            foreach (Alumno al in alumnos)
            {
                int j = dtg_alumnos.Rows.Add();
                dtg_alumnos.Rows[j].Cells[0].Value = al.MostrarId();
                dtg_alumnos.Rows[j].Cells[1].Value = al.MostrarNombreCompleto();
                dtg_alumnos.Rows[j].Cells[2].Value = al.EncontrarCursada(materiaSeleccionada.Nombre).EncontrarNotaExamen(examenSeleccionado);
               
            }
        }
        /// <summary>
        /// Rellena la informacion de los data grid view con las listas de materias
        /// </summary>
        private void RecargarListaMaterias()
        {
            foreach (Materia mater in materias)
            {
                int j = dtg_materias.Rows.Add();
                dtg_materias.Rows[j].Cells[0].Value = mater.MostrarId();
                dtg_materias.Rows[j].Cells[1].Value = mater.MostrarNombre();
                dtg_materias.Rows[j].Cells[2].Value = mater.MostrarCuatri();
            }
        }
        /// <summary>
        /// desempaqueta las listas de alumnos que estan inscriptos en una materia seleccionada
        /// </summary>
        private void ExtraerAlumnosDeMaterias()
        {
            alumnos = materiaSeleccionada.Alumnos;
        }
        /// <summary>
        /// Rellena la informacion de los data grid view con las listas de examenes
        /// </summary>
        private void RecargarListaExamenes()
        {
            
            examenes = materiaSeleccionada.Examenes;
            foreach(Examen ex in examenes)
            {
                int j = dtg_examenes.Rows.Add();
                dtg_examenes.Rows[j].Cells[0].Value = ex.MostrarExamenNombre();
                dtg_examenes.Rows[j].Cells[1].Value = ex.MostrarExamenFecha();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
