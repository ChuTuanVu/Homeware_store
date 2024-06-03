namespace GUI.uc_chinh
{
    partial class Uc_nhacungcap
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
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.btmoi = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.dtgvnhacc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbtimkiem = new System.Windows.Forms.Label();
            this.tbten = new System.Windows.Forms.TextBox();
            this.epemail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epsdt = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhacc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).BeginInit();
            this.SuspendLayout();
            // 
            // btxoa
            // 
            this.btxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxoa.Image = global::GUI.Properties.Resources.xoa;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(498, 265);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(78, 33);
            this.btxoa.TabIndex = 40;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.Btxoa_Click);
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbsdt.Location = new System.Drawing.Point(534, 84);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(88, 19);
            this.lbsdt.TabIndex = 45;
            this.lbsdt.Text = "Số điện thoại";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbemail.Location = new System.Drawing.Point(534, 207);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(42, 19);
            this.lbemail.TabIndex = 44;
            this.lbemail.Text = "Email";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdiachi.Location = new System.Drawing.Point(59, 207);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(51, 19);
            this.lbdiachi.TabIndex = 43;
            this.lbdiachi.Text = "Địa chỉ";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbten.Location = new System.Drawing.Point(59, 84);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(123, 19);
            this.lbten.TabIndex = 42;
            this.lbten.Text = "Tên nhà cung cấp*";
            // 
            // bttim
            // 
            this.bttim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttim.Image = global::GUI.Properties.Resources.tim;
            this.bttim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttim.Location = new System.Drawing.Point(494, 13);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(99, 33);
            this.bttim.TabIndex = 32;
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
            this.btmoi.Location = new System.Drawing.Point(695, 265);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(78, 33);
            this.btmoi.TabIndex = 41;
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
            this.btsua.Location = new System.Drawing.Point(301, 265);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(78, 33);
            this.btsua.TabIndex = 39;
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
            this.btthem.Location = new System.Drawing.Point(104, 265);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(78, 33);
            this.btthem.TabIndex = 38;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.Btthem_Click);
            // 
            // tbtim
            // 
            this.tbtim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbtim.Location = new System.Drawing.Point(288, 13);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(165, 26);
            this.tbtim.TabIndex = 31;
            this.tbtim.Enter += new System.EventHandler(this.Tbtim_Enter);
            this.tbtim.Leave += new System.EventHandler(this.Tbtim_Leave);
            // 
            // tbsdt
            // 
            this.tbsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbsdt.Location = new System.Drawing.Point(628, 80);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(185, 26);
            this.tbsdt.TabIndex = 36;
            this.tbsdt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tbsdt_KeyUp);
            this.tbsdt.Leave += new System.EventHandler(this.Tbsdt_Leave);
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbemail.Location = new System.Drawing.Point(628, 203);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(185, 26);
            this.tbemail.TabIndex = 34;
            this.tbemail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tbemail_KeyUp);
            this.tbemail.Leave += new System.EventHandler(this.Tbemail_Leave);
            // 
            // tbdiachi
            // 
            this.tbdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbdiachi.Location = new System.Drawing.Point(178, 203);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(275, 26);
            this.tbdiachi.TabIndex = 35;
            // 
            // dtgvnhacc
            // 
            this.dtgvnhacc.AllowUserToAddRows = false;
            this.dtgvnhacc.AllowUserToDeleteRows = false;
            this.dtgvnhacc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvnhacc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvnhacc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgvnhacc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvnhacc.Location = new System.Drawing.Point(0, 345);
            this.dtgvnhacc.Name = "dtgvnhacc";
            this.dtgvnhacc.ReadOnly = true;
            this.dtgvnhacc.Size = new System.Drawing.Size(880, 150);
            this.dtgvnhacc.TabIndex = 46;
            this.dtgvnhacc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvnhacc_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma";
            this.Column1.HeaderText = "Mã nhà cung cấp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten";
            this.Column2.HeaderText = "Tên nhà cung cấp";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "diachi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            // lbtimkiem
            // 
            this.lbtimkiem.AutoSize = true;
            this.lbtimkiem.BackColor = System.Drawing.SystemColors.Window;
            this.lbtimkiem.Location = new System.Drawing.Point(289, 16);
            this.lbtimkiem.Name = "lbtimkiem";
            this.lbtimkiem.Size = new System.Drawing.Size(65, 19);
            this.lbtimkiem.TabIndex = 49;
            this.lbtimkiem.Text = "Tìm kiếm";
            this.lbtimkiem.Click += new System.EventHandler(this.Lbtimkiem_Click);
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(178, 80);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(275, 26);
            this.tbten.TabIndex = 50;
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
            // Uc_nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbten);
            this.Controls.Add(this.lbtimkiem);
            this.Controls.Add(this.dtgvnhacc);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.btmoi);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.tbtim);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbdiachi);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_nhacungcap";
            this.Size = new System.Drawing.Size(880, 495);
            this.Load += new System.EventHandler(this.Uc_nhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhacc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.DataGridView dtgvnhacc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lbtimkiem;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.ErrorProvider epemail;
        private System.Windows.Forms.ErrorProvider epsdt;
    }
}
