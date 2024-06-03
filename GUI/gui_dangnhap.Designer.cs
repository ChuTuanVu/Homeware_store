using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    partial class Gui_dangnhap
    {
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.Style |= WS_MINIMIZEBOX;
                createParams.ClassStyle |= CS_DBLCLKS;
                return createParams;
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        Point point = PointToClient(Cursor.Position);
                        if (point.Y <= 20)
                        {
                            m.Result = (IntPtr)0x2;
                        }
                    }

                    return;
                case 0xA3:
                    return;
            }

            base.WndProc(ref m);
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui_dangnhap));
            this.gbchucnang = new System.Windows.Forms.GroupBox();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.ll_khongthedangnhap = new System.Windows.Forms.LinkLabel();
            this.lbmk1 = new System.Windows.Forms.Label();
            this.lbtennguoidung1 = new System.Windows.Forms.Label();
            this.pbmk = new System.Windows.Forms.PictureBox();
            this.tbmk = new System.Windows.Forms.TextBox();
            this.tbtennguoidung = new System.Windows.Forms.TextBox();
            this.lbmk = new System.Windows.Forms.Label();
            this.lbtennguoidung = new System.Windows.Forms.Label();
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.pbthoat = new System.Windows.Forms.PictureBox();
            this.pbthunho = new System.Windows.Forms.PictureBox();
            this.gbchucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbthoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbthunho)).BeginInit();
            this.SuspendLayout();
            // 
            // gbchucnang
            // 
            this.gbchucnang.AutoSize = true;
            this.gbchucnang.BackColor = System.Drawing.Color.Transparent;
            this.gbchucnang.Controls.Add(this.pblogo);
            this.gbchucnang.Controls.Add(this.btdangnhap);
            this.gbchucnang.Controls.Add(this.ll_khongthedangnhap);
            this.gbchucnang.Controls.Add(this.lbmk1);
            this.gbchucnang.Controls.Add(this.lbtennguoidung1);
            this.gbchucnang.Controls.Add(this.pbmk);
            this.gbchucnang.Controls.Add(this.tbmk);
            this.gbchucnang.Controls.Add(this.tbtennguoidung);
            this.gbchucnang.Controls.Add(this.lbmk);
            this.gbchucnang.Controls.Add(this.lbtennguoidung);
            this.gbchucnang.Controls.Add(this.lbdangnhap);
            this.gbchucnang.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbchucnang.Location = new System.Drawing.Point(0, 0);
            this.gbchucnang.Margin = new System.Windows.Forms.Padding(4);
            this.gbchucnang.Name = "gbchucnang";
            this.gbchucnang.Padding = new System.Windows.Forms.Padding(4);
            this.gbchucnang.Size = new System.Drawing.Size(259, 495);
            this.gbchucnang.TabIndex = 0;
            this.gbchucnang.TabStop = false;
            // 
            // pblogo
            // 
            this.pblogo.Image = global::GUI.Properties.Resources.logo;
            this.pblogo.Location = new System.Drawing.Point(106, 27);
            this.pblogo.Margin = new System.Windows.Forms.Padding(4);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(50, 50);
            this.pblogo.TabIndex = 51;
            this.pblogo.TabStop = false;
            // 
            // btdangnhap
            // 
            this.btdangnhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btdangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdangnhap.Enabled = false;
            this.btdangnhap.FlatAppearance.BorderSize = 0;
            this.btdangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdangnhap.Image = global::GUI.Properties.Resources.dangnhap;
            this.btdangnhap.Location = new System.Drawing.Point(110, 369);
            this.btdangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(50, 50);
            this.btdangnhap.TabIndex = 7;
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.Btdannhap_Click);
            // 
            // ll_khongthedangnhap
            // 
            this.ll_khongthedangnhap.AutoSize = true;
            this.ll_khongthedangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ll_khongthedangnhap.LinkColor = System.Drawing.SystemColors.WindowText;
            this.ll_khongthedangnhap.Location = new System.Drawing.Point(30, 458);
            this.ll_khongthedangnhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ll_khongthedangnhap.Name = "ll_khongthedangnhap";
            this.ll_khongthedangnhap.Size = new System.Drawing.Size(203, 19);
            this.ll_khongthedangnhap.TabIndex = 8;
            this.ll_khongthedangnhap.TabStop = true;
            this.ll_khongthedangnhap.Text = "KHÔNG THỂ ĐĂNG NHẬP?";
            this.ll_khongthedangnhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_khongthedangnhap_LinkClicked);
            // 
            // lbmk1
            // 
            this.lbmk1.AutoSize = true;
            this.lbmk1.BackColor = System.Drawing.SystemColors.Window;
            this.lbmk1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmk1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbmk1.Location = new System.Drawing.Point(30, 282);
            this.lbmk1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmk1.Name = "lbmk1";
            this.lbmk1.Size = new System.Drawing.Size(67, 19);
            this.lbmk1.TabIndex = 5;
            this.lbmk1.Text = "Mật khẩu";
            this.lbmk1.Click += new System.EventHandler(this.Lbmk1_Click);
            this.lbmk1.Leave += new System.EventHandler(this.Tbmk_Leave);
            // 
            // lbtennguoidung1
            // 
            this.lbtennguoidung1.AutoSize = true;
            this.lbtennguoidung1.BackColor = System.Drawing.SystemColors.Window;
            this.lbtennguoidung1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtennguoidung1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbtennguoidung1.Location = new System.Drawing.Point(30, 214);
            this.lbtennguoidung1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtennguoidung1.Name = "lbtennguoidung1";
            this.lbtennguoidung1.Size = new System.Drawing.Size(103, 19);
            this.lbtennguoidung1.TabIndex = 2;
            this.lbtennguoidung1.Text = "Tên người dùng";
            this.lbtennguoidung1.Click += new System.EventHandler(this.Lbtennguoidung1_Click);
            this.lbtennguoidung1.Enter += new System.EventHandler(this.Tbtennguoidung_Enter);
            this.lbtennguoidung1.Leave += new System.EventHandler(this.Tbtennguoidung_Leave);
            // 
            // pbmk
            // 
            this.pbmk.BackColor = System.Drawing.SystemColors.Window;
            this.pbmk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbmk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbmk.Image = global::GUI.Properties.Resources.matkhauan;
            this.pbmk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbmk.Location = new System.Drawing.Point(235, 283);
            this.pbmk.Margin = new System.Windows.Forms.Padding(4);
            this.pbmk.Name = "pbmk";
            this.pbmk.Size = new System.Drawing.Size(16, 16);
            this.pbmk.TabIndex = 16;
            this.pbmk.TabStop = false;
            this.pbmk.Click += new System.EventHandler(this.Pbhienmk_Click);
            // 
            // tbmk
            // 
            this.tbmk.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbmk.Location = new System.Drawing.Point(28, 278);
            this.tbmk.Margin = new System.Windows.Forms.Padding(6);
            this.tbmk.Name = "tbmk";
            this.tbmk.Size = new System.Drawing.Size(197, 26);
            this.tbmk.TabIndex = 6;
            this.tbmk.UseSystemPasswordChar = true;
            this.tbmk.TextChanged += new System.EventHandler(this.Tbmk_TextChanged);
            this.tbmk.Enter += new System.EventHandler(this.Tbmk_Enter);
            this.tbmk.Leave += new System.EventHandler(this.Tbmk_Leave);
            // 
            // tbtennguoidung
            // 
            this.tbtennguoidung.BackColor = System.Drawing.SystemColors.Window;
            this.tbtennguoidung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbtennguoidung.Location = new System.Drawing.Point(28, 210);
            this.tbtennguoidung.Margin = new System.Windows.Forms.Padding(4);
            this.tbtennguoidung.Name = "tbtennguoidung";
            this.tbtennguoidung.Size = new System.Drawing.Size(223, 26);
            this.tbtennguoidung.TabIndex = 3;
            this.tbtennguoidung.TextChanged += new System.EventHandler(this.Tbtennguoidung_TextChanged);
            this.tbtennguoidung.Enter += new System.EventHandler(this.Tbtennguoidung_Enter);
            this.tbtennguoidung.Leave += new System.EventHandler(this.Tbtennguoidung_Leave);
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.BackColor = System.Drawing.Color.Transparent;
            this.lbmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbmk.Location = new System.Drawing.Point(28, 253);
            this.lbmk.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(67, 19);
            this.lbmk.TabIndex = 4;
            this.lbmk.Text = "Mật khẩu";
            this.lbmk.Visible = false;
            // 
            // lbtennguoidung
            // 
            this.lbtennguoidung.AutoSize = true;
            this.lbtennguoidung.BackColor = System.Drawing.Color.Transparent;
            this.lbtennguoidung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtennguoidung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbtennguoidung.Location = new System.Drawing.Point(24, 187);
            this.lbtennguoidung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtennguoidung.Name = "lbtennguoidung";
            this.lbtennguoidung.Size = new System.Drawing.Size(103, 19);
            this.lbtennguoidung.TabIndex = 1;
            this.lbtennguoidung.Text = "Tên người dùng";
            this.lbtennguoidung.Visible = false;
            // 
            // lbdangnhap
            // 
            this.lbdangnhap.AutoSize = true;
            this.lbdangnhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdangnhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbdangnhap.Location = new System.Drawing.Point(78, 138);
            this.lbdangnhap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbdangnhap.Name = "lbdangnhap";
            this.lbdangnhap.Size = new System.Drawing.Size(107, 24);
            this.lbdangnhap.TabIndex = 0;
            this.lbdangnhap.Text = "Đăng nhập";
            // 
            // pbthoat
            // 
            this.pbthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbthoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbthoat.Image = global::GUI.Properties.Resources.dong;
            this.pbthoat.Location = new System.Drawing.Point(860, 0);
            this.pbthoat.Margin = new System.Windows.Forms.Padding(4);
            this.pbthoat.Name = "pbthoat";
            this.pbthoat.Size = new System.Drawing.Size(20, 20);
            this.pbthoat.TabIndex = 6;
            this.pbthoat.TabStop = false;
            this.pbthoat.Click += new System.EventHandler(this.Pbthoat_Click);
            this.pbthoat.MouseEnter += new System.EventHandler(this.Pbthoat_MouseEnter);
            this.pbthoat.MouseLeave += new System.EventHandler(this.Pbthoat_MouseLeave);
            // 
            // pbthunho
            // 
            this.pbthunho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbthunho.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbthunho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbthunho.Image = global::GUI.Properties.Resources.thunho;
            this.pbthunho.Location = new System.Drawing.Point(820, 0);
            this.pbthunho.Margin = new System.Windows.Forms.Padding(4);
            this.pbthunho.Name = "pbthunho";
            this.pbthunho.Size = new System.Drawing.Size(20, 20);
            this.pbthunho.TabIndex = 5;
            this.pbthunho.TabStop = false;
            this.pbthunho.Click += new System.EventHandler(this.Pbthunho_Click);
            this.pbthunho.MouseEnter += new System.EventHandler(this.Pbthunho_MouseEnter);
            this.pbthunho.MouseLeave += new System.EventHandler(this.Pbthunho_MouseLeave);
            // 
            // Gui_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 495);
            this.Controls.Add(this.pbthoat);
            this.Controls.Add(this.pbthunho);
            this.Controls.Add(this.gbchucnang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gui_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.gbchucnang.ResumeLayout(false);
            this.gbchucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbthoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbthunho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox gbchucnang;
        private Label lbmk1;
        private Label lbtennguoidung1;
        private PictureBox pbmk;
        private TextBox tbmk;
        private TextBox tbtennguoidung;
        private Label lbmk;
        private Label lbtennguoidung;
        private Label lbdangnhap;
        private PictureBox pbthunho;
        private PictureBox pbthoat;
        private LinkLabel ll_khongthedangnhap;
        private Button btdangnhap;
        private PictureBox pblogo;
    }
}