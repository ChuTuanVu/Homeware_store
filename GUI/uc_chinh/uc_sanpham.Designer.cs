namespace GUI.uc_chinh
{
    partial class Uc_sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_sanpham));
            this.dtgvgh = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpgh = new System.Windows.Forms.TabPage();
            this.btghmua = new System.Windows.Forms.Button();
            this.lbghcosan = new System.Windows.Forms.Label();
            this.lbghtt = new System.Windows.Forms.Label();
            this.lbghnv = new System.Windows.Forms.Label();
            this.lbghsoluong = new System.Windows.Forms.Label();
            this.tbghtt = new System.Windows.Forms.TextBox();
            this.cbbghnv = new System.Windows.Forms.ComboBox();
            this.btghxoa = new System.Windows.Forms.Button();
            this.nudsoluong = new System.Windows.Forms.NumericUpDown();
            this.cbbdanhmuc = new System.Windows.Forms.ComboBox();
            this.lbmhdanhmuc = new System.Windows.Forms.Label();
            this.lbmhgia = new System.Windows.Forms.Label();
            this.lbmhten = new System.Windows.Forms.Label();
            this.btthemanh = new System.Windows.Forms.Button();
            this.lbmhsoluong = new System.Windows.Forms.Label();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.tbsoluong = new System.Windows.Forms.TextBox();
            this.tbgia = new System.Windows.Forms.TextBox();
            this.tbten = new System.Windows.Forms.TextBox();
            this.lbanh = new System.Windows.Forms.Label();
            this.dtgvmua = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpmua = new System.Windows.Forms.TabPage();
            this.lbmhnv = new System.Windows.Forms.Label();
            this.cbbmhnv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbmhncc = new System.Windows.Forms.Label();
            this.cbbncc = new System.Windows.Forms.ComboBox();
            this.lbtimkiem = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.btmoi = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.btgiohang = new System.Windows.Forms.Button();
            this.tcsanpham = new System.Windows.Forms.TabControl();
            this.epsoluong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epgia = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvgh)).BeginInit();
            this.tpgh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvmua)).BeginInit();
            this.tpmua.SuspendLayout();
            this.tcsanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epsoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epgia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvgh
            // 
            this.dtgvgh.AllowUserToAddRows = false;
            this.dtgvgh.AllowUserToDeleteRows = false;
            this.dtgvgh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvgh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvgh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvgh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dtgvgh.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvgh.Location = new System.Drawing.Point(3, 3);
            this.dtgvgh.Name = "dtgvgh";
            this.dtgvgh.ReadOnly = true;
            this.dtgvgh.Size = new System.Drawing.Size(866, 180);
            this.dtgvgh.TabIndex = 0;
            this.dtgvgh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvgh_CellClick);
            this.dtgvgh.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvtt_CellValueChanged);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "anh";
            this.Column7.HeaderText = "Ảnh";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "masp";
            this.Column8.HeaderText = "Mã sản phẩm";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "tensp";
            this.Column9.HeaderText = "Tên sản phẩm";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "gia";
            this.Column10.HeaderText = "Giá";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "soluong";
            this.Column11.HeaderText = "Số lượng";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // tpgh
            // 
            this.tpgh.Controls.Add(this.btghmua);
            this.tpgh.Controls.Add(this.lbghcosan);
            this.tpgh.Controls.Add(this.lbghtt);
            this.tpgh.Controls.Add(this.lbghnv);
            this.tpgh.Controls.Add(this.lbghsoluong);
            this.tpgh.Controls.Add(this.tbghtt);
            this.tpgh.Controls.Add(this.cbbghnv);
            this.tpgh.Controls.Add(this.btghxoa);
            this.tpgh.Controls.Add(this.nudsoluong);
            this.tpgh.Controls.Add(this.dtgvgh);
            this.tpgh.Location = new System.Drawing.Point(4, 28);
            this.tpgh.Name = "tpgh";
            this.tpgh.Padding = new System.Windows.Forms.Padding(3);
            this.tpgh.Size = new System.Drawing.Size(872, 463);
            this.tpgh.TabIndex = 1;
            this.tpgh.Text = "Giỏ hàng";
            this.tpgh.UseVisualStyleBackColor = true;
            // 
            // btghmua
            // 
            this.btghmua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(154)))), ((int)(((byte)(240)))));
            this.btghmua.Image = ((System.Drawing.Image)(resources.GetObject("btghmua.Image")));
            this.btghmua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btghmua.Location = new System.Drawing.Point(280, 284);
            this.btghmua.Name = "btghmua";
            this.btghmua.Size = new System.Drawing.Size(83, 60);
            this.btghmua.TabIndex = 64;
            this.btghmua.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btghmua.UseVisualStyleBackColor = true;
            this.btghmua.Click += new System.EventHandler(this.Btghmua_Click);
            // 
            // lbghcosan
            // 
            this.lbghcosan.AutoSize = true;
            this.lbghcosan.Location = new System.Drawing.Point(85, 246);
            this.lbghcosan.Name = "lbghcosan";
            this.lbghcosan.Size = new System.Drawing.Size(0, 19);
            this.lbghcosan.TabIndex = 63;
            // 
            // lbghtt
            // 
            this.lbghtt.AutoSize = true;
            this.lbghtt.Location = new System.Drawing.Point(240, 195);
            this.lbghtt.Name = "lbghtt";
            this.lbghtt.Size = new System.Drawing.Size(65, 19);
            this.lbghtt.TabIndex = 61;
            this.lbghtt.Text = "Tổng tiền";
            // 
            // lbghnv
            // 
            this.lbghnv.AutoSize = true;
            this.lbghnv.Location = new System.Drawing.Point(85, 284);
            this.lbghnv.Name = "lbghnv";
            this.lbghnv.Size = new System.Drawing.Size(70, 19);
            this.lbghnv.TabIndex = 60;
            this.lbghnv.Text = "Nhân viên";
            // 
            // lbghsoluong
            // 
            this.lbghsoluong.AutoSize = true;
            this.lbghsoluong.Location = new System.Drawing.Point(85, 195);
            this.lbghsoluong.Name = "lbghsoluong";
            this.lbghsoluong.Size = new System.Drawing.Size(64, 19);
            this.lbghsoluong.TabIndex = 59;
            this.lbghsoluong.Text = "Số lượng";
            // 
            // tbghtt
            // 
            this.tbghtt.Location = new System.Drawing.Point(240, 217);
            this.tbghtt.Name = "tbghtt";
            this.tbghtt.ReadOnly = true;
            this.tbghtt.Size = new System.Drawing.Size(123, 26);
            this.tbghtt.TabIndex = 57;
            // 
            // cbbghnv
            // 
            this.cbbghnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbghnv.FormattingEnabled = true;
            this.cbbghnv.Location = new System.Drawing.Point(85, 306);
            this.cbbghnv.Name = "cbbghnv";
            this.cbbghnv.Size = new System.Drawing.Size(121, 27);
            this.cbbghnv.TabIndex = 55;
            // 
            // btghxoa
            // 
            this.btghxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btghxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btghxoa.Image = global::GUI.Properties.Resources.xoa;
            this.btghxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btghxoa.Location = new System.Drawing.Point(592, 188);
            this.btghxoa.Name = "btghxoa";
            this.btghxoa.Size = new System.Drawing.Size(78, 33);
            this.btghxoa.TabIndex = 54;
            this.btghxoa.Text = "Xóa";
            this.btghxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btghxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btghxoa.UseVisualStyleBackColor = true;
            this.btghxoa.Click += new System.EventHandler(this.Btxoagiohang_Click);
            // 
            // nudsoluong
            // 
            this.nudsoluong.Location = new System.Drawing.Point(85, 217);
            this.nudsoluong.Name = "nudsoluong";
            this.nudsoluong.ReadOnly = true;
            this.nudsoluong.Size = new System.Drawing.Size(120, 26);
            this.nudsoluong.TabIndex = 1;
            this.nudsoluong.ValueChanged += new System.EventHandler(this.Nudsoluong_ValueChanged);
            // 
            // cbbdanhmuc
            // 
            this.cbbdanhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbdanhmuc.FormattingEnabled = true;
            this.cbbdanhmuc.Location = new System.Drawing.Point(731, 72);
            this.cbbdanhmuc.Name = "cbbdanhmuc";
            this.cbbdanhmuc.Size = new System.Drawing.Size(137, 27);
            this.cbbdanhmuc.TabIndex = 45;
            // 
            // lbmhdanhmuc
            // 
            this.lbmhdanhmuc.AutoSize = true;
            this.lbmhdanhmuc.Location = new System.Drawing.Point(731, 49);
            this.lbmhdanhmuc.Name = "lbmhdanhmuc";
            this.lbmhdanhmuc.Size = new System.Drawing.Size(78, 19);
            this.lbmhdanhmuc.TabIndex = 44;
            this.lbmhdanhmuc.Text = "Danh mục*";
            // 
            // lbmhgia
            // 
            this.lbmhgia.AutoSize = true;
            this.lbmhgia.Location = new System.Drawing.Point(6, 115);
            this.lbmhgia.Name = "lbmhgia";
            this.lbmhgia.Size = new System.Drawing.Size(38, 19);
            this.lbmhgia.TabIndex = 42;
            this.lbmhgia.Text = "Giá*";
            // 
            // lbmhten
            // 
            this.lbmhten.AutoSize = true;
            this.lbmhten.Location = new System.Drawing.Point(8, 49);
            this.lbmhten.Name = "lbmhten";
            this.lbmhten.Size = new System.Drawing.Size(40, 19);
            this.lbmhten.TabIndex = 41;
            this.lbmhten.Text = "Tên*";
            // 
            // btthemanh
            // 
            this.btthemanh.Location = new System.Drawing.Point(453, 133);
            this.btthemanh.Name = "btthemanh";
            this.btthemanh.Size = new System.Drawing.Size(78, 33);
            this.btthemanh.TabIndex = 40;
            this.btthemanh.Text = "Chọn tệp";
            this.btthemanh.UseVisualStyleBackColor = true;
            this.btthemanh.Click += new System.EventHandler(this.Btthemanh_Click);
            // 
            // lbmhsoluong
            // 
            this.lbmhsoluong.AutoSize = true;
            this.lbmhsoluong.Location = new System.Drawing.Point(194, 115);
            this.lbmhsoluong.Name = "lbmhsoluong";
            this.lbmhsoluong.Size = new System.Drawing.Size(64, 19);
            this.lbmhsoluong.TabIndex = 43;
            this.lbmhsoluong.Text = "Số lượng";
            // 
            // tbtim
            // 
            this.tbtim.Location = new System.Drawing.Point(198, 9);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(156, 26);
            this.tbtim.TabIndex = 31;
            this.tbtim.Enter += new System.EventHandler(this.Tbtim_Enter);
            this.tbtim.Leave += new System.EventHandler(this.Tbtim_Leave);
            // 
            // tbsoluong
            // 
            this.tbsoluong.Location = new System.Drawing.Point(194, 137);
            this.tbsoluong.Name = "tbsoluong";
            this.tbsoluong.Size = new System.Drawing.Size(78, 26);
            this.tbsoluong.TabIndex = 30;
            this.tbsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbsoluong_KeyPress);
            // 
            // tbgia
            // 
            this.tbgia.Location = new System.Drawing.Point(8, 137);
            this.tbgia.Name = "tbgia";
            this.tbgia.Size = new System.Drawing.Size(149, 26);
            this.tbgia.TabIndex = 29;
            this.tbgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbgia_KeyPress);
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(8, 72);
            this.tbten.Multiline = true;
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(341, 26);
            this.tbten.TabIndex = 28;
            // 
            // lbanh
            // 
            this.lbanh.AutoSize = true;
            this.lbanh.Location = new System.Drawing.Point(534, 140);
            this.lbanh.Name = "lbanh";
            this.lbanh.Size = new System.Drawing.Size(168, 19);
            this.lbanh.TabIndex = 49;
            this.lbanh.Text = "Không tệp nào được chọn";
            // 
            // dtgvmua
            // 
            this.dtgvmua.AllowUserToAddRows = false;
            this.dtgvmua.AllowUserToDeleteRows = false;
            this.dtgvmua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvmua.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvmua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvmua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgvmua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvmua.Location = new System.Drawing.Point(3, 280);
            this.dtgvmua.Name = "dtgvmua";
            this.dtgvmua.ReadOnly = true;
            this.dtgvmua.Size = new System.Drawing.Size(866, 180);
            this.dtgvmua.TabIndex = 46;
            this.dtgvmua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvmua_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "anh";
            this.Column1.HeaderText = "Ảnh";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "ma";
            this.Column2.HeaderText = "Mã sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 202;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ten";
            this.Column3.HeaderText = "Tên sản phẩm";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "danhmuc";
            this.Column4.HeaderText = "Danh mục";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "soluong";
            this.Column5.HeaderText = "Số lượng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "gia";
            this.Column6.HeaderText = "Giá";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tpmua
            // 
            this.tpmua.Controls.Add(this.lbmhnv);
            this.tpmua.Controls.Add(this.cbbmhnv);
            this.tpmua.Controls.Add(this.label1);
            this.tpmua.Controls.Add(this.lbmhncc);
            this.tpmua.Controls.Add(this.cbbncc);
            this.tpmua.Controls.Add(this.lbtimkiem);
            this.tpmua.Controls.Add(this.bttim);
            this.tpmua.Controls.Add(this.btmoi);
            this.tpmua.Controls.Add(this.btxoa);
            this.tpmua.Controls.Add(this.btsua);
            this.tpmua.Controls.Add(this.btthem);
            this.tpmua.Controls.Add(this.lbanh);
            this.tpmua.Controls.Add(this.btgiohang);
            this.tpmua.Controls.Add(this.dtgvmua);
            this.tpmua.Controls.Add(this.cbbdanhmuc);
            this.tpmua.Controls.Add(this.lbmhdanhmuc);
            this.tpmua.Controls.Add(this.lbmhgia);
            this.tpmua.Controls.Add(this.lbmhten);
            this.tpmua.Controls.Add(this.btthemanh);
            this.tpmua.Controls.Add(this.lbmhsoluong);
            this.tpmua.Controls.Add(this.tbtim);
            this.tpmua.Controls.Add(this.tbsoluong);
            this.tpmua.Controls.Add(this.tbgia);
            this.tpmua.Controls.Add(this.tbten);
            this.tpmua.Location = new System.Drawing.Point(4, 28);
            this.tpmua.Name = "tpmua";
            this.tpmua.Padding = new System.Windows.Forms.Padding(3);
            this.tpmua.Size = new System.Drawing.Size(872, 463);
            this.tpmua.TabIndex = 0;
            this.tpmua.Text = "Mua hàng";
            this.tpmua.UseVisualStyleBackColor = true;
            // 
            // lbmhnv
            // 
            this.lbmhnv.AutoSize = true;
            this.lbmhnv.Location = new System.Drawing.Point(300, 115);
            this.lbmhnv.Name = "lbmhnv";
            this.lbmhnv.Size = new System.Drawing.Size(70, 19);
            this.lbmhnv.TabIndex = 62;
            this.lbmhnv.Text = "Nhân viên";
            // 
            // cbbmhnv
            // 
            this.cbbmhnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmhnv.FormattingEnabled = true;
            this.cbbmhnv.Location = new System.Drawing.Point(300, 137);
            this.cbbmhnv.Name = "cbbmhnv";
            this.cbbmhnv.Size = new System.Drawing.Size(121, 27);
            this.cbbmhnv.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(453, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "100px * 100px & 2028kb";
            // 
            // lbmhncc
            // 
            this.lbmhncc.AutoSize = true;
            this.lbmhncc.Location = new System.Drawing.Point(414, 50);
            this.lbmhncc.Name = "lbmhncc";
            this.lbmhncc.Size = new System.Drawing.Size(93, 19);
            this.lbmhncc.TabIndex = 58;
            this.lbmhncc.Text = "Nhà cung cấp";
            // 
            // cbbncc
            // 
            this.cbbncc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbncc.FormattingEnabled = true;
            this.cbbncc.Location = new System.Drawing.Point(418, 72);
            this.cbbncc.Name = "cbbncc";
            this.cbbncc.Size = new System.Drawing.Size(214, 27);
            this.cbbncc.TabIndex = 57;
            // 
            // lbtimkiem
            // 
            this.lbtimkiem.AutoSize = true;
            this.lbtimkiem.BackColor = System.Drawing.SystemColors.Window;
            this.lbtimkiem.Location = new System.Drawing.Point(203, 12);
            this.lbtimkiem.Name = "lbtimkiem";
            this.lbtimkiem.Size = new System.Drawing.Size(65, 19);
            this.lbtimkiem.TabIndex = 56;
            this.lbtimkiem.Text = "Tìm kiếm";
            this.lbtimkiem.Click += new System.EventHandler(this.Lbtimkiem_Click);
            // 
            // bttim
            // 
            this.bttim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttim.Image = global::GUI.Properties.Resources.tim;
            this.bttim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttim.Location = new System.Drawing.Point(375, 9);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(99, 33);
            this.bttim.TabIndex = 50;
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
            this.btmoi.Location = new System.Drawing.Point(623, 236);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(78, 33);
            this.btmoi.TabIndex = 54;
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
            this.btxoa.Location = new System.Drawing.Point(485, 236);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(78, 33);
            this.btxoa.TabIndex = 53;
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
            this.btsua.Location = new System.Drawing.Point(317, 236);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(78, 33);
            this.btsua.TabIndex = 52;
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
            this.btthem.Location = new System.Drawing.Point(149, 236);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(78, 33);
            this.btthem.TabIndex = 51;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.Btthem_Click);
            // 
            // btgiohang
            // 
            this.btgiohang.Image = global::GUI.Properties.Resources.giohang;
            this.btgiohang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btgiohang.Location = new System.Drawing.Point(735, 127);
            this.btgiohang.Name = "btgiohang";
            this.btgiohang.Size = new System.Drawing.Size(95, 44);
            this.btgiohang.TabIndex = 48;
            this.btgiohang.Text = "Giỏ hàng";
            this.btgiohang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btgiohang.UseVisualStyleBackColor = true;
            this.btgiohang.Click += new System.EventHandler(this.Btgiohang_Click);
            // 
            // tcsanpham
            // 
            this.tcsanpham.Controls.Add(this.tpmua);
            this.tcsanpham.Controls.Add(this.tpgh);
            this.tcsanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcsanpham.Location = new System.Drawing.Point(0, 0);
            this.tcsanpham.Name = "tcsanpham";
            this.tcsanpham.SelectedIndex = 0;
            this.tcsanpham.Size = new System.Drawing.Size(880, 495);
            this.tcsanpham.TabIndex = 1;
            this.tcsanpham.Click += new System.EventHandler(this.Tcsanpham_Click);
            // 
            // epsoluong
            // 
            this.epsoluong.BlinkRate = 1;
            this.epsoluong.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epsoluong.ContainerControl = this;
            // 
            // epgia
            // 
            this.epgia.BlinkRate = 1;
            this.epgia.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epgia.ContainerControl = this;
            // 
            // Uc_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcsanpham);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_sanpham";
            this.Size = new System.Drawing.Size(880, 495);
            this.Load += new System.EventHandler(this.Uc_sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvgh)).EndInit();
            this.tpgh.ResumeLayout(false);
            this.tpgh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvmua)).EndInit();
            this.tpmua.ResumeLayout(false);
            this.tpmua.PerformLayout();
            this.tcsanpham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epsoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvgh;
        private System.Windows.Forms.TabPage tpgh;
        private System.Windows.Forms.NumericUpDown nudsoluong;
        private System.Windows.Forms.ComboBox cbbdanhmuc;
        private System.Windows.Forms.Label lbmhdanhmuc;
        private System.Windows.Forms.Label lbmhgia;
        private System.Windows.Forms.Label lbmhten;
        private System.Windows.Forms.Button btthemanh;
        private System.Windows.Forms.Label lbmhsoluong;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.TextBox tbsoluong;
        private System.Windows.Forms.TextBox tbgia;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label lbanh;
        private System.Windows.Forms.Button btgiohang;
        private System.Windows.Forms.DataGridView dtgvmua;
        private System.Windows.Forms.TabPage tpmua;
        private System.Windows.Forms.TabControl tcsanpham;
        private System.Windows.Forms.Button btghxoa;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label lbtimkiem;
        private System.Windows.Forms.TextBox tbghtt;
        private System.Windows.Forms.ComboBox cbbghnv;
        private System.Windows.Forms.ErrorProvider epsoluong;
        private System.Windows.Forms.Label lbghnv;
        private System.Windows.Forms.Label lbghsoluong;
        private System.Windows.Forms.Label lbghtt;
        private System.Windows.Forms.Button btghmua;
        private System.Windows.Forms.Label lbghcosan;
        private System.Windows.Forms.Label lbmhncc;
        private System.Windows.Forms.ComboBox cbbncc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbmhnv;
        private System.Windows.Forms.ComboBox cbbmhnv;
        private System.Windows.Forms.ErrorProvider epgia;
    }
}
