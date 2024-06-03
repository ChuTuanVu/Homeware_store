namespace GUI.uc_chinh
{
    partial class Uc_hoadonxuat
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
            this.crvhoadonxuat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.hoadonxuat1 = new GUI.Report.hoadonxuat();
            this.SuspendLayout();
            // 
            // crvhoadonxuat
            // 
            this.crvhoadonxuat.ActiveViewIndex = -1;
            this.crvhoadonxuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvhoadonxuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvhoadonxuat.DisplayStatusBar = false;
            this.crvhoadonxuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvhoadonxuat.Location = new System.Drawing.Point(0, 0);
            this.crvhoadonxuat.Name = "crvhoadonxuat";
            this.crvhoadonxuat.ReportSource = this.hoadonxuat1;
            this.crvhoadonxuat.Size = new System.Drawing.Size(880, 495);
            this.crvhoadonxuat.TabIndex = 0;
            this.crvhoadonxuat.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Uc_hoadonxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crvhoadonxuat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_hoadonxuat";
            this.Size = new System.Drawing.Size(880, 495);
            this.Load += new System.EventHandler(this.Uc_hoadonxuat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvhoadonxuat;
        private Report.hoadonxuat hoadonxuat1;
    }
}