namespace UI
{
    partial class F_buscar
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
            this.gridControl_busqueda = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_busqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_busqueda
            // 
            this.gridControl_busqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_busqueda.Location = new System.Drawing.Point(0, 0);
            this.gridControl_busqueda.MainView = this.gridView1;
            this.gridControl_busqueda.Name = "gridControl_busqueda";
            this.gridControl_busqueda.Size = new System.Drawing.Size(784, 561);
            this.gridControl_busqueda.TabIndex = 0;
            this.gridControl_busqueda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl_busqueda.DoubleClick += new System.EventHandler(this.gridControl_busqueda_DoubleClick);
            this.gridControl_busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControl_busqueda_KeyPress);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_busqueda;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // F_buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControl_busqueda);
            this.Name = "F_buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.F_buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_busqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_busqueda;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}