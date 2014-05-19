namespace UI
{
    partial class F_rol
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
            this.groupBox_datos = new System.Windows.Forms.GroupBox();
            this.simpleButton_eliminar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_editar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_nombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox_buscar = new System.Windows.Forms.GroupBox();
            this.simpleButton_buscar = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_contexto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nombre.Properties)).BeginInit();
            this.groupBox_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contexto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(806, 380);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(162, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox_datos
            // 
            this.groupBox_datos.Controls.Add(this.simpleButton_eliminar);
            this.groupBox_datos.Controls.Add(this.simpleButton_editar);
            this.groupBox_datos.Controls.Add(this.simpleButton_guardar);
            this.groupBox_datos.Controls.Add(this.textEdit_nombre);
            this.groupBox_datos.Controls.Add(this.labelControl2);
            this.groupBox_datos.Location = new System.Drawing.Point(389, 40);
            this.groupBox_datos.Name = "groupBox_datos";
            this.groupBox_datos.Size = new System.Drawing.Size(563, 302);
            this.groupBox_datos.TabIndex = 1;
            this.groupBox_datos.TabStop = false;
            this.groupBox_datos.Text = "Datos";
            this.groupBox_datos.Visible = false;
            // 
            // simpleButton_eliminar
            // 
            this.simpleButton_eliminar.Location = new System.Drawing.Point(172, 173);
            this.simpleButton_eliminar.Name = "simpleButton_eliminar";
            this.simpleButton_eliminar.Size = new System.Drawing.Size(196, 23);
            this.simpleButton_eliminar.TabIndex = 4;
            this.simpleButton_eliminar.Text = "Eliminar";
            this.simpleButton_eliminar.Visible = false;
            this.simpleButton_eliminar.Click += new System.EventHandler(this.simpleButton_eliminar_Click);
            // 
            // simpleButton_editar
            // 
            this.simpleButton_editar.Location = new System.Drawing.Point(172, 144);
            this.simpleButton_editar.Name = "simpleButton_editar";
            this.simpleButton_editar.Size = new System.Drawing.Size(196, 23);
            this.simpleButton_editar.TabIndex = 3;
            this.simpleButton_editar.Text = "Guardar edicion";
            this.simpleButton_editar.Visible = false;
            this.simpleButton_editar.Click += new System.EventHandler(this.simpleButton_editar_Click);
            // 
            // simpleButton_guardar
            // 
            this.simpleButton_guardar.Location = new System.Drawing.Point(172, 115);
            this.simpleButton_guardar.Name = "simpleButton_guardar";
            this.simpleButton_guardar.Size = new System.Drawing.Size(196, 23);
            this.simpleButton_guardar.TabIndex = 2;
            this.simpleButton_guardar.Text = "Guardar";
            this.simpleButton_guardar.Visible = false;
            this.simpleButton_guardar.Click += new System.EventHandler(this.simpleButton_guardar_Click);
            // 
            // textEdit_nombre
            // 
            this.textEdit_nombre.Location = new System.Drawing.Point(192, 75);
            this.textEdit_nombre.Name = "textEdit_nombre";
            this.textEdit_nombre.Size = new System.Drawing.Size(251, 20);
            this.textEdit_nombre.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(102, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nombre del rol";
            // 
            // groupBox_buscar
            // 
            this.groupBox_buscar.Controls.Add(this.simpleButton_buscar);
            this.groupBox_buscar.Controls.Add(this.textEdit_contexto);
            this.groupBox_buscar.Controls.Add(this.labelControl1);
            this.groupBox_buscar.Location = new System.Drawing.Point(40, 122);
            this.groupBox_buscar.Name = "groupBox_buscar";
            this.groupBox_buscar.Size = new System.Drawing.Size(263, 171);
            this.groupBox_buscar.TabIndex = 2;
            this.groupBox_buscar.TabStop = false;
            this.groupBox_buscar.Text = "Busqueda";
            this.groupBox_buscar.Visible = false;
            // 
            // simpleButton_buscar
            // 
            this.simpleButton_buscar.Location = new System.Drawing.Point(83, 88);
            this.simpleButton_buscar.Name = "simpleButton_buscar";
            this.simpleButton_buscar.Size = new System.Drawing.Size(92, 23);
            this.simpleButton_buscar.TabIndex = 2;
            this.simpleButton_buscar.Text = "Buscar";
            this.simpleButton_buscar.Click += new System.EventHandler(this.simpleButton_buscar_Click);
            // 
            // textEdit_contexto
            // 
            this.textEdit_contexto.Location = new System.Drawing.Point(102, 62);
            this.textEdit_contexto.Name = "textEdit_contexto";
            this.textEdit_contexto.Size = new System.Drawing.Size(100, 20);
            this.textEdit_contexto.TabIndex = 1;
            this.textEdit_contexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_contexto_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(72, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Rol";
            // 
            // F_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 415);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_buscar);
            this.Controls.Add(this.groupBox_datos);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_rol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.groupBox_datos.ResumeLayout(false);
            this.groupBox_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nombre.Properties)).EndInit();
            this.groupBox_buscar.ResumeLayout(false);
            this.groupBox_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contexto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox_datos;
        private DevExpress.XtraEditors.SimpleButton simpleButton_eliminar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_editar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_guardar;
        private DevExpress.XtraEditors.TextEdit textEdit_nombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox_buscar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_buscar;
        private DevExpress.XtraEditors.TextEdit textEdit_contexto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}