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
    public partial class NuevoExamen : Form
    {
        E_instanciasExamen instanciaSeleccionada;
        DateTime fechaSeleccionada;
        Examen nuevoExamen;

        public NuevoExamen()
        {
            InitializeComponent();
            lstb_instanciasExamen.Items.AddRange(typeof(E_instanciasExamen).GetEnumNames());          
        }
        /// <summary>
        /// permite retornar el examen creado
        /// </summary>
        /// <returns></returns>
        public Examen GetExamen()
        {
            return nuevoExamen;
        }

        private void lstb_instanciasExamen_SelectedIndexChanged(object sender, EventArgs e)
        {
           instanciaSeleccionada = (E_instanciasExamen)lstb_instanciasExamen.SelectedIndex;
            
        }

        private void dTp_fecha_ValueChanged(object sender, EventArgs e)
        {
            fechaSeleccionada = dTp_fecha.Value;
            lbl_InfoCreada.Text = "Nuevo examen: " + instanciaSeleccionada + "\nFecha: " + fechaSeleccionada.ToLongDateString();

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            nuevoExamen = new Examen(instanciaSeleccionada, fechaSeleccionada);
            this.DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
