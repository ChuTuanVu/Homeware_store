using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using DTO;
using UTLT;

namespace GUI.uckhongthedangnhap
{
    public partial class Uc_dangky : UserControl
    {
        private Bll_taikhoan bllTaikhoan = new Bll_taikhoan();
        private Gui_khongthedangnhap guiKhongthedangnhap;
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        public Uc_dangky()
        {
            InitializeComponent();
            TuyChinhMsBox.Yes = "Có";
            TuyChinhMsBox.No = "Không";
            TuyChinhMsBox.Bat();
            textBoxes.Add(tbmk);
            pictureBoxes.Add(pbhienmk);
        }

        private void Btemail_Click(object sender, EventArgs e)
        {
            pbemail.Image = Properties.Resources.dangkytich;
            lbsdt.Visible = true;
            pbsdt.Visible = true;
            tbsdt.Visible = true;
            btsdt.Visible = true;
            btemail.Visible = false;
            tbsdt.Focus();
        }

        private void Btsdt_Click(object sender, EventArgs e)
        {
            pbsdt.Image = Properties.Resources.dangkytich;
            lbmk.Visible = true;
            pbmk.Visible = true;
            tbmk.Visible = true;
            pbhienmk.Visible = true;
            btmk.Visible = true;
            btsdt.Visible = false;
            tbmk.Focus();
        }

        private void Btmk_Click(object sender, EventArgs e)
        {
            pbmk.Image = Properties.Resources.dangkytich;
            lbtennguoidung.Visible = true;
            pbtennguoidung.Visible = true;
            tbtennguoidung.Visible = true;
            bttennguoidung.Visible = true;
            btmk.Visible = false;
            tbtennguoidung.Focus();
        }

        private void Bttennguoidung_Click(object sender, EventArgs e)
        {
            pbtennguoidung.Image = Properties.Resources.dangkytich;
            lbnamsinh.Visible = true;
            dtpkngaysinh.Visible = true;
            btdangky.Visible = true;
            bttennguoidung.Visible = false;
            dtpkngaysinh.Focus();
        }

        private void Tbemail_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbemail.Text))
            {
                btemail.Visible = true;
                btsdt.Visible = false;
                btmk.Visible = false;
                bttennguoidung.Visible = false;
                pbemail.Image = Properties.Resources.dangkymuiten;
            }
            pbemail.Image = Properties.Resources.dangkymuiten;

        }

        private void Tbemail_Leave(object sender, EventArgs e)
        {
            if (btemail.Enabled == false)
            {
                epemail.Clear();
                pbemail.Image = Properties.Resources.dangkyx;
            }
            else
            {
                pbemail.Image = Properties.Resources.dangkytich;
            }
        }

        private void Tbsdt_Enter(object sender, EventArgs e)
        {
            btemail.Visible = false;
            btsdt.Visible = true;
            btmk.Visible = false;
            bttennguoidung.Visible = false;
            pbsdt.Image = Properties.Resources.dangkymuiten;
        }

        private void Tbsdt_Leave(object sender, EventArgs e)
        {
            if (btsdt.Enabled == false)
            {
                epsdt.Clear();
                pbsdt.Image = Properties.Resources.dangkyx;
            }
            else
            {
                pbsdt.Image = Properties.Resources.dangkytich;
            }
        }

        private void Tbmk_Enter(object sender, EventArgs e)
        {
            btemail.Visible = false;
            btsdt.Visible = false;
            btmk.Visible = true;
            bttennguoidung.Visible = false;
            pbmk.Image = Properties.Resources.dangkymuiten;
        }

        private void Tbmk_Leave(object sender, EventArgs e)
        {
            if (btmk.Enabled == false)
            {
                epmk.Clear();
                pbmk.Image = Properties.Resources.dangkyx;
            }
            else
            {
                pbmk.Image = Properties.Resources.dangkytich;
            }
        }

        private void Tbtennguoidung_Enter(object sender, EventArgs e)
        {
            btemail.Visible = false;
            btsdt.Visible = false;
            btmk.Visible = false;
            bttennguoidung.Visible = true;
            pbtennguoidung.Image = Properties.Resources.dangkymuiten;
        }

        private void Tbtennguoidung_Leave(object sender, EventArgs e)
        {
            if (bttennguoidung.Enabled == false)
            {
                eptennguoidung.Clear();
                pbtennguoidung.Image = Properties.Resources.dangkyx;
            }
            else
            {
                pbtennguoidung.Image = Properties.Resources.dangkytich;
            }
        }

        private void Btdangky_Click(object sender, EventArgs e)
        {
            if (Tool.Tennguoidung(tbtennguoidung.Text) && Tool.Matkhau(tbmk.Text) && Tool.Email(tbemail.Text) && Tool.Sdt(tbsdt.Text))
            {
                taikhoan taikhoanmoi = new taikhoan
                {
                    tennguoidung = tbtennguoidung.Text,
                    matkhau = Tool.Sha256(tbmk.Text),
                    email = tbemail.Text,
                    sdt = tbsdt.Text,
                    ngaysinh = dtpkngaysinh.Value,
                    quyen = false,
                    ngaydangky = DateTime.Now
                };
                bllTaikhoan.Them(taikhoanmoi);
                if (MessageBox.Show("Đăng ký thành công\nBạn có muốn chuyển đến trang đăng nhập không?", "Thành công", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Tool.Form(guiKhongthedangnhap, new Gui_dangnhap());
                }
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công!", "Thông báo");
                if (Tool.Tennguoidung(tbtennguoidung.Text) == false)
                {
                    eptennguoidung.SetError(tbtennguoidung, "Tên người dùng " + tbtennguoidung.Text + " không khả dụng!");
                }
                if (Tool.Email(tbemail.Text) == false)
                {
                    epemail.SetError(tbemail, "Email không hợp lệ hoặc đã được sử dụng!");
                }
                if (Tool.Sdt(tbsdt.Text) == false)
                {
                    epsdt.SetError(tbsdt, "Số điện thoại không hợp lệ hoặc đã được sử dụng!");
                }
                if (Tool.Matkhau(tbmk.Text) == false)
                {
                    epmk.SetError(tbmk, "Mật khẩu phải dài ít nhất 8 ký tự.\n" +
                                        "Mật khẩu phải chứa hai trong số các ký tự sau: chữ cái, số hoặc ký hiệu!");
                }
            }
        }

        private void Uc_dangky_Load(object sender, EventArgs e)
        {
            guiKhongthedangnhap = FindForm() as Gui_khongthedangnhap;
        }

        private void Pbhienmk_Click(object sender, EventArgs e)
        {
            Tool.Anmatkhau(textBoxes, pictureBoxes);
        }

        private void Tbemail_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Email(tbemail.Text))
            {
                btemail.Enabled = true;
                epemail.Clear();
            }
            else
            {
                epemail.SetError(tbemail, "Email không hợp lệ hoặc đã được sử dụng!");
                btemail.Enabled = false;
            }
        }

        private void Tbsdt_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Sdt(tbsdt.Text))
            {
                btsdt.Enabled = true;
                epsdt.Clear();
            }
            else
            {
                epsdt.SetError(tbsdt, "Số điện thoại không hợp lệ hoặc đã được sử dụng!");
                btsdt.Enabled = false;
            }
        }

        private void Tbmk_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Matkhau(tbmk.Text))
            {
                btmk.Enabled = true;
                epmk.Clear();
            }
            else
            {
                epmk.SetError(tbmk, "Mật khẩu phải dài ít nhất 8 ký tự.\n" +
                                    "Mật khẩu phải chứa hai trong số các ký tự sau: chữ cái, số hoặc ký hiệu!");
                btmk.Enabled = false;
            }
        }

        private void Tbtennguoidung_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Tennguoidung(tbtennguoidung.Text))
            {
                eptennguoidung.Clear();
                bttennguoidung.Enabled = true;
            }
            else
            {
                eptennguoidung.SetError(tbtennguoidung, "Tên người dùng" + tbtennguoidung.Text + "không khả dụng!");
                bttennguoidung.Enabled = false;
            }
        }

        private void Pbquaylai_Click(object sender, EventArgs e)
        {
            guiKhongthedangnhap.pnchinh.Visible = false;
        }

        private void Pbdangnhap_Click(object sender, EventArgs e)
        {
            Tool.Form(guiKhongthedangnhap, new Gui_dangnhap());
        }
    }
}