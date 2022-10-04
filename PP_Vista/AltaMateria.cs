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
    public partial class AltaMateria : Form
    {
        List<Profesor> _profes = new List<Profesor>();
        List<Materia> _materias = new List<Materia>();
        string _nombre;
        int cuatri;
        int idProfe;
        int idCorrelat;
        Materia nuevaMateria;

        public AltaMateria()
        {
            InitializeComponent();
        }
        public AltaMateria(List<Profesor> profes, List<Materia> maters) :this()
        {
            _profes = profes;
            _materias = maters;
        }

        private void AltaMateria_Load(object sender, EventArgs e)
        {
            foreach (Profesor prof in _profes)
            {
                int i = dtg_profes.Rows.Add();
                dtg_profes.Rows[i].Cells[0].Value = prof.MostrarId();
                dtg_profes.Rows[i].Cells[1].Value = prof.MostrarNombreCompleto();
            }
            foreach(Materia mat in _materias)
            {
                int j = dtg_materias.Rows.Add();
                dtg_materias.Rows[j].Cells[0].Value = mat.MostrarId();
                dtg_materias.Rows[j].Cells[1].Value = mat.Nombre;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns> la materia creada
        public Materia GetMateria()
        {
            return nuevaMateria;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dtg_profes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                string value = (string)dtg_profes.Rows[n].Cells[0].Value;
                int.TryParse(value, out idProfe);
            }
        }

        private void dtg_materias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                string value = (string)dtg_materias.Rows[n].Cells[0].Value;
                int.TryParse(value, out idCorrelat);
            }
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            _nombre = txb_nombre.Text;
            cuatri = (int)nUd_cuatri.Value;
            if(!(string.IsNullOrWhiteSpace(_nombre)))
            {
                nuevaMateria = new Materia(_nombre, cuatri, idProfe, idCorrelat);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
