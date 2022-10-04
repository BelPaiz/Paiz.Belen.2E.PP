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
    public partial class AltaUsuario : Form
    {
        Admin nuevoAdmin;
        Profesor nuevoProfe;
        Alumno nuevoAlumno;
        public string nombre;
        public string apellido;
        public int dni;

        public string contrasenia;

        public AltaUsuario()
        {
            InitializeComponent();
        }
        public Usuario GetUsuario()
        {
            if(nuevoAdmin != null)
            {
                return nuevoAdmin;
            }
            else if(nuevoProfe != null)
            {
                return nuevoProfe;
            }
            else if(nuevoAlumno != null)
            {
                return nuevoAlumno;
            }
            return null;
        }

        public bool CargaDatos()
        {
            int todoOk = 0;
            string buffer;
            
            buffer = txb_nombre.Text;
            if(!string.IsNullOrWhiteSpace(buffer))
            {
                nombre = buffer;
                todoOk++;
            }
            buffer = txb_apellido.Text;
            if (!string.IsNullOrWhiteSpace(buffer))
            {
                apellido = buffer;
                todoOk++;
            }   
            if(int.TryParse(txb_dni.Text, out dni))
            {
                todoOk++;
            }
            buffer = txb_contrasena.Text;
            if (!string.IsNullOrWhiteSpace(buffer))
            {
                contrasenia = buffer;
                todoOk++ ;
            }
            else
            {
                if(!string.IsNullOrWhiteSpace(txb_dni.Text))
                {
                    contrasenia = txb_dni.Text;
                    todoOk++;
                }
            }
            if(todoOk == 4)
            {
                return true;
            }
            return false;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (CargaDatos())
            {
                if (rbtn_tipoAdmin.Checked)
                {
                    nuevoAdmin = new Admin(nombre, apellido, dni, contrasenia);
                    this.DialogResult = DialogResult.OK;
                }
                else if (rbtn_tipoProfe.Checked)
                {
                    nuevoProfe = new Profesor(nombre, apellido, dni, contrasenia);
                    this.DialogResult = DialogResult.OK;
                }
                else if (rbtn_tipoAlumno.Checked)
                {
                    nuevoAlumno = new Alumno(nombre, apellido, dni, contrasenia);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    lbl_ingreseTipo.Text = "Debe seleccionar tipo de usuario";
                }
            }
            else
            {
                MessageBox.Show("Se deben completar todos los campos", "Formulario incompleto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
