namespace UI
{
    partial class F_modificarprecioproducto
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
            this.textEdit_contexto = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_buscar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox_precios = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_precioventa = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_nPrecio = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl_compra = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contexto.Properties)).BeginInit();
            this.groupBox_precios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nPrecio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(771, 380);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(197, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit_contexto
            // 
            this.textEdit_contexto.Location = new System.Drawing.Point(135, 146);
            this.textEdit_contexto.Name = "textEdit_contexto";
            this.textEdit_contexto.Size = new System.Drawing.Size(205, 20);
            this.textEdit_contexto.TabIndex = 1;
            this.textEdit_contexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_contexto_KeyPress);
            // 
            // simpleButton_buscar
            // 
            this.simpleButton_buscar.Location = new System.Drawing.Point(200, 172);
            this.simpleButton_buscar.Name = "simpleButton_buscar";
            this.simpleButton_buscar.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_buscar.TabIndex = 2;
            this.simpleButton_buscar.Text = "Buscar";
            this.simpleButton_buscar.Click += new System.EventHandler(this.simpleButton_buscar_Click);
            // 
            // groupBox_precios
            // 
            this.groupBox_precios.Controls.Add(this.labelControl_compra);
            this.groupBox_precios.Controls.Add(this.labelControl4);
            this.groupBox_precios.Controls.Add(this.simpleButton_guardar);
            this.groupBox_precios.Controls.Add(this.textEdit_nPrecio);
            this.groupBox_precios.Controls.Add(this.labelControl2);
            this.groupBox_precios.Controls.Add(this.labelControl_precioventa);
            this.groupBox_precios.Controls.Add(this.labelControl1);
            this.groupBox_precios.Location = new System.Drawing.Point(464, 91);
            this.groupBox_precios.Name = "groupBox_precios";
            this.groupBox_precios.Size = new System.Drawing.Size(363, 234);
            this.groupBox_precios.TabIndex = 3;
            this.groupBox_precios.TabStop = false;
            this.groupBox_precios.Text = "Precio de venta";
            this.groupBox_precios.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "El precio actual es de venta";
            // 
            // labelControl_precioventa
            // 
            this.labelControl_precioventa.Location = new System.Drawing.Point(271, 59);
            this.labelControl_precioventa.Name = "labelControl_precioventa";
            this.labelControl_precioventa.Size = new System.Drawing.Size(22, 13);
            this.labelControl_precioventa.TabIndex = 1;
            this.labelControl_precioventa.Text = "0.00";
            this.labelControl_precioventa.TextChanged += new System.EventHandler(this.labelControl_precioventa_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nuevo precio de venta";
            // 
            // textEdit_nPrecio
            // 
            this.textEdit_nPrecio.EditValue = "0.00";
            this.textEdit_nPrecio.Location = new System.Drawing.Point(193, 100);
            this.textEdit_nPrecio.Name = "textEdit_nPrecio";
            this.textEdit_nPrecio.Size = new System.Drawing.Size(100, 20);
            this.textEdit_nPrecio.TabIndex = 3;
            this.textEdit_nPrecio.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // simpleButton_guardar
            // 
            this.simpleButton_guardar.Location = new System.Drawing.Point(97, 138);
            this.simpleButton_guardar.Name = "simpleButton_guardar";
            this.simpleButton_guardar.Size = new System.Drawing.Size(172, 23);
            this.simpleButton_guardar.TabIndex = 4;
            this.simpleButton_guardar.Text = "Guardar";
            this.simpleButton_guardar.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl_compra
            // 
            this.labelControl_compra.Location = new System.Drawing.Point(271, 29);
            this.labelControl_compra.Name = "labelControl_compra";
            this.labelControl_compra.Size = new System.Drawing.Size(22, 13);
            this.labelControl_compra.TabIndex = 6;
            this.labelControl_compra.Text = "0.00";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(37, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(139, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "El precio actual es de compra";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(86, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Producto";
            // 
            // F_modificarprecioproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 415);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.groupBox_precios);
            this.Controls.Add(this.simpleButton_buscar);
            this.Controls.Add(this.textEdit_contexto);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_modificarprecioproducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contexto.Properties)).EndInit();
            this.groupBox_precios.ResumeLayout(false);
            this.groupBox_precios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nPrecio.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit_contexto;
        private DevExpress.XtraEditors.SimpleButton simpleButton_buscar;
        private System.Windows.Forms.GroupBox groupBox_precios;
        private DevExpress.XtraEditors.SimpleButton simpleButton_guardar;
        private DevExpress.XtraEditors.TextEdit textEdit_nPrecio;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl_precioventa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl_compra;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}