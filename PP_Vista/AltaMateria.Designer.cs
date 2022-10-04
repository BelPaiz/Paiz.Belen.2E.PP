namespace PP_Vista
{
    partial class AltaMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaMateria));
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.nUd_cuatri = new System.Windows.Forms.NumericUpDown();
            this.lbl_cuatri = new System.Windows.Forms.Label();
            this.dtg_profes = new System.Windows.Forms.DataGridView();
            this.Id_profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_materias = new System.Windows.Forms.DataGridView();
            this.id_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_profe = new System.Windows.Forms.Label();
            this.lbl_correlativa = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_cuatri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_profes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_materias)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_nombre
            // 
            this.txb_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_nombre.Location = new System.Drawing.Point(161, 31);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PlaceholderText = "Ingrese nombre de materia";
            this.txb_nombre.Size = new System.Drawing.Size(397, 29);
            this.txb_nombre.TabIndex = 0;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(161, 394);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 35);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // nUd_cuatri
            // 
            this.nUd_cuatri.Location = new System.Drawing.Point(396, 74);
            this.nUd_cuatri.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUd_cuatri.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUd_cuatri.Name = "nUd_cuatri";
            this.nUd_cuatri.Size = new System.Drawing.Size(120, 23);
            this.nUd_cuatri.TabIndex = 5;
            this.nUd_cuatri.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_cuatri
            // 
            this.lbl_cuatri.AutoSize = true;
            this.lbl_cuatri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cuatri.Location = new System.Drawing.Point(189, 74);
            this.lbl_cuatri.Name = "lbl_cuatri";
            this.lbl_cuatri.Size = new System.Drawing.Size(174, 21);
            this.lbl_cuatri.TabIndex = 6;
            this.lbl_cuatri.Text = "Seleccione cuatrimestre";
            // 
            // dtg_profes
            // 
            this.dtg_profes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_profes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_profesor,
            this.nombre_profesor});
            this.dtg_profes.Location = new System.Drawing.Point(73, 159);
            this.dtg_profes.Name = "dtg_profes";
            this.dtg_profes.RowTemplate.Height = 25;
            this.dtg_profes.Size = new System.Drawing.Size(199, 150);
            this.dtg_profes.TabIndex = 7;
            this.dtg_profes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_profes_CellClick);
            // 
            // Id_profesor
            // 
            this.Id_profesor.HeaderText = "Id Profesor";
            this.Id_profesor.Name = "Id_profesor";
            this.Id_profesor.Width = 50;
            // 
            // nombre_profesor
            // 
            this.nombre_profesor.HeaderText = "Nombre";
            this.nombre_profesor.Name = "nombre_profesor";
            // 
            // dtg_materias
            // 
            this.dtg_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_materias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_materia,
            this.nombre});
            this.dtg_materias.Location = new System.Drawing.Point(406, 159);
            this.dtg_materias.Name = "dtg_materias";
            this.dtg_materias.RowTemplate.Height = 25;
            this.dtg_materias.Size = new System.Drawing.Size(209, 150);
            this.dtg_materias.TabIndex = 8;
            this.dtg_materias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_materias_CellClick);
            // 
            // id_materia
            // 
            this.id_materia.HeaderText = "Id Materia";
            this.id_materia.Name = "id_materia";
            this.id_materia.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // lbl_profe
            // 
            this.lbl_profe.AutoSize = true;
            this.lbl_profe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_profe.Location = new System.Drawing.Point(71, 125);
            this.lbl_profe.Name = "lbl_profe";
            this.lbl_profe.Size = new System.Drawing.Size(201, 21);
            this.lbl_profe.TabIndex = 9;
            this.lbl_profe.Text = "Seleccione profesor a cargo";
            // 
            // lbl_correlativa
            // 
            this.lbl_correlativa.AutoSize = true;
            this.lbl_correlativa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_correlativa.Location = new System.Drawing.Point(430, 125);
            this.lbl_correlativa.Name = "lbl_correlativa";
            this.lbl_correlativa.Size = new System.Drawing.Size(160, 21);
            this.lbl_correlativa.TabIndex = 10;
            this.lbl_correlativa.Text = "Seleccione correlativa";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(441, 394);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // AltaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(713, 464);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_correlativa);
            this.Controls.Add(this.lbl_profe);
            this.Controls.Add(this.dtg_materias);
            this.Controls.Add(this.dtg_profes);
            this.Controls.Add(this.lbl_cuatri);
            this.Controls.Add(this.nUd_cuatri);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txb_nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta nueva materia";
            this.Load += new System.EventHandler(this.AltaMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUd_cuatri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_profes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_materias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txb_nombre;
        private Button btn_aceptar;
        private NumericUpDown nUd_cuatri;
        private Label lbl_cuatri;
        private DataGridView dtg_profes;
        private DataGridView dtg_materias;
        private Label lbl_profe;
        private Label lbl_correlativa;
        private Button btn_cancelar;
        private DataGridViewTextBoxColumn id_materia;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Id_profesor;
        private DataGridViewTextBoxColumn nombre_profesor;
    }
}