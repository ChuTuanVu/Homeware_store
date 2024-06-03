namespace GUI.uc_chinh
{
    partial class uc_hoadonnhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvhoadonnhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.hoadonnhap1 = new GUI.Report.hoadonnhap();
            this.SuspendLayout();
            // 
            // crvhoadonnhap
            // 
            this.crvhoadonnhap.ActiveViewIndex = -1;
            this.crvhoadonnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvhoadonnhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvhoadonnhap.DisplayStatusBar = false;
            this.crvhoadonnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvhoadonnhap.Location = new System.Drawing.Point(0, 0);
            this.crvhoadonnhap.Name = "crvhoadonnhap";
            this.crvhoadonnhap.ReportSource = this.hoadonnhap1;
            this.crvhoadonnhap.Size = new System.Drawing.Size(880, 495);
            this.crvhoadonnhap.TabIndex = 0;
            this.crvhoadonnhap.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // uc_hoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crvhoadonnhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_hoadonnhap";
            this.Size = new System.Drawing.Size(880, 495);
            this.Load += new System.EventHandler(this.Uc_hoadonnhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvhoadonnhap;
        private Report.hoadonnhap hoadonnhap1;
    }
}
