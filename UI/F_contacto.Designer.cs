namespace UI
{
    partial class F_contacto
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
            this.groupBox_Datos = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_proveedores = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton_eliminar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_editar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_direccion = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_telefono = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_nombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox_buscar = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_contexto = new DevExpress.XtraEditors.TextEdit();
            this.groupBox_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_proveedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_direccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_telefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nombre.Properties)).BeginInit();
            this.groupBox_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contexto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(795, 380);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(173, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox_Datos
            // 
            this.groupBox_Datos.Controls.Add(this.labelControl5);
            this.groupBox_Datos.Controls.Add(this.lookUpEdit_proveedores);
            this.groupBox_Datos.Controls.Add(this.simpleButton_eliminar);
            this.groupBox_Datos.Controls.Add(this.simpleButton_editar);
            this.groupBox_Datos.Controls.Add(this.simpleButton_guardar);
            this.groupBox_Datos.Controls.Add(this.textEdit_direccion);
            this.groupBox_Datos.Controls.Add(this.textEdit_telefono);
            this.groupBox_Datos.Controls.Add(this.textEdit_nombre);
            this.groupBox_Datos.Controls.Add(this.labelControl4);
            this.groupBox_Datos.Controls.Add(this.labelControl3);
            this.groupBox_Datos.Controls.Add(this.labelControl2);
            this.groupBox_Datos.Location = new System.Drawing.Point(311, 35);
            this.groupBox_Datos.Name = "groupBox_Datos";
            this.groupBox_Datos.Size = new System.Drawing.Size(630, 323);
            this.groupBox_Datos.TabIndex = 1;
            this.groupBox_Datos.TabStop = false;
            this.groupBox_Datos.Text = "Datos contacto";
            this.groupBox_Datos.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(90, 182);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Contacto de:";
            // 
            // lookUpEdit_proveedores
            // 
            this.lookUpEdit_proveedores.Location = new System.Drawing.Point(162, 179);
            this.lookUpEdit_proveedores.Name = "lookUpEdit_proveedores";
            this.lookUpEdit_proveedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_proveedores.Size = new System.Drawing.Size(311, 20);
            this.lookUpEdit_proveedores.TabIndex = 9;
            // 
            // simpleButton_eliminar
            // 
            this.simpleButton_eliminar.Location = new System.Drawing.Point(207, 276);
            this.simpleButton_eliminar.Name = "simpleButton_eliminar";
            this.simpleButton_eliminar.Size = new System.Drawing.Size(224, 23);
            this.simpleButton_eliminar.TabIndex = 8;
            this.simpleButton_eliminar.Text = "Eliminar";
            this.simpleButton_eliminar.Visible = false;
            this.simpleButton_eliminar.Click += new System.EventHandler(this.simpleButton_eliminar_Click);
            // 
            // simpleButton_editar
            // 
            this.simpleButton_editar.Location = new System.Drawing.Point(207, 247);
            this.simpleButton_editar.Name = "simpleButton_editar";
            this.simpleButton_editar.Size = new System.Drawing.Size(224, 23);
            this.simpleButton_editar.TabIndex = 7;
            this.simpleButton_editar.Text = "Guardar edicion";
            this.simpleButton_editar.Visible = false;
            this.simpleButton_editar.Click += new System.EventHandler(this.simpleButton_editar_Click);
            // 
            // simpleButton_guardar
            // 
            this.simpleButton_guardar.Location = new System.Drawing.Point(207, 218);
            this.simpleButton_guardar.Name = "simpleButton_guardar";
            this.simpleButton_guardar.Size = new System.Drawing.Size(224, 23);
            this.simpleButton_guardar.TabIndex = 6;
            this.simpleButton_guardar.Text = "Guardar";
            this.simpleButton_guardar.Visible = false;
            this.simpleButton_guardar.Click += new System.EventHandler(this.simpleButton_guardar_Click);
            // 
            // textEdit_direccion
            // 
            this.textEdit_direccion.Location = new System.Drawing.Point(162, 138);
            this.textEdit_direccion.Name = "textEdit_direccion";
            this.textEdit_direccion.Size = new System.Drawing.Size(311, 20);
            this.textEdit_direccion.TabIndex = 5;
            // 
            // textEdit_telefono
            // 
            this.textEdit_telefono.Location = new System.Drawing.Point(162, 96);
            this.textEdit_telefono.Name = "textEdit_telefono";
            this.textEdit_telefono.Size = new System.Drawing.Size(100, 20);
            this.textEdit_telefono.TabIndex = 4;
            // 
            // textEdit_nombre
            // 
            this.textEdit_nombre.Location = new System.Drawing.Point(162, 62);
            this.textEdit_nombre.Name = "textEdit_nombre";
            this.textEdit_nombre.Size = new System.Drawing.Size(311, 20);
            this.textEdit_nombre.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(90, 146);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Direccion";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(90, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Telefono";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(90, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nombre";
            // 
            // groupBox_buscar
            // 
            this.groupBox_buscar.Controls.Add(this.labelControl1);
            this.groupBox_buscar.Controls.Add(this.simpleButton2);
            this.groupBox_buscar.Controls.Add(this.textEdit_contexto);
            this.groupBox_buscar.Location = new System.Drawing.Point(12, 104);
            this.groupBox_buscar.Name = "groupBox_buscar";
            this.groupBox_buscar.Size = new System.Drawing.Size(293, 177);
            this.groupBox_buscar.TabIndex = 2;
            this.groupBox_buscar.TabStop = false;
            this.groupBox_buscar.Text = "Buscar contacto";
            this.groupBox_buscar.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Contacto";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(91, 77);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(95, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Buscar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit_contexto
            // 
            this.textEdit_contexto.Location = new System.Drawing.Point(100, 51);
            this.textEdit_contexto.Name = "textEdit_contexto";
            this.textEdit_contexto.Size = new System.Drawing.Size(100, 20);
            this.textEdit_contexto.TabIndex = 0;
            this.textEdit_contexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_contexto_KeyPress);
            // 
            // F_contacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 415);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_buscar);
            this.Controls.Add(this.groupBox_Datos);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_contacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.groupBox_Datos.ResumeLayout(false);
            this.groupBox_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_proveedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_direccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_telefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nombre.Properties)).EndInit();
            this.groupBox_buscar.ResumeLayout(false);
            this.groupBox_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contexto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox_Datos;
        private System.Windows.Forms.GroupBox groupBox_buscar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textEdit_contexto;
        private DevExpress.XtraEditors.TextEdit textEdit_direccion;
        private DevExpress.XtraEditors.TextEdit textEdit_telefono;
        private DevExpress.XtraEditors.TextEdit textEdit_nombre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_eliminar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_editar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_guardar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_proveedores;
    }
}