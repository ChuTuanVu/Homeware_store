namespace GUI.uc_chinh
{
    partial class Uc_taikhoan
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
            this.btxoa = new System.Windows.Forms.Button();
            this.eptennguoidung = new System.Windows.Forms.ErrorProvider(this.components);
            this.epmk = new System.Windows.Forms.ErrorProvider(this.components);
            this.epemail = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpkngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbmk = new System.Windows.Forms.Label();
            this.lbtennguoidung = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.btmoi = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbmk = new System.Windows.Forms.TextBox();
            this.tbtennguoidung = new System.Windows.Forms.TextBox();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epsdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtbvtaikhoan = new System.Windows.Forms.DataGridView();
            this.lbtimkiem = new System.Windows.Forms.Label();
            this.pbmk = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eptennguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epmk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbvtaikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmk)).BeginInit();
            this.SuspendLayout();
            // 
            // btxoa
            // 
            this.btxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxoa.Image = global::GUI.Properties.Resources.xoa;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(488, 270);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(78, 33);
            this.btxoa.TabIndex = 25;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.Btxoa_Click);
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
            // dtpkngaysinh
            // 
            this.dtpkngaysinh.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtpkngaysinh.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpkngaysinh.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpkngaysinh.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtpkngaysinh.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtpkngaysinh.Location = new System.Drawing.Point(589, 6);
            this.dtpkngaysinh.Name = "dtpkngaysinh";
            this.dtpkngaysinh.Size = new System.Drawing.Size(240, 26);
            this.dtpkngaysinh.TabIndex = 22;
            this.dtpkngaysinh.Value = new System.DateTime(2004, 6, 2, 0, 0, 0, 0);
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbsdt.Location = new System.Drawing.Point(487, 154);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(96, 19);
            this.lbsdt.TabIndex = 30;
            this.lbsdt.Text = "Số điện thoại*";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbemail.Location = new System.Drawing.Point(487, 82);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(50, 19);
            this.lbemail.TabIndex = 29;
            this.lbemail.Text = "Email*";
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmk.Location = new System.Drawing.Point(40, 155);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(75, 19);
            this.lbmk.TabIndex = 28;
            this.lbmk.Text = "Mật khẩu*";
            // 
            // lbtennguoidung
            // 
            this.lbtennguoidung.AutoSize = true;
            this.lbtennguoidung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtennguoidung.Location = new System.Drawing.Point(40, 77);
            this.lbtennguoidung.Name = "lbtennguoidung";
            this.lbtennguoidung.Size = new System.Drawing.Size(111, 19);
            this.lbtennguoidung.TabIndex = 27;
            this.lbtennguoidung.Text = "Tên người dùng*";
            // 
            // bttim
            // 
            this.bttim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttim.Image = global::GUI.Properties.Resources.tim;
            this.bttim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttim.Location = new System.Drawing.Point(266, 0);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(99, 33);
            this.bttim.TabIndex = 17;
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
            this.btmoi.Location = new System.Drawing.Point(656, 270);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(78, 33);
            this.btmoi.TabIndex = 26;
            this.btmoi.Text = "Mới";
            this.btmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmoi.UseVisualStyleBackColor = true;
            this.btmoi.Click += new System.EventHandler(this.Btmoi_Click);
            // 
            // btsua
            // 
            this.btsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsua.Image = global::GUI.Properties.Resources.sua;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(320, 270);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(78, 33);
            this.btsua.TabIndex = 24;
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
            this.btthem.Location = new System.Drawing.Point(152, 270);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(78, 33);
            this.btthem.TabIndex = 23;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.Btthem_Click);
            // 
            // tbtim
            // 
            this.tbtim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbtim.Location = new System.Drawing.Point(122, 3);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(100, 26);
            this.tbtim.TabIndex = 16;
            this.tbtim.Enter += new System.EventHandler(this.Tbtim_Enter);
            this.tbtim.Leave += new System.EventHandler(this.Tbtim_Leave);
            // 
            // tbsdt
            // 
            this.tbsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbsdt.Location = new System.Drawing.Point(589, 150);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(110, 26);
            this.tbsdt.TabIndex = 21;
            this.tbsdt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tbsdt_KeyUp);
            this.tbsdt.Leave += new System.EventHandler(this.Tbsdt_Leave);
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbemail.Location = new System.Drawing.Point(589, 78);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(190, 26);
            this.tbemail.TabIndex = 19;
            this.tbemail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tbemail_KeyUp);
            this.tbemail.Leave += new System.EventHandler(this.Tbemail_Leave);
            // 
            // tbmk
            // 
            this.tbmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbmk.Location = new System.Drawing.Point(122, 151);
            this.tbmk.Name = "tbmk";
            this.tbmk.Size = new System.Drawing.Size(143, 26);
            this.tbmk.TabIndex = 20;
            this.tbmk.UseSystemPasswordChar = true;
            this.tbmk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tbmk_KeyUp);
            this.tbmk.Leave += new System.EventHandler(this.Tbmk_Leave);
            // 
            // tbtennguoidung
            // 
            this.tbtennguoidung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbtennguoidung.Location = new System.Drawing.Point(162, 73);
            this.tbtennguoidung.Name = "tbtennguoidung";
            this.tbtennguoidung.Size = new System.Drawing.Size(125, 26);
            this.tbtennguoidung.TabIndex = 18;
            this.tbtennguoidung.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tbtennguoidung_KeyUp);
            this.tbtennguoidung.Leave += new System.EventHandler(this.Tbtennguoidung_Leave);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ngaydangky";
            this.Column6.HeaderText = "Ngày đăng ký";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngaysinh";
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "diachi";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sdt";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "email";
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tennguoidung";
            this.Column1.HeaderText = "Tên người dùng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // epsdt
            // 
            this.epsdt.BlinkRate = 1;
            this.epsdt.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epsdt.ContainerControl = this;
            // 
            // dtbvtaikhoan
            // 
            this.dtbvtaikhoan.AllowUserToAddRows = false;
            this.dtbvtaikhoan.AllowUserToDeleteRows = false;
            this.dtbvtaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtbvtaikhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtbvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbvtaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtbvtaikhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtbvtaikhoan.Location = new System.Drawing.Point(0, 345);
            this.dtbvtaikhoan.Name = "dtbvtaikhoan";
            this.dtbvtaikhoan.ReadOnly = true;
            this.dtbvtaikhoan.Size = new System.Drawing.Size(880, 150);
            this.dtbvtaikhoan.TabIndex = 31;
            this.dtbvtaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtbvtaikhoan_CellClick);
            // 
            // lbtimkiem
            // 
            this.lbtimkiem.AutoSize = true;
            this.lbtimkiem.BackColor = System.Drawing.SystemColors.Window;
            this.lbtimkiem.Location = new System.Drawing.Point(127, 7);
            this.lbtimkiem.Name = "lbtimkiem";
            this.lbtimkiem.Size = new System.Drawing.Size(65, 19);
            this.lbtimkiem.TabIndex = 32;
            this.lbtimkiem.Text = "Tìm kiếm";
            this.lbtimkiem.Click += new System.EventHandler(this.Lbtimkiem_Click);
            // 
            // pbmk
            // 
            this.pbmk.BackColor = System.Drawing.SystemColors.Control;
            this.pbmk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbmk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbmk.Image = global::GUI.Properties.Resources.matkhauan;
            this.pbmk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbmk.Location = new System.Drawing.Point(284, 156);
            this.pbmk.Name = "pbmk";
            this.pbmk.Size = new System.Drawing.Size(16, 16);
            this.pbmk.TabIndex = 33;
            this.pbmk.TabStop = false;
            this.pbmk.Click += new System.EventHandler(this.Pbmk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(487, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ngày sinh";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdiachi.Location = new System.Drawing.Point(297, 207);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(51, 19);
            this.lbdiachi.TabIndex = 36;
            this.lbdiachi.Text = "Địa chỉ";
            // 
            // tbdiachi
            // 
            this.tbdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbdiachi.Location = new System.Drawing.Point(359, 203);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(190, 26);
            this.tbdiachi.TabIndex = 35;
            // 
            // Uc_taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.tbdiachi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbmk);
            this.Controls.Add(this.lbtimkiem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.dtpkngaysinh);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbmk);
            this.Controls.Add(this.lbtennguoidung);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.btmoi);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.tbtim);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbmk);
            this.Controls.Add(this.tbtennguoidung);
            this.Controls.Add(this.dtbvtaikhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_taikhoan";
            this.Size = new System.Drawing.Size(880, 495);
            this.Load += new System.EventHandler(this.Uc_taikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eptennguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epmk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbvtaikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.ErrorProvider eptennguoidung;
        private System.Windows.Forms.DateTimePicker dtpkngaysinh;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.Label lbtennguoidung;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbmk;
        private System.Windows.Forms.TextBox tbtennguoidung;
        private System.Windows.Forms.DataGridView dtbvtaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ErrorProvider epmk;
        private System.Windows.Forms.ErrorProvider epemail;
        private System.Windows.Forms.ErrorProvider epsdt;
        private System.Windows.Forms.Label lbtimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbmk;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.TextBox tbdiachi;
    }
}
