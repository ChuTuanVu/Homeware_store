using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using DTO;
using UTLT;

namespace GUI.uckhongthedangnhap
{
    public partial class uc_mk : UserControl
    {
        private Gui_khongthedangnhap guiKhongthedangnhap;
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<TextBox> textBoxes1 = new List<TextBox>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private List<Button> buttons = new List<Button>();
        private Bll_taikhoan bllTaikhoan = new Bll_taikhoan();
        private taikhoan taikhoan;

        public uc_mk()
        {
            InitializeComponent();
            textBoxes.Add(tbemailhsdt);
            textBoxes.Add(tbtennguoidung);
            textBoxes1.Add(tbmk);
            textBoxes1.Add(tbxacnhanmk);
            pictureBoxes.Add(pbmkmoi);
            pictureBoxes.Add(pbxacnhanmk);
            buttons.Add(bttt);
        }

        private void Lbemailhsdt1_Click(object sender, EventArgs e)
        {
            lbemailhsdt1.Visible = false;
            lbemailhsdt.Visible = true;
            tbemailhsdt.Focus();
        }

        private void Lbtennguoidung1_Click(object sender, EventArgs e)
        {
            lbtennguoidung1.Visible = false;
            lbtennguoidung.Visible = true;
            tbtennguoidung.Focus();
        }

        private void Tbemailhsdt_Enter(object sender, EventArgs e)
        {
            lbemailhsdt1.Visible = false;
            lbemailhsdt.Visible = true;
        }

        private void Tbtennguoidung_Enter(object sender, EventArgs e)
        {
            lbtennguoidung1.Visible = false;
            lbtennguoidung.Visible = true;
        }

        private void Tbemailhsdt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbemailhsdt.Text))
            {
                lbemailhsdt1.Visible = true;
                lbemailhsdt.Visible = false;
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

        private void Bttt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bllTaikhoan.LayTaiKhoanEmailhSdtTen(tbemailhsdt.Text, tbtennguoidung.Text)))
            {
                lbkotimthay.Visible = true;
            }
            else
            {
                lbtimthay.Text = bllTaikhoan.LayTaiKhoanEmailhSdtTen(tbemailhsdt.Text, tbtennguoidung.Text);
                lbtieude5.Visible = true;
                lbtieude6.Visible = true;
                btxacnhan.Visible = true;
                lbtimthay.Visible = true;
                taikhoan = bllTaikhoan.LayTaikhoanTen(tbtennguoidung.Text);
            }
        }

        private void Btxacnhan_Click(object sender, EventArgs e)
        {
            lbtieude7.Visible = true;
            lbtieude8.Visible = true;
            lbmkmoi.Visible = true;
            lbmkmoi1.Visible = true;
            tbmk.Visible = true;
            lbxacnhanmk.Visible = true;
            lbxacnhanmk1.Visible = true;
            tbxacnhanmk.Visible = true;
            pbxacnhanmk.Visible = true;
            pbmkmoi.Visible = true;
        }

        private void Uc_mk_Load(object sender, EventArgs e)
        {
            guiKhongthedangnhap = FindForm() as Gui_khongthedangnhap;
        }

        private void Pbquaylai_Click(object sender, EventArgs e)
        {
            guiKhongthedangnhap.pnchinh.Visible = false;
        }

        private void Pbmkmoi_Click(object sender, EventArgs e)
        {
            Tool.Anmatkhau(textBoxes1, pictureBoxes);
        }

        private void Tbemailhsdt_TextChanged(object sender, EventArgs e)
        {
            lbkotimthay.Visible = false;
            lbtimthay.Visible = false;
            lbtieude6.Visible = false;
            btxacnhan.Visible = false;
            lbtieude5.Visible = false;
        }

        private void Tbtennguoidung_TextChanged(object sender, EventArgs e)
        {
            lbkotimthay.Visible = false;
            lbtimthay.Visible = false;
            lbtieude6.Visible = false;
            btxacnhan.Visible = false;
            lbtieude5.Visible = false;
        }

        private void Lbmkmoi1_Click(object sender, EventArgs e)
        {
            pbmkmoi.Visible = true;
            lbmkmoi1.Visible = false;
            lbmkmoi.Visible = true;
            tbmk.Focus();
        }

        private void Lbxacnhanmk1_Click(object sender, EventArgs e)
        {
            pbxacnhanmk.Visible = true;
            lbxacnhanmk1.Visible = false;
            lbxacnhanmk.Visible = true;
            tbxacnhanmk.Focus();
        }

        private void Pbxacnhanmk_Click(object sender, EventArgs e)
        {
            Tool.Anmatkhau(textBoxes1, pictureBoxes);
        }

        private void Tbmkmoi_Enter(object sender, EventArgs e)
        {
            pbmkmoi.Visible = true;
            lbmkmoi1.Visible = false;
            lbmkmoi.Visible = true;
        }

        private void Tbxacnhanmk_Enter(object sender, EventArgs e)
        {
            pbxacnhanmk.Visible = true;
            lbxacnhanmk1.Visible = false;
            lbxacnhanmk.Visible = true;
        }

        private void Tbxacnhanmk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxacnhanmk.Text))
            {
                pbxacnhanmk.Visible = false;
                lbxacnhanmk1.Visible = true;
                lbxacnhanmk.Visible = false;
                epxnmk.Clear();
            }
        }

        private void Tbmkmoi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbmk.Text))
            {
                pbmkmoi.Visible = false;
                lbmkmoi1.Visible = true;
                lbmkmoi.Visible = false;
                epmk.Clear();
            }
        }

        private void Pbdangnhap_Click(object sender, EventArgs e)
        {
            Tool.Form(guiKhongthedangnhap, new Gui_dangnhap());
        }

        private void Btdoimk_Click(object sender, EventArgs e)
        {
            taikhoan.matkhau = Tool.Sha256(tbxacnhanmk.Text);
            if (bllTaikhoan.Sua(taikhoan))
            {
                MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo");
            }
        }

        private void Llbquentennguoidung_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tool.UserControl(new Uc_tennguoidung(), guiKhongthedangnhap.pnchinh);
        }

        private void Tbmkmoi_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Matkhau(tbmk.Text))
            {
                epmk.Clear();
            }
            else
            {
                epmk.SetError(tbmk, "Mật khẩu phải dài ít nhất 8 ký tự.\n" +
                                    "Mật khẩu phải chứa hai trong số các ký tự sau: chữ cái, số hoặc ký hiệu!");
            }
        }

        private void Tbxacnhanmk_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Xnmk(tbmk.Text, tbxacnhanmk.Text)
            )
            {
                epxnmk.Clear();
                btdoimk.Visible = true;
            }
            else
            {
                epxnmk.SetError(tbxacnhanmk, "Mật khẩu mới không khớp. Hãy nhập lại mật khẩu mới tại đây!");
                btdoimk.Visible = false;
            }
        }
    }
}