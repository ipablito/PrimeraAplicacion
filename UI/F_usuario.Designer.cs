namespace UI
{
    partial class F_usuario
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
            this.groupBox_buscar = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_nombre = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_telefono = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_usuario = new DevExpress.XtraEditors.TextEdit();
            this.textBox_contra = new System.Windows.Forms.TextBox();
            this.simpleButton_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_editar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_eliminar = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_contexto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_buscar = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_datos.SuspendLayout();
            this.groupBox_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_telefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_usuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contexto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(782, 380);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(186, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox_datos
            // 
            this.groupBox_datos.Controls.Add(this.simpleButton_eliminar);
            this.groupBox_datos.Controls.Add(this.simpleButton_editar);
            this.groupBox_datos.Controls.Add(this.simpleButton_guardar);
            this.groupBox_datos.Controls.Add(this.textBox_contra);
            this.groupBox_datos.Controls.Add(this.textEdit_usuario);
            this.groupBox_datos.Controls.Add(this.textEdit_telefono);
            this.groupBox_datos.Controls.Add(this.textEdit_nombre);
            this.groupBox_datos.Controls.Add(this.labelControl4);
            this.groupBox_datos.Controls.Add(this.labelControl3);
            this.groupBox_datos.Controls.Add(this.labelControl2);
            this.groupBox_datos.Controls.Add(this.labelControl1);
            this.groupBox_datos.Location = new System.Drawing.Point(300, 37);
            this.groupBox_datos.Name = "groupBox_datos";
            this.groupBox_datos.Size = new System.Drawing.Size(668, 309);
            this.groupBox_datos.TabIndex = 1;
            this.groupBox_datos.TabStop = false;
            this.groupBox_datos.Text = "Datos";
            this.groupBox_datos.Visible = false;
            // 
            // groupBox_buscar
            // 
            this.groupBox_buscar.Controls.Add(this.label1);
            this.groupBox_buscar.Controls.Add(this.simpleButton_buscar);
            this.groupBox_buscar.Controls.Add(this.labelControl5);
            this.groupBox_buscar.Controls.Add(this.textEdit_contexto);
            this.groupBox_buscar.Location = new System.Drawing.Point(12, 122);
            this.groupBox_buscar.Name = "groupBox_buscar";
            this.groupBox_buscar.Size = new System.Drawing.Size(276, 162);
            this.groupBox_buscar.TabIndex = 2;
            this.groupBox_buscar.TabStop = false;
            this.groupBox_buscar.Text = "Busqueda";
            this.groupBox_buscar.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre del empleado";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Telefono";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(41, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nombre de usuario";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(41, 160);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Contraseña";
            // 
            // textEdit_nombre
            // 
            this.textEdit_nombre.Location = new System.Drawing.Point(189, 62);
            this.textEdit_nombre.Name = "textEdit_nombre";
            this.textEdit_nombre.Size = new System.Drawing.Size(375, 20);
            this.textEdit_nombre.TabIndex = 4;
            // 
            // textEdit_telefono
            // 
            this.textEdit_telefono.Location = new System.Drawing.Point(189, 96);
            this.textEdit_telefono.Name = "textEdit_telefono";
            this.textEdit_telefono.Size = new System.Drawing.Size(100, 20);
            this.textEdit_telefono.TabIndex = 5;
            // 
            // textEdit_usuario
            // 
            this.textEdit_usuario.Location = new System.Drawing.Point(189, 123);
            this.textEdit_usuario.Name = "textEdit_usuario";
            this.textEdit_usuario.Size = new System.Drawing.Size(100, 20);
            this.textEdit_usuario.TabIndex = 6;
            // 
            // textBox_contra
            // 
            this.textBox_contra.Location = new System.Drawing.Point(189, 152);
            this.textBox_contra.MaxLength = 25;
            this.textBox_contra.Name = "textBox_contra";
            this.textBox_contra.PasswordChar = 'x';
            this.textBox_contra.Size = new System.Drawing.Size(100, 20);
            this.textBox_contra.TabIndex = 7;
            // 
            // simpleButton_guardar
            // 
            this.simpleButton_guardar.Location = new System.Drawing.Point(391, 160);
            this.simpleButton_guardar.Name = "simpleButton_guardar";
            this.simpleButton_guardar.Size = new System.Drawing.Size(180, 23);
            this.simpleButton_guardar.TabIndex = 8;
            this.simpleButton_guardar.Text = "Guardar";
            this.simpleButton_guardar.Visible = false;
            this.simpleButton_guardar.Click += new System.EventHandler(this.simpleButton_guardar_Click);
            // 
            // simpleButton_editar
            // 
            this.simpleButton_editar.Location = new System.Drawing.Point(391, 189);
            this.simpleButton_editar.Name = "simpleButton_editar";
            this.simpleButton_editar.Size = new System.Drawing.Size(180, 23);
            this.simpleButton_editar.TabIndex = 9;
            this.simpleButton_editar.Text = "Guardar edicion";
            this.simpleButton_editar.Visible = false;
            this.simpleButton_editar.Click += new System.EventHandler(this.simpleButton_editar_Click);
            // 
            // simpleButton_eliminar
            // 
            this.simpleButton_eliminar.Location = new System.Drawing.Point(391, 218);
            this.simpleButton_eliminar.Name = "simpleButton_eliminar";
            this.simpleButton_eliminar.Size = new System.Drawing.Size(180, 23);
            this.simpleButton_eliminar.TabIndex = 10;
            this.simpleButton_eliminar.Text = "Eliminar";
            this.simpleButton_eliminar.Visible = false;
            this.simpleButton_eliminar.Click += new System.EventHandler(this.simpleButton_eliminar_Click);
            // 
            // textEdit_contexto
            // 
            this.textEdit_contexto.Location = new System.Drawing.Point(93, 68);
            this.textEdit_contexto.Name = "textEdit_contexto";
            this.textEdit_contexto.Size = new System.Drawing.Size(154, 20);
            this.textEdit_contexto.TabIndex = 0;
            this.textEdit_contexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_contexto_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(51, 70);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Usuario";
            // 
            // simpleButton_buscar
            // 
            this.simpleButton_buscar.Location = new System.Drawing.Point(67, 94);
            this.simpleButton_buscar.Name = "simpleButton_buscar";
            this.simpleButton_buscar.Size = new System.Drawing.Size(141, 23);
            this.simpleButton_buscar.TabIndex = 2;
            this.simpleButton_buscar.Text = "Buscar";
            this.simpleButton_buscar.Click += new System.EventHandler(this.simpleButton_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "El nombre de usuario no se puede modificar";
            // 
            // F_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 415);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_buscar);
            this.Controls.Add(this.groupBox_datos);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.groupBox_datos.ResumeLayout(false);
            this.groupBox_datos.PerformLayout();
            this.groupBox_buscar.ResumeLayout(false);
            this.groupBox_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_telefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_usuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contexto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox_datos;
        private System.Windows.Forms.GroupBox groupBox_buscar;
        private System.Windows.Forms.TextBox textBox_contra;
        private DevExpress.XtraEditors.TextEdit textEdit_usuario;
        private DevExpress.XtraEditors.TextEdit textEdit_telefono;
        private DevExpress.XtraEditors.TextEdit textEdit_nombre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_eliminar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_editar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_guardar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit_contexto;
        private DevExpress.XtraEditors.SimpleButton simpleButton_buscar;
        private System.Windows.Forms.Label label1;
    }
}