using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using UTLT;

namespace GUI.uckhongthedangnhap
{
    public partial class Uc_tennguoidung : UserControl
    {
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<Button> buttons = new List<Button>();
        private Bll_taikhoan bllTaikhoan = new Bll_taikhoan();
        private Gui_khongthedangnhap guiKhongthedangnhap;

        public Uc_tennguoidung()
        {
            InitializeComponent();
            textBoxes.Add(tbemail);
            textBoxes.Add(tbsdt);
            buttons.Add(bttt);
        }

        private void Uc_tennguoidung_Load(object sender, EventArgs e)
        {
            guiKhongthedangnhap = FindForm() as Gui_khongthedangnhap;
        }

        private void Pbquaylai_Click(object sender, EventArgs e)
        {
            guiKhongthedangnhap.pnchinh.Visible = false;
        }

        private void Lbemail1_Click(object sender, EventArgs e)
        {
            lbemail1.Visible = false;
            lbemail.Visible = true;
            tbemail.Focus();
        }

        private void Lbsdt1_Click(object sender, EventArgs e)
        {
            lbsdt.Visible = true;
            lbsdt1.Visible = false;
            tbsdt.Focus();
        }

        private void Bttt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bllTaikhoan.LayTennguoidung(tbemail.Text, tbsdt.Text)))
            {
                lbkotimthay.Visible = true;
            }
            else
            {
                lbtimthay.Text = "Dưới đây là tài khoản được liên kết với địa chỉ email \n" + tbemail.Text + " và số điện thoại " + tbsdt.Text + "của bạn:";
                lbtimthay.Visible = true;
                tbkq.Text = (bllTaikhoan.LayTennguoidung(tbemail.Text, tbsdt.Text));
                pbsaochep.Visible = true;
                tbkq.Visible = true;
                btdangnhap.Visible = true;
            }
        }

        private void Pbsaochep_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbkq.Text))
            {
                Clipboard.SetText(tbkq.Text);
                lbsaochep.Visible = true;
                tman.Start();
            }
        }

        private void Tbemail_Enter(object sender, EventArgs e)
        {
            lbemail1.Visible = false;
            lbemail.Visible = true;
        }

        private void Tbsdt_Enter(object sender, EventArgs e)
        {
            lbsdt1.Visible = false;
            lbsdt.Visible = true;
        }

        private void Tbemail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbemail.Text))
            {
                lbemail1.Visible = true;
                lbemail.Visible = false;
            }
        }

        private void Tbsdt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbsdt.Text))
            {
                lbsdt1.Visible = true;
                lbsdt.Visible = false;
            }
        }

        private void Tbsdt_TextChanged(object sender, EventArgs e)
        {
        }

        private void Llbquenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tool.UserControl(new uc_mk(), guiKhongthedangnhap.pnchinh);
        }

        private void Tman_Tick(object sender, EventArgs e)
        {
            lbsaochep.Visible = false;
            tman.Stop();
        }

        private void Tbemail_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Pbdangnhap_Click(object sender, EventArgs e)
        {
            Tool.Form(guiKhongthedangnhap, new Gui_dangnhap());
        }

        private void Btdangnhap_Click(object sender, EventArgs e)
        {
            Tool.Form(guiKhongthedangnhap, new Gui_dangnhap());
        }

        private void Tbsdt_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}