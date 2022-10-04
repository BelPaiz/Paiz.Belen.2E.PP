namespace PP_Vista
{
    partial class NuevoExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoExamen));
            this.lstb_instanciasExamen = new System.Windows.Forms.ListBox();
            this.lbl_instancias = new System.Windows.Forms.Label();
            this.dTp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_InfoCreada = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstb_instanciasExamen
            // 
            this.lstb_instanciasExamen.FormattingEnabled = true;
            this.lstb_instanciasExamen.ItemHeight = 15;
            this.lstb_instanciasExamen.Location = new System.Drawing.Point(50, 113);
            this.lstb_instanciasExamen.Name = "lstb_instanciasExamen";
            this.lstb_instanciasExamen.Size = new System.Drawing.Size(228, 229);
            this.lstb_instanciasExamen.TabIndex = 0;
            this.lstb_instanciasExamen.SelectedIndexChanged += new System.EventHandler(this.lstb_instanciasExamen_SelectedIndexChanged);
            // 
            // lbl_instancias
            // 
            this.lbl_instancias.AutoSize = true;
            this.lbl_instancias.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_instancias.Location = new System.Drawing.Point(76, 68);
            this.lbl_instancias.Name = "lbl_instancias";
            this.lbl_instancias.Size = new System.Drawing.Size(157, 21);
            this.lbl_instancias.TabIndex = 1;
            this.lbl_instancias.Text = "Seleccione Instancia";
            // 
            // dTp_fecha
            // 
            this.dTp_fecha.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTp_fecha.Location = new System.Drawing.Point(365, 113);
            this.dTp_fecha.Name = "dTp_fecha";
            this.dTp_fecha.Size = new System.Drawing.Size(244, 23);
            this.dTp_fecha.TabIndex = 2;
            this.dTp_fecha.ValueChanged += new System.EventHandler(this.dTp_fecha_ValueChanged);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fecha.Location = new System.Drawing.Point(415, 68);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(135, 21);
            this.lbl_fecha.TabIndex = 3;
            this.lbl_fecha.Text = "Seleccione Fecha";
            // 
            // lbl_InfoCreada
            // 
            this.lbl_InfoCreada.AutoSize = true;
            this.lbl_InfoCreada.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_InfoCreada.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_InfoCreada.Location = new System.Drawing.Point(342, 203);
            this.lbl_InfoCreada.Name = "lbl_InfoCreada";
            this.lbl_InfoCreada.Size = new System.Drawing.Size(0, 21);
            this.lbl_InfoCreada.TabIndex = 4;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(354, 352);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(86, 37);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(539, 352);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(86, 37);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_welcome.Location = new System.Drawing.Point(244, 22);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(161, 21);
            this.lbl_welcome.TabIndex = 7;
            this.lbl_welcome.Text = "Crear Nuevo Examen";
            // 
            // NuevoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_InfoCreada);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.dTp_fecha);
            this.Controls.Add(this.lbl_instancias);
            this.Controls.Add(this.lstb_instanciasExamen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoEvamen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstb_instanciasExamen;
        private Label lbl_instancias;
        private DateTimePicker dTp_fecha;
        private Label lbl_fecha;
        private Label lbl_InfoCreada;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private Label lbl_welcome;
    }
}