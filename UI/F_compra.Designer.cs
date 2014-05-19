namespace UI
{
    partial class F_compra
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
            this.dateTimePicker_fechaUsuario = new System.Windows.Forms.DateTimePicker();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textEdit_referencia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_descripcionproveedor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_nitproveedor = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit_bodega = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_serie = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_detalle = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_descripcionproducto = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_cantidadproducto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_preciocompraproducto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_codigoproducto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.CodigoDeProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_referencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcionproveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nitproveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_bodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_serie.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detalle)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcionproducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cantidadproducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_preciocompraproducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_codigoproducto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(792, 390);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(176, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_fechaUsuario);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lookUpEdit_bodega);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.lookUpEdit_serie);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // dateTimePicker_fechaUsuario
            // 
            this.dateTimePicker_fechaUsuario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_fechaUsuario.Location = new System.Drawing.Point(137, 90);
            this.dateTimePicker_fechaUsuario.Name = "dateTimePicker_fechaUsuario";
            this.dateTimePicker_fechaUsuario.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fechaUsuario.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(36, 93);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(93, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Fecha de la compra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textEdit_referencia);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.textEdit_descripcionproveedor);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.textEdit_nitproveedor);
            this.groupBox2.Location = new System.Drawing.Point(620, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 129);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proveedor";
            // 
            // textEdit_referencia
            // 
            this.textEdit_referencia.Location = new System.Drawing.Point(109, 96);
            this.textEdit_referencia.Name = "textEdit_referencia";
            this.textEdit_referencia.Size = new System.Drawing.Size(186, 20);
            this.textEdit_referencia.TabIndex = 21;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Referencia";
            // 
            // textEdit_descripcionproveedor
            // 
            this.textEdit_descripcionproveedor.Location = new System.Drawing.Point(109, 49);
            this.textEdit_descripcionproveedor.Name = "textEdit_descripcionproveedor";
            this.textEdit_descripcionproveedor.Size = new System.Drawing.Size(186, 20);
            this.textEdit_descripcionproveedor.TabIndex = 19;
            this.textEdit_descripcionproveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_descripcionproveedor_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Descripcion";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Nit del proveedor";
            // 
            // textEdit_nitproveedor
            // 
            this.textEdit_nitproveedor.Location = new System.Drawing.Point(109, 19);
            this.textEdit_nitproveedor.Name = "textEdit_nitproveedor";
            this.textEdit_nitproveedor.Size = new System.Drawing.Size(100, 20);
            this.textEdit_nitproveedor.TabIndex = 16;
            this.textEdit_nitproveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_nitproveedor_KeyPress);
            // 
            // lookUpEdit_bodega
            // 
            this.lookUpEdit_bodega.Location = new System.Drawing.Point(130, 61);
            this.lookUpEdit_bodega.Name = "lookUpEdit_bodega";
            this.lookUpEdit_bodega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_bodega.Size = new System.Drawing.Size(207, 20);
            this.lookUpEdit_bodega.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Bodega";
            // 
            // lookUpEdit_serie
            // 
            this.lookUpEdit_serie.Location = new System.Drawing.Point(130, 38);
            this.lookUpEdit_serie.Name = "lookUpEdit_serie";
            this.lookUpEdit_serie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_serie.Size = new System.Drawing.Size(207, 20);
            this.lookUpEdit_serie.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Serie de la compra";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButton3);
            this.groupBox3.Controls.Add(this.label_total);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dataGridView_detalle);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(956, 230);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles de la compra";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(729, 159);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(201, 39);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Ingresa registro";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.ForeColor = System.Drawing.Color.Blue;
            this.label_total.Location = new System.Drawing.Point(814, 114);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(28, 13);
            this.label_total.TabIndex = 3;
            this.label_total.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(777, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_detalle
            // 
            this.dataGridView_detalle.AllowUserToAddRows = false;
            this.dataGridView_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDeProducto,
            this.Descripcion,
            this.PrecioCosto,
            this.Cantidad,
            this.Subtotal,
            this.NoReferencia});
            this.dataGridView_detalle.Location = new System.Drawing.Point(12, 84);
            this.dataGridView_detalle.Name = "dataGridView_detalle";
            this.dataGridView_detalle.Size = new System.Drawing.Size(677, 140);
            this.dataGridView_detalle.TabIndex = 1;
            this.dataGridView_detalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_detalle_CellDoubleClick);
            this.dataGridView_detalle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_detalle_CellValueChanged);
            this.dataGridView_detalle.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_detalle_RowHeaderMouseDoubleClick);
            this.dataGridView_detalle.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_detalle_RowsAdded);
            this.dataGridView_detalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_detalle_RowsRemoved);
            this.dataGridView_detalle.DoubleClick += new System.EventHandler(this.dataGridView_detalle_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.simpleButton2);
            this.groupBox4.Controls.Add(this.textEdit_descripcionproducto);
            this.groupBox4.Controls.Add(this.textEdit_cantidadproducto);
            this.groupBox4.Controls.Add(this.labelControl10);
            this.groupBox4.Controls.Add(this.textEdit_preciocompraproducto);
            this.groupBox4.Controls.Add(this.labelControl9);
            this.groupBox4.Controls.Add(this.labelControl8);
            this.groupBox4.Controls.Add(this.textEdit_codigoproducto);
            this.groupBox4.Controls.Add(this.labelControl7);
            this.groupBox4.Location = new System.Drawing.Point(6, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(927, 64);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(655, 19);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(254, 23);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Cargar a la compra";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit_descripcionproducto
            // 
            this.textEdit_descripcionproducto.Location = new System.Drawing.Point(106, 35);
            this.textEdit_descripcionproducto.Name = "textEdit_descripcionproducto";
            this.textEdit_descripcionproducto.Size = new System.Drawing.Size(100, 20);
            this.textEdit_descripcionproducto.TabIndex = 8;
            this.textEdit_descripcionproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_descripcionproducto_KeyPress);
            // 
            // textEdit_cantidadproducto
            // 
            this.textEdit_cantidadproducto.EditValue = "1";
            this.textEdit_cantidadproducto.Location = new System.Drawing.Point(413, 39);
            this.textEdit_cantidadproducto.Name = "textEdit_cantidadproducto";
            this.textEdit_cantidadproducto.Properties.Mask.EditMask = "d";
            this.textEdit_cantidadproducto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_cantidadproducto.Size = new System.Drawing.Size(100, 20);
            this.textEdit_cantidadproducto.TabIndex = 7;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(312, 42);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(93, 13);
            this.labelControl10.TabIndex = 6;
            this.labelControl10.Text = "Cantidad comprada";
            // 
            // textEdit_preciocompraproducto
            // 
            this.textEdit_preciocompraproducto.Location = new System.Drawing.Point(413, 15);
            this.textEdit_preciocompraproducto.Name = "textEdit_preciocompraproducto";
            this.textEdit_preciocompraproducto.Properties.Mask.EditMask = "f";
            this.textEdit_preciocompraproducto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_preciocompraproducto.Size = new System.Drawing.Size(100, 20);
            this.textEdit_preciocompraproducto.TabIndex = 5;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(312, 18);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(58, 13);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Precio costo";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(6, 38);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 13);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Descripcion";
            // 
            // textEdit_codigoproducto
            // 
            this.textEdit_codigoproducto.Location = new System.Drawing.Point(106, 12);
            this.textEdit_codigoproducto.Name = "textEdit_codigoproducto";
            this.textEdit_codigoproducto.Size = new System.Drawing.Size(100, 20);
            this.textEdit_codigoproducto.TabIndex = 1;
            this.textEdit_codigoproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_codigoproducto_KeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(6, 19);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(94, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Codigo de producto";
            // 
            // CodigoDeProducto
            // 
            this.CodigoDeProducto.HeaderText = "CodigoDeProducto";
            this.CodigoDeProducto.Name = "CodigoDeProducto";
            this.CodigoDeProducto.ReadOnly = true;
            this.CodigoDeProducto.Width = 122;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 88;
            // 
            // PrecioCosto
            // 
            this.PrecioCosto.HeaderText = "PrecioCosto";
            this.PrecioCosto.Name = "PrecioCosto";
            this.PrecioCosto.ReadOnly = true;
            this.PrecioCosto.Width = 89;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 71;
            // 
            // NoReferencia
            // 
            this.NoReferencia.HeaderText = "NoReferencia";
            this.NoReferencia.Name = "NoReferencia";
            this.NoReferencia.ReadOnly = true;
            this.NoReferencia.Width = 98;
            // 
            // F_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 415);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_referencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcionproveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_nitproveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_bodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_serie.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detalle)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcionproducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cantidadproducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_preciocompraproducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_codigoproducto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit textEdit_descripcionproveedor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit_nitproveedor;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_bodega;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_serie;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit textEdit_referencia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit_codigoproducto;
        private DevExpress.XtraEditors.TextEdit textEdit_preciocompraproducto;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEdit_descripcionproducto;
        private DevExpress.XtraEditors.TextEdit textEdit_cantidadproducto;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_detalle;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoReferencia;
    }
}