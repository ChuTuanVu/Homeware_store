using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using UTLT;

namespace GUI
{
    public partial class Gui_dangnhap : Form
    {
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<TextBox> textBoxesbat = new List<TextBox>();
        private List<Button> buttons = new List<Button>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private Bll_taikhoan bllTaikhoan = new Bll_taikhoan();

        public Gui_dangnhap()
        {
            InitializeComponent();
            textBoxes.Add(tbmk);
            textBoxesbat.Add(tbtennguoidung);
            textBoxesbat.Add(tbmk);
            buttons.Add(btdangnhap);
            pictureBoxes.Add(pbmk);
        }

        private void Lbtennguoidung1_Click(object sender, EventArgs e)
        {
            lbtennguoidung1.Visible = false;
            lbtennguoidung.Visible = true;
            tbtennguoidung.Focus();
        }

        private void Lbmk1_Click(object sender, EventArgs e)
        {
            lbmk1.Visible = false;
            lbmk.Visible = true;
            tbmk.Focus();
        }

        private void Pbhienmk_Click(object sender, EventArgs e)
        {
            Tool.Anmatkhau(textBoxes, pictureBoxes);
        }

        private void Tbmk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbmk.Text))
            {
                lbmk1.Visible = true;
                lbmk.Visible = false;
            }
        }

        private void Tbtennguoidung_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtennguoidung.Text))
            {
                lbtennguoidung1.Visible = true;
                lbtennguoidung.Visible = false;
            }
        }

        private void Tbtennguoidung_Enter(object sender, EventArgs e)
        {
            lbtennguoidung1.Visible = false;
            lbtennguoidung.Visible = true;
        }

        private void Pbthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pbthunho_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Tbmk_Enter(object sender, EventArgs e)
        {
            lbmk1.Visible = false;
            lbmk.Visible = true;
        }

        private void Pbthoat_MouseEnter(object sender, EventArgs e)
        {
            pbthoat.BackColor = Color.Red;
        }

        private void Pbthoat_MouseLeave(object sender, EventArgs e)
        {
            pbthoat.BackColor = SystemColors.ControlLight;
        }

        private void Tbtennguoidung_TextChanged(object sender, EventArgs e)
        {
            Tool.Bat(buttons, textBoxesbat);
        }

        private void Tbmk_TextChanged(object sender, EventArgs e)
        {
            Tool.Bat(buttons, textBoxesbat);
        }

        private void Btdannhap_Click(object sender, EventArgs e)
        {
            if (bllTaikhoan.LayTaikhoanTenMat(tbtennguoidung.Text, Tool.Sha256(tbmk.Text)) != null)
            {
                Bll_taikhoan.taikhoanchon = bllTaikhoan.LayTaikhoanTenMat(tbtennguoidung.Text, Tool.Sha256(tbmk.Text));
                Tool.Form(this, new Gui_chinh());
            }
            else
            {
                tbmk.Clear();
                MessageBox.Show("Tên người dùng hoặc mật khẩu của bạn không chính xác!","Thông báo");
            }
        }

        private void Ll_khongthedangnhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tool.Form(this, new Gui_khongthedangnhap());
        }

        private void Pbthunho_MouseEnter(object sender, EventArgs e)
        {
            pbthunho.BackColor = SystemColors.ControlDark;
        }

        private void Pbthunho_MouseLeave(object sender, EventArgs e)
        {
            pbthunho.BackColor = SystemColors.ControlLight;
        }
    }
}