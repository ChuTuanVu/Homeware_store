namespace GUI.uc_chinh
{
    partial class uc_hoadonnguoidung
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
            this.crvhoadonnguoidung = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvhoadonnguoidung
            // 
            this.crvhoadonnguoidung.ActiveViewIndex = -1;
            this.crvhoadonnguoidung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvhoadonnguoidung.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvhoadonnguoidung.DisplayStatusBar = false;
            this.crvhoadonnguoidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvhoadonnguoidung.Location = new System.Drawing.Point(0, 0);
            this.crvhoadonnguoidung.Name = "crvhoadonnguoidung";
            this.crvhoadonnguoidung.Size = new System.Drawing.Size(880, 495);
            this.crvhoadonnguoidung.TabIndex = 0;
            this.crvhoadonnguoidung.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // uc_hoadonnguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crvhoadonnguoidung);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_hoadonnguoidung";
            this.Size = new System.Drawing.Size(880, 495);
            this.Load += new System.EventHandler(this.Uc_hoadonnguoidung_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvhoadonnguoidung;
    }
}
