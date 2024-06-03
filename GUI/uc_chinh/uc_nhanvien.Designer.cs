namespace GUI.uc_chinh
{
    partial class Uc_nhanvien
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
            this.components = new System.ComponentModel.Container();
            this.lbtennguoidung = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.bttim = new System.Windows.Forms.Button();
            this.btmoi = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.dtgvnhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.tbtennguoidung = new System.Windows.Forms.TextBox();
            this.tbtennv = new System.Windows.Forms.TextBox();
            this.lbtimkiem = new System.Windows.Forms.Label();
            this.eptennguoidung = new System.Windows.Forms.ErrorProvider(this.components);
            this.epmk = new System.Windows.Forms.ErrorProvider(this.components);
            this.epemail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epsdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.eptennv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eptennguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epmk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eptennv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtennguoidung
            // 
            this.lbtennguoidung.AutoSize = true;
            this.lbtennguoidung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtennguoidung.Location = new System.Drawing.Point(4, 156);
            this.lbtennguoidung.Name = "lbtennguoidung";
            this.lbtennguoidung.Size = new System.Drawing.Size(111, 19);
            this.lbtennguoidung.TabIndex = 7;
            this.lbtennguoidung.Text = "Tên người dùng*";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdiachi.Location = new System.Drawing.Point(529, 156);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(51, 19);
            this.lbdiachi.TabIndex = 11;
            this.lbdiachi.Text = "Địa chỉ";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbten.Location = new System.Drawing.Point(4, 64);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(100, 19);
            this.lbten.TabIndex = 3;
            this.lbten.Text = "Tên nhân viên*";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbsdt.Location = new System.Drawing.Point(266, 156);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(96, 19);
            this.lbsdt.TabIndex = 9;
            this.lbsdt.Text = "Số điện thoại*";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbemail.Location = new System.Drawing.Point(266, 64);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(50, 19);
            this.lbemail.TabIndex = 5;
            this.lbemail.Text = "Email*";
            // 
            // tbtim
            // 
            this.tbtim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbtim.Location = new System.Drawing.Point(292, 6);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(184, 26);
            this.tbtim.TabIndex = 0;
            this.tbtim.Enter += new System.EventHandler(this.Tbtim_Enter);
            this.tbtim.Leave += new System.EventHandler(this.Tbtim_Leave);
            // 
            // tbsdt
            // 
            this.tbsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbsdt.Location = new System.Drawing.Point(389, 152);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(110, 26);
            this.tbsdt.TabIndex = 10;
            this.tbsdt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tbsdt_KeyUp);
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbemail.Location = new System.Drawing.Point(389, 60);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(190, 26);
            this.tbemail.TabIndex = 6;
            this.tbemail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tbemail_KeyUp);
            // 
            // bttim
            // 
            this.bttim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttim.Image = global::GUI.Properties.Resources.tim;
            this.bttim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttim.Location = new System.Drawing.Point(492, 3);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(99, 33);
            this.bttim.TabIndex = 2;
            this.bttim.Text = "Tìm kiếm";
            this.bttim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.Bttim_Click);
            // 
            // btmoi
            // 
            this.btmoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btmoi.Image = global::GUI.Properties.Resources.moi;
            this.btmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmoi.Location = new System.Drawing.Point(638, 258);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(78, 33);
            this.btmoi.TabIndex = 16;
            this.btmoi.Text = "Mới";
            this.btmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmoi.UseVisualStyleBackColor = true;
            this.btmoi.Click += new System.EventHandler(this.Btmoi_Click);
            // 
            // btxoa
            // 
            this.btxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxoa.Image = global::GUI.Properties.Resources.xoa;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(467, 258);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(78, 33);
            this.btxoa.TabIndex = 15;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.Btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsua.Image = global::GUI.Properties.Resources.sua;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(311, 258);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(78, 33);
            this.btsua.TabIndex = 14;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.Btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthem.Image = global::GUI.Properties.Resources.them;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(133, 258);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(78, 33);
            this.btthem.TabIndex = 13;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.Btthem_Click);
            // 
            // dtgvnhanvien
            // 
            this.dtgvnhanvien.AllowUserToAddRows = false;
            this.dtgvnhanvien.AllowUserToDeleteRows = false;
            this.dtgvnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3});
            this.dtgvnhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvnhanvien.Location = new System.Drawing.Point(0, 345);
            this.dtgvnhanvien.Name = "dtgvnhanvien";
            this.dtgvnhanvien.ReadOnly = true;
            this.dtgvnhanvien.Size = new System.Drawing.Size(880, 150);
            this.dtgvnhanvien.TabIndex = 17;
            this.dtgvnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvnhanvien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sdt";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "email";
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "diachi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbdiachi.Location = new System.Drawing.Point(585, 152);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(267, 26);
            this.tbdiachi.TabIndex = 12;
            // 
            // tbtennguoidung
            // 
            this.tbtennguoidung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbtennguoidung.Location = new System.Drawing.Point(123, 152);
            this.tbtennguoidung.Name = "tbtennguoidung";
            this.tbtennguoidung.Size = new System.Drawing.Size(100, 26);
            this.tbtennguoidung.TabIndex = 8;
            this.tbtennguoidung.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tbtennguoidung_KeyUp);
            // 
            // tbtennv
            // 
            this.tbtennv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbtennv.Location = new System.Drawing.Point(123, 60);
            this.tbtennv.Name = "tbtennv";
            this.tbtennv.Size = new System.Drawing.Size(100, 26);
            this.tbtennv.TabIndex = 4;
            this.tbtennv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tbtennv_KeyUp);
            // 
            // lbtimkiem
            // 
            this.lbtimkiem.AutoSize = true;
            this.lbtimkiem.BackColor = System.Drawing.SystemColors.Window;
            this.lbtimkiem.Location = new System.Drawing.Point(296, 10);
            this.lbtimkiem.Name = "lbtimkiem";
            this.lbtimkiem.Size = new System.Drawing.Size(65, 19);
            this.lbtimkiem.TabIndex = 1;
            this.lbtimkiem.Text = "Tìm kiếm";
            this.lbtimkiem.Click += new System.EventHandler(this.Lbtimkiem_Click);
            // 
            // eptennguoidung
            // 
            this.eptennguoidung.BlinkRate = 1;
            this.eptennguoidung.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.eptennguoidung.ContainerControl = this;
            // 
            // epmk
            // 
            this.epmk.BlinkRate = 1;
            this.epmk.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epmk.ContainerControl = this;
            // 
            // epemail
            // 
            this.epemail.BlinkRate = 1;
            this.epemail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epemail.ContainerControl = this;
            // 
            // epsdt
            // 
            this.epsdt.BlinkRate = 1;
            this.epsdt.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epsdt.ContainerControl = this;
            // 
            // eptennv
            // 
            this.eptennv.BlinkRate = 1;
            this.eptennv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.eptennv.ContainerControl = this;
            // 
            // Uc_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbtimkiem);
            this.Controls.Add(this.lbtennguoidung);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.tbtim);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.btmoi);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dtgvnhanvien);
            this.Controls.Add(this.tbdiachi);
            this.Controls.Add(this.tbtennguoidung);
            this.Controls.Add(this.tbtennv);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_nhanvien";
            this.Size = new System.Drawing.Size(880, 495);
            this.Load += new System.EventHandler(this.Uc_nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eptennguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epmk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eptennv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbtennguoidung;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.DataGridView dtgvnhanvien;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.TextBox tbtennguoidung;
        private System.Windows.Forms.TextBox tbtennv;
        private System.Windows.Forms.Label lbtimkiem;
        private System.Windows.Forms.ErrorProvider eptennguoidung;
        private System.Windows.Forms.ErrorProvider epmk;
        private System.Windows.Forms.ErrorProvider epemail;
        private System.Windows.Forms.ErrorProvider epsdt;
        private System.Windows.Forms.ErrorProvider eptennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
