namespace PP_Vista
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.txb_user = new System.Windows.Forms.TextBox();
            this.txb_pass = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_rellenarAdmin = new System.Windows.Forms.Button();
            this.btn_rellenarProfe = new System.Windows.Forms.Button();
            this.btn_rellenarAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_user
            // 
            this.txb_user.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_user.Location = new System.Drawing.Point(98, 163);
            this.txb_user.Name = "txb_user";
            this.txb_user.PlaceholderText = "Ingrese Id";
            this.txb_user.Size = new System.Drawing.Size(417, 33);
            this.txb_user.TabIndex = 0;
            // 
            // txb_pass
            // 
            this.txb_pass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_pass.Location = new System.Drawing.Point(98, 243);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.PasswordChar = '*';
            this.txb_pass.PlaceholderText = "Ingrese contraseña";
            this.txb_pass.Size = new System.Drawing.Size(417, 33);
            this.txb_pass.TabIndex = 1;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresar.Location = new System.Drawing.Point(235, 331);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(121, 39);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PP_Vista.Properties.Resources.foto_usuario;
            this.pictureBox1.Location = new System.Drawing.Point(219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_rellenarAdmin
            // 
            this.btn_rellenarAdmin.Location = new System.Drawing.Point(30, 399);
            this.btn_rellenarAdmin.Name = "btn_rellenarAdmin";
            this.btn_rellenarAdmin.Size = new System.Drawing.Size(126, 27);
            this.btn_rellenarAdmin.TabIndex = 4;
            this.btn_rellenarAdmin.Text = "Rellenar Admin";
            this.btn_rellenarAdmin.UseVisualStyleBackColor = true;
            this.btn_rellenarAdmin.Click += new System.EventHandler(this.btn_rellenarAdmin_Click);
            // 
            // btn_rellenarProfe
            // 
            this.btn_rellenarProfe.Location = new System.Drawing.Point(235, 399);
            this.btn_rellenarProfe.Name = "btn_rellenarProfe";
            this.btn_rellenarProfe.Size = new System.Drawing.Size(126, 27);
            this.btn_rellenarProfe.TabIndex = 5;
            this.btn_rellenarProfe.Text = "Rellenar Profe";
            this.btn_rellenarProfe.UseVisualStyleBackColor = true;
            this.btn_rellenarProfe.Click += new System.EventHandler(this.btn_rellenarProfe_Click);
            // 
            // btn_rellenarAlumno
            // 
            this.btn_rellenarAlumno.Location = new System.Drawing.Point(435, 399);
            this.btn_rellenarAlumno.Name = "btn_rellenarAlumno";
            this.btn_rellenarAlumno.Size = new System.Drawing.Size(126, 27);
            this.btn_rellenarAlumno.TabIndex = 6;
            this.btn_rellenarAlumno.Text = "Rellenar Alumno";
            this.btn_rellenarAlumno.UseVisualStyleBackColor = true;
            this.btn_rellenarAlumno.Click += new System.EventHandler(this.btn_rellenarAlumno_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.btn_rellenarAlumno);
            this.Controls.Add(this.btn_rellenarProfe);
            this.Controls.Add(this.btn_rellenarAdmin);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txb_pass);
            this.Controls.Add(this.txb_user);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txb_user;
        private TextBox txb_pass;
        private Button btn_ingresar;
        private PictureBox pictureBox1;
        private Button btn_rellenarAdmin;
        private Button btn_rellenarProfe;
        private Button btn_rellenarAlumno;
    }
}