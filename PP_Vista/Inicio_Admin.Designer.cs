
namespace PP_Vista
{
    partial class frm_inicioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicioAdmin));
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.rtb_alumnos = new System.Windows.Forms.RichTextBox();
            this.dtg_listaAlumnos = new System.Windows.Forms.DataGridView();
            this.Colum_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_alumnos = new System.Windows.Forms.Label();
            this.lbl_materias = new System.Windows.Forms.Label();
            this.nUd_estado = new System.Windows.Forms.NumericUpDown();
            this.btn_cambiarEstado = new System.Windows.Forms.Button();
            this.lbl_estadoCursada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_listaProfes = new System.Windows.Forms.DataGridView();
            this.id_profes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtb_materiasCargo = new System.Windows.Forms.RichTextBox();
            this.dtg_listaMaterias = new System.Windows.Forms.DataGridView();
            this.id_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuatri_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_listaProfes = new System.Windows.Forms.Label();
            this.lbl_materiasAcargo = new System.Windows.Forms.Label();
            this.lbl_listaMaterias = new System.Windows.Forms.Label();
            this.btn_asignarMateria = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaNuevaMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_mater = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaProfes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaMaterias)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenida.Location = new System.Drawing.Point(45, 37);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(0, 50);
            this.lbl_bienvenida.TabIndex = 1;
            // 
            // rtb_alumnos
            // 
            this.rtb_alumnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_alumnos.Location = new System.Drawing.Point(1051, 139);
            this.rtb_alumnos.Name = "rtb_alumnos";
            this.rtb_alumnos.Size = new System.Drawing.Size(267, 139);
            this.rtb_alumnos.TabIndex = 2;
            this.rtb_alumnos.Text = "";
            // 
            // dtg_listaAlumnos
            // 
            this.dtg_listaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colum_Id,
            this.Colum_Nombre});
            this.dtg_listaAlumnos.Location = new System.Drawing.Point(810, 139);
            this.dtg_listaAlumnos.Name = "dtg_listaAlumnos";
            this.dtg_listaAlumnos.RowTemplate.Height = 25;
            this.dtg_listaAlumnos.Size = new System.Drawing.Size(240, 410);
            this.dtg_listaAlumnos.TabIndex = 3;
            this.dtg_listaAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listaAlumnos_CellClick);
            // 
            // Colum_Id
            // 
            this.Colum_Id.HeaderText = "Id";
            this.Colum_Id.Name = "Colum_Id";
            // 
            // Colum_Nombre
            // 
            this.Colum_Nombre.HeaderText = "Nombre";
            this.Colum_Nombre.Name = "Colum_Nombre";
            // 
            // lbl_alumnos
            // 
            this.lbl_alumnos.AutoSize = true;
            this.lbl_alumnos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_alumnos.Location = new System.Drawing.Point(841, 111);
            this.lbl_alumnos.Name = "lbl_alumnos";
            this.lbl_alumnos.Size = new System.Drawing.Size(187, 25);
            this.lbl_alumnos.TabIndex = 4;
            this.lbl_alumnos.Text = "Listado de Alumnos";
            // 
            // lbl_materias
            // 
            this.lbl_materias.AutoSize = true;
            this.lbl_materias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_materias.Location = new System.Drawing.Point(1094, 111);
            this.lbl_materias.Name = "lbl_materias";
            this.lbl_materias.Size = new System.Drawing.Size(184, 25);
            this.lbl_materias.TabIndex = 5;
            this.lbl_materias.Text = "Listado de Materias";
            // 
            // nUd_estado
            // 
            this.nUd_estado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nUd_estado.Location = new System.Drawing.Point(1115, 353);
            this.nUd_estado.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUd_estado.Name = "nUd_estado";
            this.nUd_estado.Size = new System.Drawing.Size(43, 29);
            this.nUd_estado.TabIndex = 6;
            // 
            // btn_cambiarEstado
            // 
            this.btn_cambiarEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cambiarEstado.Location = new System.Drawing.Point(1192, 351);
            this.btn_cambiarEstado.Name = "btn_cambiarEstado";
            this.btn_cambiarEstado.Size = new System.Drawing.Size(86, 34);
            this.btn_cambiarEstado.TabIndex = 7;
            this.btn_cambiarEstado.Text = "Cambiar";
            this.btn_cambiarEstado.UseVisualStyleBackColor = true;
            this.btn_cambiarEstado.Click += new System.EventHandler(this.btn_cambiarEstado_Click);
            // 
            // lbl_estadoCursada
            // 
            this.lbl_estadoCursada.AutoSize = true;
            this.lbl_estadoCursada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_estadoCursada.Location = new System.Drawing.Point(1084, 288);
            this.lbl_estadoCursada.Name = "lbl_estadoCursada";
            this.lbl_estadoCursada.Size = new System.Drawing.Size(208, 21);
            this.lbl_estadoCursada.TabIndex = 8;
            this.lbl_estadoCursada.Text = "Cambiar estado de cursada :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1115, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "0 Libre / 1 Regular";
            // 
            // dtg_listaProfes
            // 
            this.dtg_listaProfes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listaProfes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_profes,
            this.nombre_profe});
            this.dtg_listaProfes.Location = new System.Drawing.Point(34, 139);
            this.dtg_listaProfes.Name = "dtg_listaProfes";
            this.dtg_listaProfes.RowTemplate.Height = 25;
            this.dtg_listaProfes.Size = new System.Drawing.Size(240, 314);
            this.dtg_listaProfes.TabIndex = 10;
            this.dtg_listaProfes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listaProfes_CellClick);
            // 
            // id_profes
            // 
            this.id_profes.HeaderText = "Id";
            this.id_profes.Name = "id_profes";
            // 
            // nombre_profe
            // 
            this.nombre_profe.HeaderText = "Nombre";
            this.nombre_profe.Name = "nombre_profe";
            // 
            // rtb_materiasCargo
            // 
            this.rtb_materiasCargo.Location = new System.Drawing.Point(273, 139);
            this.rtb_materiasCargo.Name = "rtb_materiasCargo";
            this.rtb_materiasCargo.Size = new System.Drawing.Size(138, 314);
            this.rtb_materiasCargo.TabIndex = 11;
            this.rtb_materiasCargo.Text = "";
            // 
            // dtg_listaMaterias
            // 
            this.dtg_listaMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listaMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_materia,
            this.nombre_materia,
            this.cuatri_materia});
            this.dtg_listaMaterias.Location = new System.Drawing.Point(411, 139);
            this.dtg_listaMaterias.Name = "dtg_listaMaterias";
            this.dtg_listaMaterias.RowTemplate.Height = 25;
            this.dtg_listaMaterias.Size = new System.Drawing.Size(342, 314);
            this.dtg_listaMaterias.TabIndex = 12;
            this.dtg_listaMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listaMaterias_CellClick);
            // 
            // id_materia
            // 
            this.id_materia.HeaderText = "Id";
            this.id_materia.Name = "id_materia";
            // 
            // nombre_materia
            // 
            this.nombre_materia.HeaderText = "Materia";
            this.nombre_materia.Name = "nombre_materia";
            // 
            // cuatri_materia
            // 
            this.cuatri_materia.HeaderText = "Cuatrimestre";
            this.cuatri_materia.Name = "cuatri_materia";
            // 
            // lbl_listaProfes
            // 
            this.lbl_listaProfes.AutoSize = true;
            this.lbl_listaProfes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_listaProfes.Location = new System.Drawing.Point(56, 111);
            this.lbl_listaProfes.Name = "lbl_listaProfes";
            this.lbl_listaProfes.Size = new System.Drawing.Size(203, 25);
            this.lbl_listaProfes.TabIndex = 13;
            this.lbl_listaProfes.Text = "Listado de Profesores";
            // 
            // lbl_materiasAcargo
            // 
            this.lbl_materiasAcargo.AutoSize = true;
            this.lbl_materiasAcargo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_materiasAcargo.Location = new System.Drawing.Point(304, 111);
            this.lbl_materiasAcargo.Name = "lbl_materiasAcargo";
            this.lbl_materiasAcargo.Size = new System.Drawing.Size(78, 25);
            this.lbl_materiasAcargo.TabIndex = 14;
            this.lbl_materiasAcargo.Text = "a cargo";
            // 
            // lbl_listaMaterias
            // 
            this.lbl_listaMaterias.AutoSize = true;
            this.lbl_listaMaterias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_listaMaterias.Location = new System.Drawing.Point(483, 111);
            this.lbl_listaMaterias.Name = "lbl_listaMaterias";
            this.lbl_listaMaterias.Size = new System.Drawing.Size(184, 25);
            this.lbl_listaMaterias.TabIndex = 15;
            this.lbl_listaMaterias.Text = "Listado de Materias";
            // 
            // btn_asignarMateria
            // 
            this.btn_asignarMateria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_asignarMateria.Location = new System.Drawing.Point(469, 466);
            this.btn_asignarMateria.Name = "btn_asignarMateria";
            this.btn_asignarMateria.Size = new System.Drawing.Size(229, 40);
            this.btn_asignarMateria.TabIndex = 16;
            this.btn_asignarMateria.Text = "Asignar Materia a Profesor";
            this.btn_asignarMateria.UseVisualStyleBackColor = true;
            this.btn_asignarMateria.Click += new System.EventHandler(this.btn_agregarMateriaProfe_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaNuevaMateriaToolStripMenuItem,
            this.altaNuevoUsuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1351, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaNuevaMateriaToolStripMenuItem
            // 
            this.altaNuevaMateriaToolStripMenuItem.Name = "altaNuevaMateriaToolStripMenuItem";
            this.altaNuevaMateriaToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.altaNuevaMateriaToolStripMenuItem.Text = "Alta Nueva Materia";
            this.altaNuevaMateriaToolStripMenuItem.Click += new System.EventHandler(this.altaNuevaMateriaToolStripMenuItem_Click);
            // 
            // altaNuevoUsuarioToolStripMenuItem
            // 
            this.altaNuevoUsuarioToolStripMenuItem.Name = "altaNuevoUsuarioToolStripMenuItem";
            this.altaNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.altaNuevoUsuarioToolStripMenuItem.Text = "Alta Nuevo Usuario";
            this.altaNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.altaNuevoUsuarioToolStripMenuItem_Click);
            // 
            // lbl_mater
            // 
            this.lbl_mater.AutoSize = true;
            this.lbl_mater.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mater.Location = new System.Drawing.Point(299, 86);
            this.lbl_mater.Name = "lbl_mater";
            this.lbl_mater.Size = new System.Drawing.Size(88, 25);
            this.lbl_mater.TabIndex = 18;
            this.lbl_mater.Text = "Materias";
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Info.Location = new System.Drawing.Point(34, 481);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(0, 21);
            this.lbl_Info.TabIndex = 19;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.LightGray;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir.Location = new System.Drawing.Point(34, 581);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(95, 53);
            this.btn_salir.TabIndex = 21;
            this.btn_salir.Text = "salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_inicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1351, 656);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lbl_mater);
            this.Controls.Add(this.btn_asignarMateria);
            this.Controls.Add(this.lbl_listaMaterias);
            this.Controls.Add(this.lbl_materiasAcargo);
            this.Controls.Add(this.lbl_listaProfes);
            this.Controls.Add(this.dtg_listaMaterias);
            this.Controls.Add(this.rtb_materiasCargo);
            this.Controls.Add(this.dtg_listaProfes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_estadoCursada);
            this.Controls.Add(this.btn_cambiarEstado);
            this.Controls.Add(this.nUd_estado);
            this.Controls.Add(this.lbl_materias);
            this.Controls.Add(this.lbl_alumnos);
            this.Controls.Add(this.dtg_listaAlumnos);
            this.Controls.Add(this.rtb_alumnos);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_inicioAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_inicioAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frm_inicioAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaProfes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listaMaterias)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_bienvenida;
        private RichTextBox rtb_alumnos;
        private DataGridView dtg_listaAlumnos;
        private DataGridViewTextBoxColumn Colum_Id;
        private DataGridViewTextBoxColumn Colum_Nombre;
        private Label lbl_alumnos;
        private Label lbl_materias;
        private NumericUpDown nUd_estado;
        private Button btn_cambiarEstado;
        private Label lbl_estadoCursada;
        private Label label1;
        private DataGridView dtg_listaProfes;
        private DataGridViewTextBoxColumn id_profes;
        private DataGridViewTextBoxColumn nombre_profe;
        private RichTextBox rtb_materiasCargo;
        private DataGridView dtg_listaMaterias;
        private DataGridViewTextBoxColumn id_materia;
        private DataGridViewTextBoxColumn nombre_materia;
        private Label lbl_listaProfes;
        private Label lbl_materiasAcargo;
        private Label lbl_listaMaterias;
        private DataGridViewTextBoxColumn cuatri_materia;
        private Button btn_asignarMateria;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem altaNuevaMateriaToolStripMenuItem;
        private ToolStripMenuItem altaNuevoUsuarioToolStripMenuItem;
        private Label lbl_mater;
        private Label lbl_Info;
        private Button btn_salir;
    }
}