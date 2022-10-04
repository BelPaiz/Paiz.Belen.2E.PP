namespace PP_Vista
{
    partial class frm_Inicio_Alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Inicio_Alumno));
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.dtg_cursadas = new System.Windows.Forms.DataGridView();
            this.materia_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia_Cuatri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia_correlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia_Aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materias_presente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_presente = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.mtp_inscripcionMaterias = new System.Windows.Forms.MenuStrip();
            this.inscripcionAMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_salir = new System.Windows.Forms.Button();
            this.rtxb_infoMaterias = new System.Windows.Forms.RichTextBox();
            this.lbl_infoMaterias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cursadas)).BeginInit();
            this.mtp_inscripcionMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenida.Location = new System.Drawing.Point(18, 63);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(0, 50);
            this.lbl_bienvenida.TabIndex = 0;
            // 
            // dtg_cursadas
            // 
            this.dtg_cursadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_cursadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materia_Nombre,
            this.materia_Cuatri,
            this.materia_correlat,
            this.materia_estado,
            this.materia_Aprobado,
            this.materias_presente});
            this.dtg_cursadas.Location = new System.Drawing.Point(82, 124);
            this.dtg_cursadas.Name = "dtg_cursadas";
            this.dtg_cursadas.RowTemplate.Height = 25;
            this.dtg_cursadas.Size = new System.Drawing.Size(637, 152);
            this.dtg_cursadas.TabIndex = 1;
            this.dtg_cursadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_cursadas_CellClick);
            // 
            // materia_Nombre
            // 
            this.materia_Nombre.HeaderText = "Nombre";
            this.materia_Nombre.Name = "materia_Nombre";
            // 
            // materia_Cuatri
            // 
            this.materia_Cuatri.HeaderText = "Cuatrimestre";
            this.materia_Cuatri.Name = "materia_Cuatri";
            // 
            // materia_correlat
            // 
            this.materia_correlat.HeaderText = "Correlativa";
            this.materia_correlat.Name = "materia_correlat";
            // 
            // materia_estado
            // 
            this.materia_estado.HeaderText = "Estado";
            this.materia_estado.Name = "materia_estado";
            // 
            // materia_Aprobado
            // 
            this.materia_Aprobado.HeaderText = "Aprobado";
            this.materia_Aprobado.Name = "materia_Aprobado";
            // 
            // materias_presente
            // 
            this.materias_presente.HeaderText = "Presentes";
            this.materias_presente.Name = "materias_presente";
            // 
            // btn_presente
            // 
            this.btn_presente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_presente.Location = new System.Drawing.Point(625, 296);
            this.btn_presente.Name = "btn_presente";
            this.btn_presente.Size = new System.Drawing.Size(94, 33);
            this.btn_presente.TabIndex = 2;
            this.btn_presente.Text = "Dar presente";
            this.btn_presente.UseVisualStyleBackColor = true;
            this.btn_presente.Click += new System.EventHandler(this.btn_presente_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.Color.Azure;
            this.lbl_info.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_info.Location = new System.Drawing.Point(82, 300);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 21);
            this.lbl_info.TabIndex = 3;
            // 
            // mtp_inscripcionMaterias
            // 
            this.mtp_inscripcionMaterias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripcionAMateriasToolStripMenuItem});
            this.mtp_inscripcionMaterias.Location = new System.Drawing.Point(0, 0);
            this.mtp_inscripcionMaterias.Name = "mtp_inscripcionMaterias";
            this.mtp_inscripcionMaterias.Size = new System.Drawing.Size(1036, 24);
            this.mtp_inscripcionMaterias.TabIndex = 4;
            this.mtp_inscripcionMaterias.Text = "menuStrip1";
            // 
            // inscripcionAMateriasToolStripMenuItem
            // 
            this.inscripcionAMateriasToolStripMenuItem.Name = "inscripcionAMateriasToolStripMenuItem";
            this.inscripcionAMateriasToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.inscripcionAMateriasToolStripMenuItem.Text = "Inscripcion a materias";
            this.inscripcionAMateriasToolStripMenuItem.Click += new System.EventHandler(this.inscripcionAMateriasToolStripMenuItem_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.LightGray;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir.Location = new System.Drawing.Point(18, 385);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(95, 53);
            this.btn_salir.TabIndex = 23;
            this.btn_salir.Text = "salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // rtxb_infoMaterias
            // 
            this.rtxb_infoMaterias.Location = new System.Drawing.Point(753, 124);
            this.rtxb_infoMaterias.Name = "rtxb_infoMaterias";
            this.rtxb_infoMaterias.Size = new System.Drawing.Size(238, 152);
            this.rtxb_infoMaterias.TabIndex = 24;
            this.rtxb_infoMaterias.Text = "";
            // 
            // lbl_infoMaterias
            // 
            this.lbl_infoMaterias.AutoSize = true;
            this.lbl_infoMaterias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_infoMaterias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_infoMaterias.Location = new System.Drawing.Point(776, 100);
            this.lbl_infoMaterias.Name = "lbl_infoMaterias";
            this.lbl_infoMaterias.Size = new System.Drawing.Size(189, 21);
            this.lbl_infoMaterias.TabIndex = 25;
            this.lbl_infoMaterias.Text = "Informacion de la cursada";
            // 
            // frm_Inicio_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.lbl_infoMaterias);
            this.Controls.Add(this.rtxb_infoMaterias);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_presente);
            this.Controls.Add(this.dtg_cursadas);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.mtp_inscripcionMaterias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mtp_inscripcionMaterias;
            this.Name = "frm_Inicio_Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Alumno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Inicio_Alumno_FormClosing);
            this.Load += new System.EventHandler(this.frm_Inicio_Alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cursadas)).EndInit();
            this.mtp_inscripcionMaterias.ResumeLayout(false);
            this.mtp_inscripcionMaterias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_bienvenida;
        private DataGridView dtg_cursadas;
        private DataGridViewTextBoxColumn materia_Nombre;
        private DataGridViewTextBoxColumn materia_Cuatri;
        private DataGridViewTextBoxColumn materia_correlat;
        private DataGridViewTextBoxColumn materia_estado;
        private DataGridViewTextBoxColumn materia_Aprobado;
        private DataGridViewTextBoxColumn materias_presente;
        private Button btn_presente;
        private Label lbl_info;
        private MenuStrip mtp_inscripcionMaterias;
        private ToolStripMenuItem inscripcionAMateriasToolStripMenuItem;
        private Button btn_salir;
        private RichTextBox rtxb_infoMaterias;
        private Label lbl_infoMaterias;
    }
}