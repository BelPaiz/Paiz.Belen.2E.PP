namespace PP_Vista
{
    partial class InscripcionMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscripcionMaterias));
            this.dtg_materias = new System.Windows.Forms.DataGridView();
            this.materias_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materias_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia_correlatividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materias_cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_materias)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_materias
            // 
            this.dtg_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_materias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materias_id,
            this.materias_nombre,
            this.materia_correlatividad,
            this.materias_cuatrimestre});
            this.dtg_materias.Location = new System.Drawing.Point(117, 106);
            this.dtg_materias.Name = "dtg_materias";
            this.dtg_materias.RowTemplate.Height = 25;
            this.dtg_materias.Size = new System.Drawing.Size(440, 183);
            this.dtg_materias.TabIndex = 0;
            this.dtg_materias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_materias_CellClick);
            // 
            // materias_id
            // 
            this.materias_id.HeaderText = "Id";
            this.materias_id.Name = "materias_id";
            // 
            // materias_nombre
            // 
            this.materias_nombre.HeaderText = "Nombre";
            this.materias_nombre.Name = "materias_nombre";
            // 
            // materia_correlatividad
            // 
            this.materia_correlatividad.HeaderText = "Correlatividad";
            this.materia_correlatividad.Name = "materia_correlatividad";
            // 
            // materias_cuatrimestre
            // 
            this.materias_cuatrimestre.HeaderText = "Cuatrimestre";
            this.materias_cuatrimestre.Name = "materias_cuatrimestre";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(164, 338);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(102, 37);
            this.btn_aceptar.TabIndex = 1;
            this.btn_aceptar.Text = "Inscribirse";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(403, 338);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 37);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_info.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_info.Location = new System.Drawing.Point(117, 387);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 21);
            this.lbl_info.TabIndex = 3;
            // 
            // InscripcionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(698, 481);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.dtg_materias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InscripcionMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion a Materias";
            this.Load += new System.EventHandler(this.InscripcionMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_materias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_materias;
        private DataGridViewTextBoxColumn materias_id;
        private DataGridViewTextBoxColumn materias_nombre;
        private DataGridViewTextBoxColumn materia_correlatividad;
        private DataGridViewTextBoxColumn materias_cuatrimestre;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private Label lbl_info;
    }
}