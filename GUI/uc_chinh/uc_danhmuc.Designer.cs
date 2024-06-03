namespace GUI.ucchinh
{
    partial class Uc_danhmuc
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
            this.dtgvdanhmuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.btmoi = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.tbten = new System.Windows.Forms.TextBox();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.lbtimkiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdanhmuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvdanhmuc
            // 
            this.dtgvdanhmuc.AllowUserToAddRows = false;
            this.dtgvdanhmuc.AllowUserToDeleteRows = false;
            this.dtgvdanhmuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvdanhmuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvdanhmuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvdanhmuc.Location = new System.Drawing.Point(0, 322);
            this.dtgvdanhmuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvdanhmuc.Name = "dtgvdanhmuc";
            this.dtgvdanhmuc.ReadOnly = true;
            this.dtgvdanhmuc.Size = new System.Drawing.Size(880, 173);
            this.dtgvdanhmuc.TabIndex = 41;
            this.dtgvdanhmuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvdanhmuc_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma";
            this.Column1.HeaderText = "Mã danh mục";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten";
            this.Column2.HeaderText = "Tên danh mục";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soluong";
            this.Column3.HeaderText = "Số sản phẩm hiện có";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tên danh mục*";
            // 
            // bttim
            // 
            this.bttim.Image = global::GUI.Properties.Resources.tim;
            this.bttim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttim.Location = new System.Drawing.Point(499, 26);
            this.bttim.Margin = new System.Windows.Forms.Padding(4);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(77, 34);
            this.bttim.TabIndex = 46;
            this.bttim.Text = "Tìm";
            this.bttim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.Bttim_Click);
            // 
            // btmoi
            // 
            this.btmoi.Image = global::GUI.Properties.Resources.moi;
            this.btmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmoi.Location = new System.Drawing.Point(713, 220);
            this.btmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(77, 34);
            this.btmoi.TabIndex = 45;
            this.btmoi.Text = "Mới";
            this.btmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmoi.UseVisualStyleBackColor = true;
            this.btmoi.Click += new System.EventHandler(this.Btmoi_Click);
            // 
            // btxoa
            // 
            this.btxoa.Image = global::GUI.Properties.Resources.xoa;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(497, 220);
            this.btxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(77, 34);
            this.btxoa.TabIndex = 44;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.Btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Image = global::GUI.Properties.Resources.sua;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(281, 220);
            this.btsua.Margin = new System.Windows.Forms.Padding(4);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(77, 34);
            this.btsua.TabIndex = 43;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.Btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Image = global::GUI.Properties.Resources.them;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(65, 220);
            this.btthem.Margin = new System.Windows.Forms.Padding(4);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(77, 34);
            this.btthem.TabIndex = 42;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.Btthem_Click);
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(223, 97);
            this.tbten.Margin = new System.Windows.Forms.Padding(4);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(163, 26);
            this.tbten.TabIndex = 40;
            // 
            // tbtim
            // 
            this.tbtim.Location = new System.Drawing.Point(267, 30);
            this.tbtim.Margin = new System.Windows.Forms.Padding(4);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(148, 26);
            this.tbtim.TabIndex = 39;
            this.tbtim.Enter += new System.EventHandler(this.Tbtim_Enter);
            this.tbtim.Leave += new System.EventHandler(this.Tbtim_Leave);
            // 
            // lbtimkiem
            // 
            this.lbtimkiem.AutoSize = true;
            this.lbtimkiem.BackColor = System.Drawing.SystemColors.Window;
            this.lbtimkiem.Location = new System.Drawing.Point(268, 34);
            this.lbtimkiem.Name = "lbtimkiem";
            this.lbtimkiem.Size = new System.Drawing.Size(65, 19);
            this.lbtimkiem.TabIndex = 49;
            this.lbtimkiem.Text = "Tìm kiếm";
            this.lbtimkiem.Click += new System.EventHandler(this.Lbtimkiem_Click);
            // 
            // Uc_danhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbtimkiem);
            this.Controls.Add(this.dtgvdanhmuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.btmoi);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.tbten);
            this.Controls.Add(this.tbtim);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_danhmuc";
            this.Size = new System.Drawing.Size(880, 495);
            this.Load += new System.EventHandler(this.Uc_danhmuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdanhmuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvdanhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.Label lbtimkiem;
    }
}
