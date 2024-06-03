using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UTLT;
using BLL;
using DTO;

namespace GUI
{
    public partial class gui_thongtin : Form
    {
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        private Bll_taikhoan bllTaikhoan = new Bll_taikhoan();
        private taikhoan taikhoan;

        public gui_thongtin()
        {
            InitializeComponent();
            textBoxes.Add(tbmk);
            textBoxes.Add(tbmkmoi);
            textBoxes.Add(tbxacnhanmk);
            pictureBoxes.Add(pbmk);
            pictureBoxes.Add(pbmkmoi);
            pictureBoxes.Add(pbxacnhanmk);
            TuyChinhMsBox.Yes = "Có";
            TuyChinhMsBox.No = "Không";
            TuyChinhMsBox.Bat();
        }

        private void Pbmkmoi_Click(object sender, EventArgs e)
        {
            Tool.Anmatkhau(textBoxes, pictureBoxes);
        }

        private void Pbxacnhanmk_Click(object sender, EventArgs e)
        {
            Tool.Anmatkhau(textBoxes, pictureBoxes);
        }

        private void Btluu2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận lưu thông tin.", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Tool.Matkhau(tbmkmoi.Text) && Tool.Xnmk(tbmkmoi.Text, tbxacnhanmk.Text))
                {
                    if (Tool.Sha256(tbmk.Text) == taikhoan.matkhau)
                    {
                        epmkmoi.Clear();
                        epxnmk.Clear();
                        taikhoan.matkhau = Tool.Sha256(tbxacnhanmk.Text);
                        bllTaikhoan.Sua(taikhoan);
                        MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không khớp với dữ liệu của chúng tôi!", "Thông báo");
                        tbmk.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại!", "Thông báo");
                    if (Tool.Matkhau(tbmkmoi.Text) == false)
                    {
                        epmkmoi.SetError(tbmkmoi, "Mật khẩu phải dài ít nhất 8 ký tự.\n" +
                                            "Mật khẩu phải chứa hai trong số các ký tự sau: chữ cái, số hoặc ký hiệu!");
                    }
                    if (Tool.Xnmk(tbmkmoi.Text, tbxacnhanmk.Text) == false)
                    {
                        epxnmk.SetError(tbxacnhanmk, "Mật khẩu mới không khớp. Hãy nhập lại mật khẩu mới tại đây!");
                    }
                }
            }
        }

        private void Pbmk_Click(object sender, EventArgs e)
        {
            Tool.Anmatkhau(textBoxes, pictureBoxes);
        }

        private void Btluu1_Click(object sender, EventArgs e)
        {
            if (taikhoan != null)
            {
                if (MessageBox.Show("Xác nhận lưu thông tin.", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Tool.Emaillay(tbemail.Text) && Tool.Sdtlay(tbsdt.Text))
                    {
                        epemail.Clear();
                        epsdt.Clear();
                        if (taikhoan.email == tbemail.Text)
                        {

                        }
                        else
                        {
                            taikhoan.email = tbemail.Text;
                        }
                        taikhoan.sdt = tbsdt.Text;
                        taikhoan.diachi = tbdiachi.Text;
                        bllTaikhoan.Sua(taikhoan);
                        MessageBox.Show("Lưu thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin thất bại!", "Thông báo");
                        if (Tool.Emaillay(tbemail.Text) == false)
                        {
                            epemail.SetError(tbemail, "Email không hợp lệ hoặc đã được sử dụng!");
                        }
                        if (Tool.Sdtlay(tbsdt.Text) == false)
                        {
                            epsdt.SetError(tbsdt, "Số điện thoại không hợp lệ hoặc đã được sử dụng!");
                        }
                    }
                }
            }
        }

        private void Gui_thongtin_Load(object sender, EventArgs e)
        {
            taikhoan = Bll_taikhoan.taikhoanchon;
            tbtennguoidung.Text = Tool.Mahoa(taikhoan.tennguoidung);
            tbsdt.Text = taikhoan.sdt;
            tbemail.Text = taikhoan.email;
            tbdiachi.Text = taikhoan.diachi;
            if (taikhoan.ngaysinh.HasValue)
            {
                tbngaysinh.Text = $"•• | •• | {taikhoan.ngaysinh.Value.Year}";
            }
            else
            {
                tbngaysinh.Text = "Không xác định";
            }

        }

        private void Lbmk1_Click(object sender, EventArgs e)
        {
            pbmk.Visible = true;
            lbmk1.Visible = false;
            lbmk.Visible = true;
            tbmk.Focus();
        }

        private void Lbmkmoi1_Click(object sender, EventArgs e)
        {
            pbmkmoi.Visible = true;
            lbmkmoi1.Visible = false;
            lbmkmoi.Visible = true;
            tbmkmoi.Focus();
        }

        private void Lbxacnhanmk1_Click(object sender, EventArgs e)
        {
            pbxacnhanmk.Visible = true;
            lbxacnhanmk1.Visible = false;
            lbxacnhanmk.Visible = true;
            tbxacnhanmk.Focus();
        }

        private void Tbmk_Leave(object sender, EventArgs e)
        {
            pbmk.Visible = false;
            if (string.IsNullOrEmpty(tbmk.Text))
            {
                lbmk1.Visible = true;
                lbmk.Visible = false;
            }
        }

        private void Tbmkmoi_Leave(object sender, EventArgs e)
        {
            pbmkmoi.Visible = false;
            if (string.IsNullOrEmpty(tbmkmoi.Text))
            {
                lbmkmoi1.Visible = true;
                lbmkmoi.Visible = false;
                epmkmoi.Clear();
            }
        }

        private void Tbxacnhanmk_Leave(object sender, EventArgs e)
        {
            pbxacnhanmk.Visible = false;
            if (string.IsNullOrEmpty(tbxacnhanmk.Text))
            {
                lbxacnhanmk1.Visible = true;
                lbxacnhanmk.Visible = false;
                epxnmk.Clear();
            }
        }

        private void Tbmk_Enter(object sender, EventArgs e)
        {
            lbmk1.Visible = false;
            lbmk.Visible = true;
            pbmk.Visible = true;
        }

        private void Tbmkmoi_Enter(object sender, EventArgs e)
        {
            lbmkmoi1.Visible = false;
            lbmkmoi.Visible = true;
            pbmkmoi.Visible = true;
        }

        private void Tbxacnhanmk_Enter(object sender, EventArgs e)
        {
            lbxacnhanmk1.Visible = false;
            lbxacnhanmk.Visible = true;
            pbxacnhanmk.Visible = true;
        }

        private void Tbemail_Click(object sender, EventArgs e)
        {
            if (tbemail.Text == taikhoan.email)
            {
                tbemail.Clear();
                epemail.Clear();
            }
        }

        private void Tbemail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbemail.Text))
            {
                tbemail.Text = taikhoan.email;
            }
        }

        private void Bthuy_Click(object sender, EventArgs e)
        {
            tbmk.Clear();
            tbmkmoi.Clear();
            tbxacnhanmk.Clear();
            bthuy.Visible = false;
            lbmk1.Visible = true;
            lbmk.Visible = false;
            lbmkmoi1.Visible = true;
            lbmkmoi.Visible = false;
            lbxacnhanmk1.Visible = true;
            lbxacnhanmk.Visible = true;
        }

        private void Tbxacnhanmk_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbmk.Text))
            {
                bthuy.Visible = true;
            }
            else
            {
                bthuy.Visible = false;
            }
            if (Tool.Xnmk(tbmkmoi.Text, tbxacnhanmk.Text))
            {
                epxnmk.Clear();
            }
            else
            {
                epxnmk.SetError(tbxacnhanmk, "Mật khẩu mới không khớp. Hãy nhập lại mật khẩu mới tại đây!");
            }
        }

        private void Tbmkmoi_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Matkhau(tbmkmoi.Text))
            {
                epmkmoi.Clear();
            }
            else
            {
                epmkmoi.SetError(tbmkmoi, "Mật khẩu phải dài ít nhất 8 ký tự.\n" +
                                    "Mật khẩu phải chứa hai trong số các ký tự sau: chữ cái, số hoặc ký hiệu!");
            }
        }

        private void Tbsdt_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Sdtlay(tbsdt.Text))
            {
                btluu1.Enabled = true;
                epsdt.Clear();
            }
            else
            {
                epsdt.SetError(tbsdt, "Số điện thoại không hợp lệ hoặc đã được sử dụng!");
                btluu1.Enabled = false;
            }
        }

        private void Tbemail_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Emaillay(tbemail.Text))
            {
                btluu1.Enabled = true;
                epemail.Clear();
            }
            else
            {
                btluu1.Enabled = false;
                epemail.SetError(tbemail, "Email không hợp lệ hoặc đã được sử dụng!");
            }
        }

        private void Tbdiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(tbdiachi.Text))
            {
                btluu1.Enabled = false;
            }
            else
            {
                btluu1.Enabled = true;
            }
            
        }
    }
}