namespace GUI.uckhongthedangnhap
{
    partial class Uc_tennguoidung
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
            this.epsdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.tman = new System.Windows.Forms.Timer(this.components);
            this.lbsdt1 = new System.Windows.Forms.Label();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbemail1 = new System.Windows.Forms.Label();
            this.llbquenmk = new System.Windows.Forms.LinkLabel();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbtieude2 = new System.Windows.Forms.Label();
            this.lbsaochep = new System.Windows.Forms.Label();
            this.gbketqua = new System.Windows.Forms.GroupBox();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.pbsaochep = new System.Windows.Forms.PictureBox();
            this.lbtieude4 = new System.Windows.Forms.Label();
            this.lbtimthay = new System.Windows.Forms.Label();
            this.lbkotimthay = new System.Windows.Forms.Label();
            this.tbkq = new System.Windows.Forms.TextBox();
            this.lbtieude1 = new System.Windows.Forms.Label();
            this.epemail = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbchucnang = new System.Windows.Forms.GroupBox();
            this.bttt = new System.Windows.Forms.Button();
            this.lbtieude3 = new System.Windows.Forms.Label();
            this.pbdangnhap = new System.Windows.Forms.PictureBox();
            this.pbquaylai = new System.Windows.Forms.PictureBox();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).BeginInit();
            this.gbketqua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsaochep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).BeginInit();
            this.gbchucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbdangnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbquaylai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // epsdt
            // 
            this.epsdt.BlinkRate = 1;
            this.epsdt.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epsdt.ContainerControl = this;
            // 
            // tman
            // 
            this.tman.Interval = 2000;
            this.tman.Tick += new System.EventHandler(this.Tman_Tick);
            // 
            // lbsdt1
            // 
            this.lbsdt1.AutoSize = true;
            this.lbsdt1.BackColor = System.Drawing.SystemColors.Window;
            this.lbsdt1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbsdt1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbsdt1.Location = new System.Drawing.Point(19, 268);
            this.lbsdt1.Name = "lbsdt1";
            this.lbsdt1.Size = new System.Drawing.Size(88, 19);
            this.lbsdt1.TabIndex = 7;
            this.lbsdt1.Text = "Số điện thoại\r\n";
            this.lbsdt1.Click += new System.EventHandler(this.Lbsdt1_Click);
            // 
            // tbsdt
            // 
            this.tbsdt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbsdt.Location = new System.Drawing.Point(18, 265);
            this.tbsdt.Margin = new System.Windows.Forms.Padding(4);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(212, 26);
            this.tbsdt.TabIndex = 6;
            this.tbsdt.TextChanged += new System.EventHandler(this.Tbsdt_TextChanged);
            this.tbsdt.Enter += new System.EventHandler(this.Tbsdt_Enter);
            this.tbsdt.Leave += new System.EventHandler(this.Tbsdt_Leave);
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.BackColor = System.Drawing.Color.Transparent;
            this.lbsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbsdt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbsdt.Location = new System.Drawing.Point(18, 244);
            this.lbsdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(88, 19);
            this.lbsdt.TabIndex = 5;
            this.lbsdt.Text = "Số điện thoại";
            this.lbsdt.Visible = false;
            // 
            // lbemail1
            // 
            this.lbemail1.AutoSize = true;
            this.lbemail1.BackColor = System.Drawing.SystemColors.Window;
            this.lbemail1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbemail1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbemail1.Location = new System.Drawing.Point(19, 199);
            this.lbemail1.Name = "lbemail1";
            this.lbemail1.Size = new System.Drawing.Size(42, 19);
            this.lbemail1.TabIndex = 4;
            this.lbemail1.Text = "Email";
            this.lbemail1.Click += new System.EventHandler(this.Lbemail1_Click);
            // 
            // llbquenmk
            // 
            this.llbquenmk.AutoSize = true;
            this.llbquenmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbquenmk.Location = new System.Drawing.Point(56, 449);
            this.llbquenmk.Name = "llbquenmk";
            this.llbquenmk.Size = new System.Drawing.Size(147, 19);
            this.llbquenmk.TabIndex = 9;
            this.llbquenmk.TabStop = true;
            this.llbquenmk.Text = "QUÊN MẬT KHẨU?";
            this.llbquenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llbquenmk_LinkClicked);
            // 
            // tbemail
            // 
            this.tbemail.BackColor = System.Drawing.SystemColors.Window;
            this.tbemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbemail.Location = new System.Drawing.Point(18, 196);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(212, 26);
            this.tbemail.TabIndex = 3;
            this.tbemail.Enter += new System.EventHandler(this.Tbemail_Enter);
            this.tbemail.Leave += new System.EventHandler(this.Tbemail_Leave);
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.BackColor = System.Drawing.Color.Transparent;
            this.lbemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbemail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbemail.Location = new System.Drawing.Point(18, 174);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(42, 19);
            this.lbemail.TabIndex = 2;
            this.lbemail.Text = "Email";
            this.lbemail.Visible = false;
            // 
            // lbtieude2
            // 
            this.lbtieude2.AutoSize = true;
            this.lbtieude2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtieude2.Location = new System.Drawing.Point(31, 72);
            this.lbtieude2.Name = "lbtieude2";
            this.lbtieude2.Size = new System.Drawing.Size(196, 76);
            this.lbtieude2.TabIndex = 1;
            this.lbtieude2.Text = "Để khôi phục tên người dùng,\r\nhãy sử dụng địa chỉ email và số\r\nđiện thoại được kế" +
    "t nối với tài \r\nkhoản của bạn.";
            // 
            // lbsaochep
            // 
            this.lbsaochep.AutoSize = true;
            this.lbsaochep.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbsaochep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbsaochep.Location = new System.Drawing.Point(248, 185);
            this.lbsaochep.Name = "lbsaochep";
            this.lbsaochep.Size = new System.Drawing.Size(124, 15);
            this.lbsaochep.TabIndex = 9;
            this.lbsaochep.Text = "Sao chép thành công!";
            this.lbsaochep.Visible = false;
            // 
            // gbketqua
            // 
            this.gbketqua.Controls.Add(this.btdangnhap);
            this.gbketqua.Controls.Add(this.lbsaochep);
            this.gbketqua.Controls.Add(this.pbsaochep);
            this.gbketqua.Controls.Add(this.lbtieude4);
            this.gbketqua.Controls.Add(this.lbtimthay);
            this.gbketqua.Controls.Add(this.lbkotimthay);
            this.gbketqua.Controls.Add(this.tbkq);
            this.gbketqua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbketqua.Location = new System.Drawing.Point(258, 130);
            this.gbketqua.Name = "gbketqua";
            this.gbketqua.Size = new System.Drawing.Size(622, 365);
            this.gbketqua.TabIndex = 2;
            this.gbketqua.TabStop = false;
            // 
            // btdangnhap
            // 
            this.btdangnhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btdangnhap.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btdangnhap.FlatAppearance.BorderSize = 0;
            this.btdangnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btdangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btdangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdangnhap.Image = global::GUI.Properties.Resources.dangnhap;
            this.btdangnhap.Location = new System.Drawing.Point(288, 245);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(45, 45);
            this.btdangnhap.TabIndex = 10;
            this.btdangnhap.UseVisualStyleBackColor = false;
            this.btdangnhap.Visible = false;
            this.btdangnhap.Click += new System.EventHandler(this.Btdangnhap_Click);
            // 
            // pbsaochep
            // 
            this.pbsaochep.Image = global::GUI.Properties.Resources.saochep;
            this.pbsaochep.Location = new System.Drawing.Point(406, 155);
            this.pbsaochep.Name = "pbsaochep";
            this.pbsaochep.Size = new System.Drawing.Size(26, 26);
            this.pbsaochep.TabIndex = 8;
            this.pbsaochep.TabStop = false;
            this.tt.SetToolTip(this.pbsaochep, "Sao chép tên người dùng");
            this.pbsaochep.Visible = false;
            this.pbsaochep.Click += new System.EventHandler(this.Pbsaochep_Click);
            // 
            // lbtieude4
            // 
            this.lbtieude4.AutoSize = true;
            this.lbtieude4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtieude4.Location = new System.Drawing.Point(213, 30);
            this.lbtieude4.Name = "lbtieude4";
            this.lbtieude4.Size = new System.Drawing.Size(194, 23);
            this.lbtieude4.TabIndex = 0;
            this.lbtieude4.Text = "Hỗ trợ tên người dùng";
            // 
            // lbtimthay
            // 
            this.lbtimthay.AutoSize = true;
            this.lbtimthay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtimthay.Location = new System.Drawing.Point(72, 82);
            this.lbtimthay.Name = "lbtimthay";
            this.lbtimthay.Size = new System.Drawing.Size(0, 21);
            this.lbtimthay.TabIndex = 2;
            this.lbtimthay.Visible = false;
            // 
            // lbkotimthay
            // 
            this.lbkotimthay.AutoSize = true;
            this.lbkotimthay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbkotimthay.Location = new System.Drawing.Point(72, 82);
            this.lbkotimthay.Name = "lbkotimthay";
            this.lbkotimthay.Size = new System.Drawing.Size(477, 38);
            this.lbkotimthay.TabIndex = 1;
            this.lbkotimthay.Text = "Không tìm thấy tên người dùng nào liên kết với email và số điện thoại của bạn.\r\nN" +
    "ếu bạn cho rằng đây là nhầm lẫn, xin vui lòng liên hệ với người quản trị.";
            this.lbkotimthay.Visible = false;
            // 
            // tbkq
            // 
            this.tbkq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbkq.Location = new System.Drawing.Point(221, 155);
            this.tbkq.Name = "tbkq";
            this.tbkq.Size = new System.Drawing.Size(179, 26);
            this.tbkq.TabIndex = 0;
            this.tbkq.Visible = false;
            // 
            // lbtieude1
            // 
            this.lbtieude1.AutoSize = true;
            this.lbtieude1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtieude1.Location = new System.Drawing.Point(42, 16);
            this.lbtieude1.Name = "lbtieude1";
            this.lbtieude1.Size = new System.Drawing.Size(175, 48);
            this.lbtieude1.TabIndex = 0;
            this.lbtieude1.Text = "Nhập địa chỉ email\r\nvà số điện thoại";
            // 
            // epemail
            // 
            this.epemail.BlinkRate = 1;
            this.epemail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epemail.ContainerControl = this;
            // 
            // gbchucnang
            // 
            this.gbchucnang.Controls.Add(this.lbsdt1);
            this.gbchucnang.Controls.Add(this.tbsdt);
            this.gbchucnang.Controls.Add(this.lbsdt);
            this.gbchucnang.Controls.Add(this.bttt);
            this.gbchucnang.Controls.Add(this.lbemail1);
            this.gbchucnang.Controls.Add(this.llbquenmk);
            this.gbchucnang.Controls.Add(this.tbemail);
            this.gbchucnang.Controls.Add(this.lbemail);
            this.gbchucnang.Controls.Add(this.lbtieude2);
            this.gbchucnang.Controls.Add(this.lbtieude1);
            this.gbchucnang.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbchucnang.Location = new System.Drawing.Point(0, 0);
            this.gbchucnang.Name = "gbchucnang";
            this.gbchucnang.Size = new System.Drawing.Size(258, 495);
            this.gbchucnang.TabIndex = 0;
            this.gbchucnang.TabStop = false;
            // 
            // bttt
            // 
            this.bttt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttt.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bttt.FlatAppearance.BorderSize = 0;
            this.bttt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bttt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bttt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttt.Image = global::GUI.Properties.Resources.dangnhap;
            this.bttt.Location = new System.Drawing.Point(107, 375);
            this.bttt.Name = "bttt";
            this.bttt.Size = new System.Drawing.Size(45, 45);
            this.bttt.TabIndex = 8;
            this.bttt.UseVisualStyleBackColor = true;
            this.bttt.Click += new System.EventHandler(this.Bttt_Click);
            // 
            // lbtieude3
            // 
            this.lbtieude3.AutoSize = true;
            this.lbtieude3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtieude3.Location = new System.Drawing.Point(450, 28);
            this.lbtieude3.Name = "lbtieude3";
            this.lbtieude3.Size = new System.Drawing.Size(242, 22);
            this.lbtieude3.TabIndex = 1;
            this.lbtieude3.Text = "QUÊN TÊN NGƯỜI DÙNG";
            // 
            // pbdangnhap
            // 
            this.pbdangnhap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbdangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbdangnhap.Image = global::GUI.Properties.Resources.tieptuc;
            this.pbdangnhap.Location = new System.Drawing.Point(860, 0);
            this.pbdangnhap.Name = "pbdangnhap";
            this.pbdangnhap.Size = new System.Drawing.Size(20, 20);
            this.pbdangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbdangnhap.TabIndex = 15;
            this.pbdangnhap.TabStop = false;
            this.tt.SetToolTip(this.pbdangnhap, "Đăng nhập");
            this.pbdangnhap.Click += new System.EventHandler(this.Pbdangnhap_Click);
            // 
            // pbquaylai
            // 
            this.pbquaylai.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbquaylai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbquaylai.Image = global::GUI.Properties.Resources.quaylai;
            this.pbquaylai.Location = new System.Drawing.Point(826, 0);
            this.pbquaylai.Name = "pbquaylai";
            this.pbquaylai.Size = new System.Drawing.Size(20, 20);
            this.pbquaylai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbquaylai.TabIndex = 14;
            this.pbquaylai.TabStop = false;
            this.tt.SetToolTip(this.pbquaylai, "Quay lại");
            this.pbquaylai.Click += new System.EventHandler(this.Pbquaylai_Click);
            // 
            // pblogo
            // 
            this.pblogo.Image = global::GUI.Properties.Resources.logo;
            this.pblogo.Location = new System.Drawing.Point(296, 16);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(50, 50);
            this.pblogo.TabIndex = 16;
            this.pblogo.TabStop = false;
            // 
            // tt
            // 
            this.tt.AutoPopDelay = 5000;
            this.tt.InitialDelay = 0;
            this.tt.IsBalloon = true;
            this.tt.ReshowDelay = 110;
            // 
            // Uc_tennguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.pbdangnhap);
            this.Controls.Add(this.pbquaylai);
            this.Controls.Add(this.gbketqua);
            this.Controls.Add(this.gbchucnang);
            this.Controls.Add(this.lbtieude3);
            this.Name = "Uc_tennguoidung";
            this.Size = new System.Drawing.Size(880, 495);
            this.Load += new System.EventHandler(this.Uc_tennguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epsdt)).EndInit();
            this.gbketqua.ResumeLayout(false);
            this.gbketqua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsaochep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epemail)).EndInit();
            this.gbchucnang.ResumeLayout(false);
            this.gbchucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbdangnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbquaylai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epsdt;
        private System.Windows.Forms.PictureBox pbquaylai;
        private System.Windows.Forms.GroupBox gbketqua;
        private System.Windows.Forms.Label lbsaochep;
        private System.Windows.Forms.PictureBox pbsaochep;
        private System.Windows.Forms.Label lbtieude4;
        private System.Windows.Forms.Label lbtimthay;
        private System.Windows.Forms.Label lbkotimthay;
        private System.Windows.Forms.TextBox tbkq;
        private System.Windows.Forms.GroupBox gbchucnang;
        private System.Windows.Forms.Label lbsdt1;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Button bttt;
        private System.Windows.Forms.Label lbemail1;
        private System.Windows.Forms.LinkLabel llbquenmk;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbtieude2;
        private System.Windows.Forms.Label lbtieude1;
        private System.Windows.Forms.Label lbtieude3;
        private System.Windows.Forms.Timer tman;
        private System.Windows.Forms.ErrorProvider epemail;
        private System.Windows.Forms.PictureBox pbdangnhap;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Button btdangnhap;
    }
}
