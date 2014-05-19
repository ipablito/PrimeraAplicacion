namespace UI
{
    partial class F_reportes
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
            this.crystalReportViewer_reportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_reportes
            // 
            this.crystalReportViewer_reportes.ActiveViewIndex = -1;
            this.crystalReportViewer_reportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_reportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_reportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_reportes.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_reportes.Name = "crystalReportViewer_reportes";
            this.crystalReportViewer_reportes.ShowCloseButton = false;
            this.crystalReportViewer_reportes.ShowExportButton = false;
            this.crystalReportViewer_reportes.ShowGroupTreeButton = false;
            this.crystalReportViewer_reportes.ShowParameterPanelButton = false;
            this.crystalReportViewer_reportes.ShowRefreshButton = false;
            this.crystalReportViewer_reportes.Size = new System.Drawing.Size(984, 561);
            this.crystalReportViewer_reportes.TabIndex = 0;
            this.crystalReportViewer_reportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // F_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.crystalReportViewer_reportes);
            this.Name = "F_reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.F_reportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_reportes;
    }
}