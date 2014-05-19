namespace UI
{
    partial class F_cliente
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
            this.simpleButton_eliminar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_editar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.textEdit_correo = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_telefono = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_direccion = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_nit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_nombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox_buscar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_mostrarContexto = new DevExpress.XtraEditors.TextEdit();
            this.groupBox_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_correo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_telefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_direccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nombre.Properties)).BeginInit();
            this.groupBox_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_mostrarContexto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(792, 380);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(176, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox_Datos
            // 
            this.groupBox_Datos.Controls.Add(this.simpleButton_eliminar);
            this.groupBox_Datos.Controls.Add(this.simpleButton_editar);
            this.groupBox_Datos.Controls.Add(this.simpleButton_guardar);
            this.groupBox_Datos.Controls.Add(this.dateTimePicker_fecha);
            this.groupBox_Datos.Controls.Add(this.textEdit_correo);
            this.groupBox_Datos.Controls.Add(this.textEdit_telefono);
            this.groupBox_Datos.Controls.Add(this.textEdit_direccion);
            this.groupBox_Datos.Controls.Add(this.textEdit_nit);
            this.groupBox_Datos.Controls.Add(this.textEdit_nombre);
            this.groupBox_Datos.Controls.Add(this.labelControl6);
            this.groupBox_Datos.Controls.Add(this.labelControl5);
            this.groupBox_Datos.Controls.Add(this.labelControl4);
            this.groupBox_Datos.Controls.Add(this.labelControl3);
            this.groupBox_Datos.Controls.Add(this.labelControl2);
            this.groupBox_Datos.Controls.Add(this.labelControl1);
            this.groupBox_Datos.Location = new System.Drawing.Point(329, 50);
            this.groupBox_Datos.Name = "groupBox_Datos";
            this.groupBox_Datos.Size = new System.Drawing.Size(609, 305);
            this.groupBox_Datos.TabIndex = 1;
            this.groupBox_Datos.TabStop = false;
            this.groupBox_Datos.Text = "Cliente";
            this.groupBox_Datos.Visible = false;
            // 
            // simpleButton_eliminar
            // 
            this.simpleButton_eliminar.Location = new System.Drawing.Point(438, 223);
            this.simpleButton_eliminar.Name = "simpleButton_eliminar";
            this.simpleButton_eliminar.Size = new System.Drawing.Size(150, 23);
            this.simpleButton_eliminar.TabIndex = 2;
            this.simpleButton_eliminar.Text = "Eliminar";
            this.simpleButton_eliminar.Visible = false;
            this.simpleButton_eliminar.Click += new System.EventHandler(this.simpleButton_eliminar_Click);
            // 
            // simpleButton_editar
            // 
            this.simpleButton_editar.Location = new System.Drawing.Point(438, 193);
            this.simpleButton_editar.Name = "simpleButton_editar";
            this.simpleButton_editar.Size = new System.Drawing.Size(150, 23);
            this.simpleButton_editar.TabIndex = 2;
            this.simpleButton_editar.Text = "Guardar edicion";
            this.simpleButton_editar.Visible = false;
            this.simpleButton_editar.Click += new System.EventHandler(this.simpleButton_editar_Click);
            // 
            // simpleButton_guardar
            // 
            this.simpleButton_guardar.Location = new System.Drawing.Point(438, 164);
            this.simpleButton_guardar.Name = "simpleButton_guardar";
            this.simpleButton_guardar.Size = new System.Drawing.Size(150, 23);
            this.simpleButton_guardar.TabIndex = 6;
            this.simpleButton_guardar.Text = "Guardar";
            this.simpleButton_guardar.Visible = false;
            this.simpleButton_guardar.Click += new System.EventHandler(this.simpleButton_guardar_Click);
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(208, 236);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_fecha.TabIndex = 5;
            // 
            // textEdit_correo
            // 
            this.textEdit_correo.Location = new System.Drawing.Point(208, 197);
            this.textEdit_correo.Name = "textEdit_correo";
            this.textEdit_correo.Size = new System.Drawing.Size(224, 20);
            this.textEdit_correo.TabIndex = 4;
            // 
            // textEdit_telefono
            // 
            this.textEdit_telefono.Location = new System.Drawing.Point(208, 156);
            this.textEdit_telefono.Name = "textEdit_telefono";
            this.textEdit_telefono.Size = new System.Drawing.Size(100, 20);
            this.textEdit_telefono.TabIndex = 3;
            // 
            // textEdit_direccion
            // 
            this.textEdit_direccion.Location = new System.Drawing.Point(208, 119);
            this.textEdit_direccion.Name = "textEdit_direccion";
            this.textEdit_direccion.Size = new System.Drawing.Size(301, 20);
            this.textEdit_direccion.TabIndex = 2;
            // 
            // textEdit_nit
            // 
            this.textEdit_nit.Location = new System.Drawing.Point(208, 85);
            this.textEdit_nit.Name = "textEdit_nit";
            this.textEdit_nit.Size = new System.Drawing.Size(100, 20);
            this.textEdit_nit.TabIndex = 1;
            // 
            // textEdit_nombre
            // 
            this.textEdit_nombre.Location = new System.Drawing.Point(208, 43);
            this.textEdit_nombre.Name = "textEdit_nombre";
            this.textEdit_nombre.Size = new System.Drawing.Size(301, 20);
            this.textEdit_nombre.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(58, 243);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(98, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Fecha de nacimiento";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(58, 204);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Correo";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(58, 164);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Telefono";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(58, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Direccion";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(13, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nit";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre";
            // 
            // groupBox_buscar
            // 
            this.groupBox_buscar.Controls.Add(this.label1);
            this.groupBox_buscar.Controls.Add(this.simpleButton2);
            this.groupBox_buscar.Controls.Add(this.textEdit_mostrarContexto);
            this.groupBox_buscar.Location = new System.Drawing.Point(12, 127);
            this.groupBox_buscar.Name = "groupBox_buscar";
            this.groupBox_buscar.Size = new System.Drawing.Size(311, 139);
            this.groupBox_buscar.TabIndex = 2;
            this.groupBox_buscar.TabStop = false;
            this.groupBox_buscar.Text = "Buscar";
            this.groupBox_buscar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(66, 77);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(164, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Buscar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit_mostrarContexto
            // 
            this.textEdit_mostrarContexto.Location = new System.Drawing.Point(74, 51);
            this.textEdit_mostrarContexto.Name = "textEdit_mostrarContexto";
            this.textEdit_mostrarContexto.Size = new System.Drawing.Size(219, 20);
            this.textEdit_mostrarContexto.TabIndex = 0;
            this.textEdit_mostrarContexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_buscar_KeyPress);
            // 
            // F_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 415);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_buscar);
            this.Controls.Add(this.groupBox_Datos);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.groupBox_Datos.ResumeLayout(false);
            this.groupBox_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_correo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_telefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_direccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nombre.Properties)).EndInit();
            this.groupBox_buscar.ResumeLayout(false);
            this.groupBox_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_mostrarContexto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox_Datos;
        private DevExpress.XtraEditors.SimpleButton simpleButton_eliminar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_editar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_guardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private DevExpress.XtraEditors.TextEdit textEdit_correo;
        private DevExpress.XtraEditors.TextEdit textEdit_telefono;
        private DevExpress.XtraEditors.TextEdit textEdit_direccion;
        private DevExpress.XtraEditors.TextEdit textEdit_nit;
        private DevExpress.XtraEditors.TextEdit textEdit_nombre;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox_buscar;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textEdit_mostrarContexto;
        private System.Windows.Forms.Label label1;
    }
}