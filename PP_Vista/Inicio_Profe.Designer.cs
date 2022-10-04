namespace PP_Vista
{
    partial class frm_Inicio_Profe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Inicio_Profe));
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.dtg_materias = new System.Windows.Forms.DataGridView();
            this.materias_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia_cuatri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_materiasCargo = new System.Windows.Forms.Label();
            this.dtg_examenes = new System.Windows.Forms.DataGridView();
            this.materia_examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examen_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_alumnos = new System.Windows.Forms.DataGridView();
            this.examen_alumno_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examen_alumno_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_alumno_nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_examenes = new System.Windows.Forms.Label();
            this.lbl_alumnos = new System.Windows.Forms.Label();
            this.btn_nuevoExamen = new System.Windows.Forms.Button();
            this.lbl_cargaExamen = new System.Windows.Forms.Label();
            this.btn_guardarNotas = new System.Windows.Forms.Button();
            this.nUd_notaNueva = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_materias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_examenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_notaNueva)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenida.Location = new System.Drawing.Point(26, 22);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(0, 50);
            this.lbl_bienvenida.TabIndex = 0;
            // 
            // dtg_materias
            // 
            this.dtg_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_materias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materias_id,
            this.materia_nombre,
            this.materia_cuatri});
            this.dtg_materias.Location = new System.Drawing.Point(12, 114);
            this.dtg_materias.Name = "dtg_materias";
            this.dtg_materias.RowTemplate.Height = 25;
            this.dtg_materias.Size = new System.Drawing.Size(344, 150);
            this.dtg_materias.TabIndex = 1;
            this.dtg_materias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_materias_CellClick);
            // 
            // materias_id
            // 
            this.materias_id.HeaderText = "Id";
            this.materias_id.Name = "materias_id";
            // 
            // materia_nombre
            // 
            this.materia_nombre.HeaderText = "Nombre";
            this.materia_nombre.Name = "materia_nombre";
            // 
            // materia_cuatri
            // 
            this.materia_cuatri.HeaderText = "Cuatrimestre";
            this.materia_cuatri.Name = "materia_cuatri";
            // 
            // lbl_materiasCargo
            // 
            this.lbl_materiasCargo.AutoSize = true;
            this.lbl_materiasCargo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_materiasCargo.Location = new System.Drawing.Point(116, 79);
            this.lbl_materiasCargo.Name = "lbl_materiasCargo";
            this.lbl_materiasCargo.Size = new System.Drawing.Size(131, 21);
            this.lbl_materiasCargo.TabIndex = 2;
            this.lbl_materiasCargo.Text = "Materias a cargo";
            // 
            // dtg_examenes
            // 
            this.dtg_examenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_examenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materia_examen,
            this.examen_fecha});
            this.dtg_examenes.Location = new System.Drawing.Point(355, 114);
            this.dtg_examenes.Name = "dtg_examenes";
            this.dtg_examenes.RowTemplate.Height = 25;
            this.dtg_examenes.Size = new System.Drawing.Size(196, 151);
            this.dtg_examenes.TabIndex = 3;
            this.dtg_examenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_examenes_CellClick);
            // 
            // materia_examen
            // 
            this.materia_examen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.materia_examen.HeaderText = "Examenes";
            this.materia_examen.Name = "materia_examen";
            this.materia_examen.Width = 85;
            // 
            // examen_fecha
            // 
            this.examen_fecha.HeaderText = "Fecha";
            this.examen_fecha.Name = "examen_fecha";
            // 
            // dtg_alumnos
            // 
            this.dtg_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examen_alumno_id,
            this.examen_alumno_nombre,
            this.exam_alumno_nota});
            this.dtg_alumnos.Location = new System.Drawing.Point(550, 114);
            this.dtg_alumnos.Name = "dtg_alumnos";
            this.dtg_alumnos.RowTemplate.Height = 25;
            this.dtg_alumnos.Size = new System.Drawing.Size(343, 318);
            this.dtg_alumnos.TabIndex = 4;
            this.dtg_alumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_alumnos_CellClick);
            // 
            // examen_alumno_id
            // 
            this.examen_alumno_id.HeaderText = "Id alumno";
            this.examen_alumno_id.Name = "examen_alumno_id";
            // 
            // examen_alumno_nombre
            // 
            this.examen_alumno_nombre.HeaderText = "Nombre";
            this.examen_alumno_nombre.Name = "examen_alumno_nombre";
            // 
            // exam_alumno_nota
            // 
            this.exam_alumno_nota.HeaderText = "Nota";
            this.exam_alumno_nota.Name = "exam_alumno_nota";
            // 
            // lbl_examenes
            // 
            this.lbl_examenes.AutoSize = true;
            this.lbl_examenes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_examenes.Location = new System.Drawing.Point(409, 79);
            this.lbl_examenes.Name = "lbl_examenes";
            this.lbl_examenes.Size = new System.Drawing.Size(82, 21);
            this.lbl_examenes.TabIndex = 5;
            this.lbl_examenes.Text = "Examenes";
            // 
            // lbl_alumnos
            // 
            this.lbl_alumnos.AutoSize = true;
            this.lbl_alumnos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_alumnos.Location = new System.Drawing.Point(649, 79);
            this.lbl_alumnos.Name = "lbl_alumnos";
            this.lbl_alumnos.Size = new System.Drawing.Size(151, 21);
            this.lbl_alumnos.TabIndex = 6;
            this.lbl_alumnos.Text = "Listado de alumnos";
            // 
            // btn_nuevoExamen
            // 
            this.btn_nuevoExamen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nuevoExamen.Location = new System.Drawing.Point(392, 271);
            this.btn_nuevoExamen.Name = "btn_nuevoExamen";
            this.btn_nuevoExamen.Size = new System.Drawing.Size(126, 39);
            this.btn_nuevoExamen.TabIndex = 7;
            this.btn_nuevoExamen.Text = "Crear nuevo examen";
            this.btn_nuevoExamen.UseVisualStyleBackColor = true;
            this.btn_nuevoExamen.Click += new System.EventHandler(this.btn_nuevoExamen_Click);
            // 
            // lbl_cargaExamen
            // 
            this.lbl_cargaExamen.AutoSize = true;
            this.lbl_cargaExamen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_cargaExamen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cargaExamen.Location = new System.Drawing.Point(158, 379);
            this.lbl_cargaExamen.Name = "lbl_cargaExamen";
            this.lbl_cargaExamen.Size = new System.Drawing.Size(0, 21);
            this.lbl_cargaExamen.TabIndex = 8;
            // 
            // btn_guardarNotas
            // 
            this.btn_guardarNotas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_guardarNotas.Location = new System.Drawing.Point(728, 454);
            this.btn_guardarNotas.Name = "btn_guardarNotas";
            this.btn_guardarNotas.Size = new System.Drawing.Size(126, 39);
            this.btn_guardarNotas.TabIndex = 9;
            this.btn_guardarNotas.Text = "Cambiar nota";
            this.btn_guardarNotas.UseVisualStyleBackColor = true;
            this.btn_guardarNotas.Click += new System.EventHandler(this.btn_guardarNotas_Click);
            // 
            // nUd_notaNueva
            // 
            this.nUd_notaNueva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nUd_notaNueva.Location = new System.Drawing.Point(585, 459);
            this.nUd_notaNueva.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUd_notaNueva.Name = "nUd_notaNueva";
            this.nUd_notaNueva.Size = new System.Drawing.Size(120, 29);
            this.nUd_notaNueva.TabIndex = 10;
            // 
            // frm_Inicio_Profe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(913, 548);
            this.Controls.Add(this.nUd_notaNueva);
            this.Controls.Add(this.btn_guardarNotas);
            this.Controls.Add(this.lbl_cargaExamen);
            this.Controls.Add(this.btn_nuevoExamen);
            this.Controls.Add(this.lbl_alumnos);
            this.Controls.Add(this.lbl_examenes);
            this.Controls.Add(this.dtg_alumnos);
            this.Controls.Add(this.dtg_examenes);
            this.Controls.Add(this.lbl_materiasCargo);
            this.Controls.Add(this.dtg_materias);
            this.Controls.Add(this.lbl_bienvenida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Inicio_Profe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Profesor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Inicio_Profe_FormClosing);
            this.Load += new System.EventHandler(this.frm_Inicio_Profe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_materias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_examenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_notaNueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_bienvenida;
        private DataGridView dtg_materias;
        private Label lbl_materiasCargo;
        private DataGridViewTextBoxColumn materias_id;
        private DataGridViewTextBoxColumn materia_nombre;
        private DataGridViewTextBoxColumn materia_cuatri;
        private DataGridView dtg_examenes;
        private DataGridView dtg_alumnos;
        private DataGridViewTextBoxColumn examen_alumno_id;
        private DataGridViewTextBoxColumn examen_alumno_nombre;
        private DataGridViewTextBoxColumn exam_alumno_nota;
        private Label lbl_examenes;
        private Label lbl_alumnos;
        private Button btn_nuevoExamen;
        private Label lbl_cargaExamen;
        private DataGridViewTextBoxColumn materia_examen;
        private Button btn_guardarNotas;
        private NumericUpDown nUd_notaNueva;
        private DataGridViewTextBoxColumn examen_fecha;
    }
}