namespace PP_Vista
{
    partial class AltaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaUsuario));
            this.lbl_altaUsuario = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.txb_contrasena = new System.Windows.Forms.TextBox();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_ingreseDatos = new System.Windows.Forms.Label();
            this.gpb_tipo = new System.Windows.Forms.GroupBox();
            this.rbtn_tipoAlumno = new System.Windows.Forms.RadioButton();
            this.rbtn_tipoProfe = new System.Windows.Forms.RadioButton();
            this.rbtn_tipoAdmin = new System.Windows.Forms.RadioButton();
            this.lbl_ingreseTipo = new System.Windows.Forms.Label();
            this.gpb_tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_altaUsuario
            // 
            this.lbl_altaUsuario.AutoSize = true;
            this.lbl_altaUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_altaUsuario.Location = new System.Drawing.Point(241, 33);
            this.lbl_altaUsuario.Name = "lbl_altaUsuario";
            this.lbl_altaUsuario.Size = new System.Drawing.Size(291, 21);
            this.lbl_altaUsuario.TabIndex = 0;
            this.lbl_altaUsuario.Text = "Formulario de alta de Nuevo Usuario";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_nombre.Location = new System.Drawing.Point(37, 128);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PlaceholderText = "Ingrese nombre";
            this.txb_nombre.Size = new System.Drawing.Size(343, 29);
            this.txb_nombre.TabIndex = 1;
            // 
            // txb_apellido
            // 
            this.txb_apellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_apellido.Location = new System.Drawing.Point(37, 195);
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.PlaceholderText = "Ingrese apellido";
            this.txb_apellido.Size = new System.Drawing.Size(343, 29);
            this.txb_apellido.TabIndex = 2;
            // 
            // txb_contrasena
            // 
            this.txb_contrasena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_contrasena.Location = new System.Drawing.Point(37, 342);
            this.txb_contrasena.Name = "txb_contrasena";
            this.txb_contrasena.PlaceholderText = "Ingrese contraseña por defecto";
            this.txb_contrasena.Size = new System.Drawing.Size(343, 29);
            this.txb_contrasena.TabIndex = 3;
            // 
            // txb_dni
            // 
            this.txb_dni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_dni.Location = new System.Drawing.Point(37, 264);
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.PlaceholderText = "Ingrese Dni";
            this.txb_dni.Size = new System.Drawing.Size(343, 29);
            this.txb_dni.TabIndex = 4;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(458, 364);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(129, 44);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(639, 364);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 44);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_ingreseDatos
            // 
            this.lbl_ingreseDatos.AutoSize = true;
            this.lbl_ingreseDatos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_ingreseDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ingreseDatos.Location = new System.Drawing.Point(139, 86);
            this.lbl_ingreseDatos.Name = "lbl_ingreseDatos";
            this.lbl_ingreseDatos.Size = new System.Drawing.Size(134, 21);
            this.lbl_ingreseDatos.TabIndex = 10;
            this.lbl_ingreseDatos.Text = "Ingreso de datos";
            // 
            // gpb_tipo
            // 
            this.gpb_tipo.BackColor = System.Drawing.SystemColors.Control;
            this.gpb_tipo.Controls.Add(this.rbtn_tipoAlumno);
            this.gpb_tipo.Controls.Add(this.rbtn_tipoProfe);
            this.gpb_tipo.Controls.Add(this.rbtn_tipoAdmin);
            this.gpb_tipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpb_tipo.Location = new System.Drawing.Point(516, 128);
            this.gpb_tipo.Name = "gpb_tipo";
            this.gpb_tipo.Size = new System.Drawing.Size(190, 177);
            this.gpb_tipo.TabIndex = 11;
            this.gpb_tipo.TabStop = false;
            this.gpb_tipo.Text = "Tipo de Usuario";
            // 
            // rbtn_tipoAlumno
            // 
            this.rbtn_tipoAlumno.AutoSize = true;
            this.rbtn_tipoAlumno.Location = new System.Drawing.Point(30, 111);
            this.rbtn_tipoAlumno.Name = "rbtn_tipoAlumno";
            this.rbtn_tipoAlumno.Size = new System.Drawing.Size(83, 25);
            this.rbtn_tipoAlumno.TabIndex = 2;
            this.rbtn_tipoAlumno.TabStop = true;
            this.rbtn_tipoAlumno.Text = "Alumno";
            this.rbtn_tipoAlumno.UseVisualStyleBackColor = true;
            // 
            // rbtn_tipoProfe
            // 
            this.rbtn_tipoProfe.AutoSize = true;
            this.rbtn_tipoProfe.Location = new System.Drawing.Point(30, 80);
            this.rbtn_tipoProfe.Name = "rbtn_tipoProfe";
            this.rbtn_tipoProfe.Size = new System.Drawing.Size(87, 25);
            this.rbtn_tipoProfe.TabIndex = 1;
            this.rbtn_tipoProfe.TabStop = true;
            this.rbtn_tipoProfe.Text = "Profesor";
            this.rbtn_tipoProfe.UseVisualStyleBackColor = true;
            // 
            // rbtn_tipoAdmin
            // 
            this.rbtn_tipoAdmin.AutoSize = true;
            this.rbtn_tipoAdmin.Location = new System.Drawing.Point(30, 48);
            this.rbtn_tipoAdmin.Name = "rbtn_tipoAdmin";
            this.rbtn_tipoAdmin.Size = new System.Drawing.Size(128, 25);
            this.rbtn_tipoAdmin.TabIndex = 0;
            this.rbtn_tipoAdmin.TabStop = true;
            this.rbtn_tipoAdmin.Text = "Administrador";
            this.rbtn_tipoAdmin.UseVisualStyleBackColor = true;
            // 
            // lbl_ingreseTipo
            // 
            this.lbl_ingreseTipo.AutoSize = true;
            this.lbl_ingreseTipo.BackColor = System.Drawing.Color.Red;
            this.lbl_ingreseTipo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ingreseTipo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_ingreseTipo.Location = new System.Drawing.Point(488, 326);
            this.lbl_ingreseTipo.Name = "lbl_ingreseTipo";
            this.lbl_ingreseTipo.Size = new System.Drawing.Size(0, 21);
            this.lbl_ingreseTipo.TabIndex = 12;
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ingreseTipo);
            this.Controls.Add(this.gpb_tipo);
            this.Controls.Add(this.lbl_ingreseDatos);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txb_dni);
            this.Controls.Add(this.txb_contrasena);
            this.Controls.Add(this.txb_apellido);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.lbl_altaUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaUsuario";
            this.gpb_tipo.ResumeLayout(false);
            this.gpb_tipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_altaUsuario;
        private TextBox txb_nombre;
        private TextBox txb_apellido;
        private TextBox txb_contrasena;
        private TextBox txb_dni;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private Label lbl_ingreseDatos;
        private GroupBox gpb_tipo;
        private RadioButton rbtn_tipoAlumno;
        private RadioButton rbtn_tipoProfe;
        private RadioButton rbtn_tipoAdmin;
        private Label lbl_ingreseTipo;
    }
}