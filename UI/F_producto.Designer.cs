namespace UI
{
    partial class F_producto
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
            this.lookUpEdit_marca = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit_porcentaje = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_codigo = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox_buscar = new System.Windows.Forms.GroupBox();
            this.simpleButton_buscar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_contexto = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_marca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_porcentaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_codigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcion.Properties)).BeginInit();
            this.groupBox_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contexto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(808, 380);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(160, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox_datos
            // 
            this.groupBox_datos.Controls.Add(this.simpleButton_eliminar);
            this.groupBox_datos.Controls.Add(this.simpleButton_editar);
            this.groupBox_datos.Controls.Add(this.simpleButton_guardar);
            this.groupBox_datos.Controls.Add(this.lookUpEdit_marca);
            this.groupBox_datos.Controls.Add(this.textEdit_porcentaje);
            this.groupBox_datos.Controls.Add(this.textEdit_codigo);
            this.groupBox_datos.Controls.Add(this.textEdit_descripcion);
            this.groupBox_datos.Controls.Add(this.labelControl5);
            this.groupBox_datos.Controls.Add(this.labelControl4);
            this.groupBox_datos.Controls.Add(this.labelControl3);
            this.groupBox_datos.Controls.Add(this.labelControl2);
            this.groupBox_datos.Location = new System.Drawing.Point(317, 22);
            this.groupBox_datos.Name = "groupBox_datos";
            this.groupBox_datos.Size = new System.Drawing.Size(637, 328);
            this.groupBox_datos.TabIndex = 1;
            this.groupBox_datos.TabStop = false;
            this.groupBox_datos.Text = "Datos";
            this.groupBox_datos.Visible = false;
            // 
            // simpleButton_eliminar
            // 
            this.simpleButton_eliminar.Location = new System.Drawing.Point(249, 254);
            this.simpleButton_eliminar.Name = "simpleButton_eliminar";
            this.simpleButton_eliminar.Size = new System.Drawing.Size(197, 23);
            this.simpleButton_eliminar.TabIndex = 10;
            this.simpleButton_eliminar.Text = "Eliminar";
            this.simpleButton_eliminar.Click += new System.EventHandler(this.simpleButton_eliminar_Click);
            // 
            // simpleButton_editar
            // 
            this.simpleButton_editar.Location = new System.Drawing.Point(249, 225);
            this.simpleButton_editar.Name = "simpleButton_editar";
            this.simpleButton_editar.Size = new System.Drawing.Size(197, 23);
            this.simpleButton_editar.TabIndex = 9;
            this.simpleButton_editar.Text = "Guardar edicion";
            this.simpleButton_editar.Click += new System.EventHandler(this.simpleButton_editar_Click);
            // 
            // simpleButton_guardar
            // 
            this.simpleButton_guardar.Location = new System.Drawing.Point(249, 196);
            this.simpleButton_guardar.Name = "simpleButton_guardar";
            this.simpleButton_guardar.Size = new System.Drawing.Size(197, 23);
            this.simpleButton_guardar.TabIndex = 8;
            this.simpleButton_guardar.Text = "Guardar";
            this.simpleButton_guardar.Click += new System.EventHandler(this.simpleButton_guardar_Click);
            // 
            // lookUpEdit_marca
            // 
            this.lookUpEdit_marca.Location = new System.Drawing.Point(201, 157);
            this.lookUpEdit_marca.Name = "lookUpEdit_marca";
            this.lookUpEdit_marca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_marca.Size = new System.Drawing.Size(293, 20);
            this.lookUpEdit_marca.TabIndex = 7;
            // 
            // textEdit_porcentaje
            // 
            this.textEdit_porcentaje.EditValue = "";
            this.textEdit_porcentaje.Location = new System.Drawing.Point(201, 117);
            this.textEdit_porcentaje.Name = "textEdit_porcentaje";
            this.textEdit_porcentaje.Properties.Mask.EditMask = "p";
            this.textEdit_porcentaje.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_porcentaje.Size = new System.Drawing.Size(100, 20);
            this.textEdit_porcentaje.TabIndex = 6;
            // 
            // textEdit_codigo
            // 
            this.textEdit_codigo.Location = new System.Drawing.Point(201, 87);
            this.textEdit_codigo.Name = "textEdit_codigo";
            this.textEdit_codigo.Size = new System.Drawing.Size(100, 20);
            this.textEdit_codigo.TabIndex = 5;
            // 
            // textEdit_descripcion
            // 
            this.textEdit_descripcion.Location = new System.Drawing.Point(201, 57);
            this.textEdit_descripcion.Name = "textEdit_descripcion";
            this.textEdit_descripcion.Size = new System.Drawing.Size(293, 20);
            this.textEdit_descripcion.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(59, 157);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Marca";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(59, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(113, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Porcentaje de ganancia";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(59, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Codigo de producto";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Descripcion";
            // 
            // groupBox_buscar
            // 
            this.groupBox_buscar.Controls.Add(this.label1);
            this.groupBox_buscar.Controls.Add(this.simpleButton_buscar);
            this.groupBox_buscar.Controls.Add(this.labelControl1);
            this.groupBox_buscar.Controls.Add(this.textEdit_contexto);
            this.groupBox_buscar.Location = new System.Drawing.Point(12, 126);
            this.groupBox_buscar.Name = "groupBox_buscar";
            this.groupBox_buscar.Size = new System.Drawing.Size(288, 160);
            this.groupBox_buscar.TabIndex = 2;
            this.groupBox_buscar.TabStop = false;
            this.groupBox_buscar.Text = "Busqueda";
            this.groupBox_buscar.Visible = false;
            // 
            // simpleButton_buscar
            // 
            this.simpleButton_buscar.Location = new System.Drawing.Point(72, 76);
            this.simpleButton_buscar.Name = "simpleButton_buscar";
            this.simpleButton_buscar.Size = new System.Drawing.Size(105, 23);
            this.simpleButton_buscar.TabIndex = 2;
            this.simpleButton_buscar.Text = "Buscar";
            this.simpleButton_buscar.Click += new System.EventHandler(this.simpleButton_buscar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(54, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Producto";
            // 
            // textEdit_contexto
            // 
            this.textEdit_contexto.Location = new System.Drawing.Point(103, 50);
            this.textEdit_contexto.Name = "textEdit_contexto";
            this.textEdit_contexto.Size = new System.Drawing.Size(100, 20);
            this.textEdit_contexto.TabIndex = 0;
            this.textEdit_contexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_contexto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(29, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "El codigo de producto no se puede modificar";
            // 
            // F_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 415);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_buscar);
            this.Controls.Add(this.groupBox_datos);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "F_producto";
            this.groupBox_datos.ResumeLayout(false);
            this.groupBox_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_marca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_porcentaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_codigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcion.Properties)).EndInit();
            this.groupBox_buscar.ResumeLayout(false);
            this.groupBox_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contexto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox_datos;
        private System.Windows.Forms.GroupBox groupBox_buscar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_buscar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_contexto;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_marca;
        private DevExpress.XtraEditors.TextEdit textEdit_porcentaje;
        private DevExpress.XtraEditors.TextEdit textEdit_codigo;
        private DevExpress.XtraEditors.TextEdit textEdit_descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_eliminar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_editar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_guardar;
        private System.Windows.Forms.Label label1;
    }
}