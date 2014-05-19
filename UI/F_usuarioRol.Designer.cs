namespace UI
{
    partial class F_usuarioRol
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
            this.simpleButton_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView_roles = new System.Windows.Forms.DataGridView();
            this.lookUpEdit_usuario = new DevExpress.XtraEditors.LookUpEdit();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDelRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_usuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(787, 380);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(181, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton_guardar);
            this.groupBox1.Controls.Add(this.dataGridView_roles);
            this.groupBox1.Controls.Add(this.lookUpEdit_usuario);
            this.groupBox1.Location = new System.Drawing.Point(156, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 316);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar Roles a usuario";
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
            // dataGridView_roles
            // 
            this.dataGridView_roles.AllowUserToAddRows = false;
            this.dataGridView_roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado,
            this.Identificador,
            this.NombreDelRol});
            this.dataGridView_roles.Location = new System.Drawing.Point(261, 19);
            this.dataGridView_roles.Name = "dataGridView_roles";
            this.dataGridView_roles.Size = new System.Drawing.Size(467, 273);
            this.dataGridView_roles.TabIndex = 1;
            // 
            // lookUpEdit_usuario
            // 
            this.lookUpEdit_usuario.Location = new System.Drawing.Point(35, 113);
            this.lookUpEdit_usuario.Name = "lookUpEdit_usuario";
            this.lookUpEdit_usuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_usuario.Size = new System.Drawing.Size(178, 20);
            this.lookUpEdit_usuario.TabIndex = 0;
            this.lookUpEdit_usuario.TextChanged += new System.EventHandler(this.lookUpEdit_usuario_TextChanged);
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado_usurio_rol";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 46;
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "id_rol";
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            this.Identificador.Width = 90;
            // 
            // NombreDelRol
            // 
            this.NombreDelRol.DataPropertyName = "nombre_rol";
            this.NombreDelRol.HeaderText = "NombreDelRol";
            this.NombreDelRol.Name = "NombreDelRol";
            this.NombreDelRol.ReadOnly = true;
            this.NombreDelRol.Width = 101;
            // 
            // F_usuarioRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 415);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_usuarioRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_usuario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_guardar;
        private System.Windows.Forms.DataGridView dataGridView_roles;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_usuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDelRol;
    }
}