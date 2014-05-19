namespace UI
{
    partial class F_marca
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
            this.textEdit_nombre = new DevExpress.XtraEditors.TextEdit();
            this.groupBox_buscar = new System.Windows.Forms.GroupBox();
            this.textEdit_contexto = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_cargar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nombre.Properties)).BeginInit();
            this.groupBox_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contexto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(809, 380);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(159, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox_Datos
            // 
            this.groupBox_Datos.Controls.Add(this.simpleButton_eliminar);
            this.groupBox_Datos.Controls.Add(this.simpleButton_editar);
            this.groupBox_Datos.Controls.Add(this.simpleButton_guardar);
            this.groupBox_Datos.Controls.Add(this.textEdit_nombre);
            this.groupBox_Datos.Location = new System.Drawing.Point(366, 49);
            this.groupBox_Datos.Name = "groupBox_Datos";
            this.groupBox_Datos.Size = new System.Drawing.Size(566, 306);
            this.groupBox_Datos.TabIndex = 1;
            this.groupBox_Datos.TabStop = false;
            this.groupBox_Datos.Text = "Marcas";
            this.groupBox_Datos.Visible = false;
            // 
            // simpleButton_eliminar
            // 
            this.simpleButton_eliminar.Location = new System.Drawing.Point(200, 165);
            this.simpleButton_eliminar.Name = "simpleButton_eliminar";
            this.simpleButton_eliminar.Size = new System.Drawing.Size(213, 23);
            this.simpleButton_eliminar.TabIndex = 3;
            this.simpleButton_eliminar.Text = "Eliminar";
            this.simpleButton_eliminar.Visible = false;
            this.simpleButton_eliminar.Click += new System.EventHandler(this.simpleButton_eliminar_Click);
            // 
            // simpleButton_editar
            // 
            this.simpleButton_editar.Location = new System.Drawing.Point(200, 135);
            this.simpleButton_editar.Name = "simpleButton_editar";
            this.simpleButton_editar.Size = new System.Drawing.Size(213, 23);
            this.simpleButton_editar.TabIndex = 2;
            this.simpleButton_editar.Text = "Guardar edicion";
            this.simpleButton_editar.Visible = false;
            this.simpleButton_editar.Click += new System.EventHandler(this.simpleButton_editar_Click);
            // 
            // simpleButton_guardar
            // 
            this.simpleButton_guardar.Location = new System.Drawing.Point(200, 105);
            this.simpleButton_guardar.Name = "simpleButton_guardar";
            this.simpleButton_guardar.Size = new System.Drawing.Size(213, 23);
            this.simpleButton_guardar.TabIndex = 1;
            this.simpleButton_guardar.Text = "Guardar";
            this.simpleButton_guardar.Visible = false;
            this.simpleButton_guardar.Click += new System.EventHandler(this.simpleButton_guardar_Click);
            // 
            // textEdit_nombre
            // 
            this.textEdit_nombre.Location = new System.Drawing.Point(115, 68);
            this.textEdit_nombre.Name = "textEdit_nombre";
            this.textEdit_nombre.Size = new System.Drawing.Size(365, 20);
            this.textEdit_nombre.TabIndex = 0;
            // 
            // groupBox_buscar
            // 
            this.groupBox_buscar.Controls.Add(this.textEdit_contexto);
            this.groupBox_buscar.Controls.Add(this.simpleButton_cargar);
            this.groupBox_buscar.Controls.Add(this.labelControl1);
            this.groupBox_buscar.Location = new System.Drawing.Point(40, 154);
            this.groupBox_buscar.Name = "groupBox_buscar";
            this.groupBox_buscar.Size = new System.Drawing.Size(286, 144);
            this.groupBox_buscar.TabIndex = 2;
            this.groupBox_buscar.TabStop = false;
            this.groupBox_buscar.Text = "Buscar";
            this.groupBox_buscar.Visible = false;
            // 
            // textEdit_contexto
            // 
            this.textEdit_contexto.Location = new System.Drawing.Point(99, 53);
            this.textEdit_contexto.Name = "textEdit_contexto";
            this.textEdit_contexto.Size = new System.Drawing.Size(144, 20);
            this.textEdit_contexto.TabIndex = 4;
            this.textEdit_contexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_contexto_KeyPress);
            // 
            // simpleButton_cargar
            // 
            this.simpleButton_cargar.Location = new System.Drawing.Point(62, 82);
            this.simpleButton_cargar.Name = "simpleButton_cargar";
            this.simpleButton_cargar.Size = new System.Drawing.Size(144, 23);
            this.simpleButton_cargar.TabIndex = 3;
            this.simpleButton_cargar.Text = "Cargar datos";
            this.simpleButton_cargar.Click += new System.EventHandler(this.simpleButton_cargar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(49, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Marca";
            // 
            // F_marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 415);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_buscar);
            this.Controls.Add(this.groupBox_Datos);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_marca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.groupBox_Datos.ResumeLayout(false);
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
        private DevExpress.XtraEditors.TextEdit textEdit_nombre;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cargar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_eliminar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_editar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_guardar;
        private DevExpress.XtraEditors.TextEdit textEdit_contexto;
    }
}