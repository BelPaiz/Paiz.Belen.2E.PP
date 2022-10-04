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
    public partial class InscripcionMaterias : Form
    {
        private List<Materia> materias = new List<Materia>();
        private List<Cursada> cursadas = new List<Cursada>();
        private Materia materiaSeleccionada;
        public InscripcionMaterias()
        {
            InitializeComponent();
        }
        public InscripcionMaterias(List<Materia> maters, Alumno user) :this()
        {
            materias = maters;
            cursadas = user.Cursada;
        }
        /// <summary>
        /// Permite retornar la materia seleccionada
        /// </summary>
        /// <returns></returns> materia seleccionada
        public Materia GetMateria()
        {
            return materiaSeleccionada;
        }

        private void InscripcionMaterias_Load(object sender, EventArgs e)
        {
            foreach (Materia m in materias)
            {
                int j = dtg_materias.Rows.Add();
                dtg_materias.Rows[j].Cells[0].Value = m.MostrarId();
                dtg_materias.Rows[j].Cells[1].Value = m.MostrarNombre();
                if (ComprobarCorrelatividad(m.Correlativa))
                {
                    dtg_materias.Rows[j].Cells[2].Value = "puede cursar";
                }
                else
                {
                    dtg_materias.Rows[j].Cells[2].Value = "no puede cursar";
                }
                dtg_materias.Rows[j].Cells[3].Value = m.Cuatrim;

            }
            
        }
        /// <summary>
        /// Comprueba si la correlativa de la materia seleccionada esta aprobada
        /// </summary>
        /// <param name="idCorrelat"></param>
        /// <returns></returns> true si la correlativa esta aprobada  o  si no tiene. o false caso contrario
        private bool ComprobarCorrelatividad(int idCorrelat)
        {
            if (idCorrelat == 0)
            {
                return true;
            }
            else
            {
                foreach(Materia m in materias)
                {
                    if(m.Id == idCorrelat)
                    {
                        foreach(Cursada c in cursadas)
                        {
                            if(m.Nombre == c.Materia)
                            {
                                if(c.Aprobada == 1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
         
 
        private void btn_aceptar_Click(object sender, EventArgs e)
        { 
            if(materiaSeleccionada != null)
            {
                if(ComprobarCorrelatividad(materiaSeleccionada.Correlativa))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    lbl_info.Text = "No aprobo correlativa";
                } 
            }
            else
            {
                lbl_info.Text = "Debe seleccionar una materia";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dtg_materias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                string value = (string)dtg_materias.Rows[n].Cells[0].Value;
                int idSeleccion;
                int.TryParse(value, out idSeleccion);
                foreach(Materia m in materias)
                {
                    if(m.Id == idSeleccion)
                    {
                        materiaSeleccionada = m;
                        lbl_info.Text = " ";
                        break;
                    }
                }
            }
        }

    }
}
