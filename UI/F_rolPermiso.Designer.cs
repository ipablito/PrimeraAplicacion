namespace UI
{
    partial class F_rolPermiso
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lookUpEdit_rol = new DevExpress.XtraEditors.LookUpEdit();
            this.dataGridView_permisos = new System.Windows.Forms.DataGridView();
            this.simpleButton_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionDelPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_rol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_permisos)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(812, 380);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(156, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton_guardar);
            this.groupBox1.Controls.Add(this.dataGridView_permisos);
            this.groupBox1.Controls.Add(this.lookUpEdit_rol);
            this.groupBox1.Location = new System.Drawing.Point(133, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar permisos a un rol";
            // 
            // lookUpEdit_rol
            // 
            this.lookUpEdit_rol.Location = new System.Drawing.Point(63, 113);
            this.lookUpEdit_rol.Name = "lookUpEdit_rol";
            this.lookUpEdit_rol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_rol.Size = new System.Drawing.Size(137, 20);
            this.lookUpEdit_rol.TabIndex = 0;
            this.lookUpEdit_rol.TextChanged += new System.EventHandler(this.lookUpEdit_rol_TextChanged);
            // 
            // dataGridView_permisos
            // 
            this.dataGridView_permisos.AllowUserToAddRows = false;
            this.dataGridView_permisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_permisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.DescripcionDelPermiso,
            this.Estado});
            this.dataGridView_permisos.Location = new System.Drawing.Point(261, 19);
            this.dataGridView_permisos.Name = "dataGridView_permisos";
            this.dataGridView_permisos.Size = new System.Drawing.Size(467, 273);
            this.dataGridView_permisos.TabIndex = 1;
            this.dataGridView_permisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_permisos_CellClick);
            this.dataGridView_permisos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_permisos_DataError);
            // 
            // simpleButton_guardar
            // 
            this.simpleButton_guardar.Location = new System.Drawing.Point(52, 247);
            this.simpleButton_guardar.Name = "simpleButton_guardar";
            this.simpleButton_guardar.Size = new System.Drawing.Size(161, 23);
            this.simpleButton_guardar.TabIndex = 2;
            this.simpleButton_guardar.Text = "Guardar";
            this.simpleButton_guardar.Click += new System.EventHandler(this.simpleButton_guardar_Click);
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "id_permiso";
            this.Identificador.Frozen = true;
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            this.Identificador.Width = 90;
            // 
            // DescripcionDelPermiso
            // 
            this.DescripcionDelPermiso.DataPropertyName = "descripcion_permiso";
            this.DescripcionDelPermiso.Frozen = true;
            this.DescripcionDelPermiso.HeaderText = "DescripcionDelPermiso";
            this.DescripcionDelPermiso.Name = "DescripcionDelPermiso";
            this.DescripcionDelPermiso.ReadOnly = true;
            this.DescripcionDelPermiso.Width = 141;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado_rol_permiso";
            this.Estado.Frozen = true;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Estado.Width = 65;
            // 
            // F_rolPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 415);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_rolPermiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_rol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_permisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_guardar;
        private System.Windows.Forms.DataGridView dataGridView_permisos;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionDelPermiso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
    }
}