using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;
using UTLT;

namespace GUI.uc_chinh
{
    public partial class Uc_taikhoan : UserControl
    {
        private taikhoan taikhoan = null;
        private Bll_taikhoan bllTaikhoan = new Bll_taikhoan();
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        public Uc_taikhoan()
        {
            InitializeComponent();
            textBoxes.Add(tbmk);
            pictureBoxes.Add(pbmk);
            TuyChinhMsBox.Yes = "Có";
            TuyChinhMsBox.No = "Không";
            TuyChinhMsBox.Bat();
        }

        private void Tai(List<taikhoan> taikhoan)
        {
            dtbvtaikhoan.DataSource = taikhoan.Select(v => new { v.tennguoidung, v.email, v.sdt, v.diachi, v.ngaysinh, v.ngaydangky }).ToList();
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm tài khoản mới không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Tool.Tennguoidung(tbtennguoidung.Text) && Tool.Matkhau(tbmk.Text) && Tool.Email(tbemail.Text) && Tool.Sdt(tbsdt.Text))
                {
                    taikhoan taikhoanthem = new taikhoan()
                    {
                        tennguoidung = tbtennguoidung.Text,
                        matkhau = Tool.Sha256(tbmk.Text),
                        email = tbemail.Text,
                        sdt = tbsdt.Text,
                        diachi = tbdiachi.Text,
                        ngaysinh = dtpkngaysinh.Value.Date,
                        ngaydangky = DateTime.Now,
                        quyen = false
                    };
                    bllTaikhoan.Them(taikhoanthem);
                    MessageBox.Show("Thêm tài khoản thành công.", "Thông báo");
                    Tai(bllTaikhoan.Lay());
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại!", "Thông báo");
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
        }

        private void Btsua_Click(object sender, EventArgs e)
        {
            if (taikhoan != null)
            {
                if (MessageBox.Show($"Bạn có muốn sửa tài khoản \"{tbtennguoidung.Text}\" không?", "Thông báo", MessageBoxButtons.YesNo) ==
                 DialogResult.Yes)
                {
                    if (Tool.Tennguoidunglay(tbtennguoidung.Text) && Tool.Matkhau(tbmk.Text) && Tool.Emaillay(tbemail.Text) &&
                        Tool.Sdtlay(tbsdt.Text))
                    {
                        taikhoan taikhoansua = new taikhoan
                        {
                            tennguoidung = taikhoan.tennguoidung,
                            matkhau = Tool.Sha256(tbmk.Text),
                            email = tbemail.Text,
                            sdt = tbsdt.Text,
                            diachi = tbdiachi.Text,
                            ngaysinh = dtpkngaysinh.Value.Date
                        };
                        if (bllTaikhoan.Sua(taikhoansua))
                        {
                            MessageBox.Show("Sửa tài khoản thành công.", "Thông báo");
                            Tai(bllTaikhoan.Lay());
                            Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sửa tài khoản thất bại!", "Thông báo");
                        if (Tool.Tennguoidunglay(tbtennguoidung.Text) == false)
                        {
                            eptennguoidung.SetError(tbtennguoidung, "Tên người dùng " + tbtennguoidung.Text + " không khả dụng!");
                        }
                        if (Tool.Emaillay(tbemail.Text) == false)
                        {
                            epemail.SetError(tbemail, "Email không hợp lệ hoặc đã được sử dụng!");
                        }
                        if (Tool.Sdtlay(tbsdt.Text) == false)
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
            }
            else MessageBox.Show("Vui lòng chọn một tài khoản!", "Thông báo");
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            if (taikhoan != null)
            {
                if (MessageBox.Show($"Bạn có muốn xoá tài khoản \"{taikhoan.tennguoidung}\" không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    if (bllTaikhoan.Xoa(taikhoan.tennguoidung))
                    {
                        MessageBox.Show($"Tài khoản \"{taikhoan.tennguoidung}\" đã được xóa.", "Thông báo");
                        Tai(bllTaikhoan.Lay());
                        Clear();
                    }
                    else MessageBox.Show($"Tên tài khoản \"{tbtennguoidung.Text}\" không tồn tại!", "Thông báo");
                }
            }
            else MessageBox.Show("Vui lòng chọn một tài khoản!", "Thông báo");
        }

        private void Btmoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            taikhoan = null;
            tbtennguoidung.Clear();
            tbmk.Clear();
            tbemail.Clear();
            tbsdt.Clear();
            tbtim.Clear();
            epemail.Clear();
            tbdiachi.Clear();
            epmk.Clear();
            epsdt.Clear();
            eptennguoidung.Clear();
        }
        private void Dtbvtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Bll_taikhoan.taikhoanchon  = bllTaikhoan.LayTaikhoanTen(dtbvtaikhoan["Column1", e.RowIndex].Value.ToString());
                taikhoan = Bll_taikhoan.taikhoanchon;
                tbtennguoidung.Text = taikhoan.tennguoidung;
                tbemail.Text = taikhoan.email;
                tbsdt.Text = taikhoan.sdt;
                tbdiachi.Text = taikhoan.diachi;
                if (taikhoan.ngaysinh >= dtpkngaysinh.MinDate && taikhoan.ngaysinh <= dtpkngaysinh.MaxDate)
                {
                    dtpkngaysinh.Value = taikhoan.ngaysinh.GetValueOrDefault();
                }
                else
                {
                    dtpkngaysinh.Value = DateTime.Now;
                }
            }
        }

        private void Tbtennguoidung_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtennguoidung.Text))
            {
                eptennguoidung.Clear();
            }
        }

        private void Tbemail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbemail.Text))
            {
                epemail.Clear();
            }
        }

        private void Tbmk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbmk.Text))
            {
                epmk.Clear();
            }
        }

        private void Tbsdt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbsdt.Text))
            {
                epsdt.Clear();
            }
        }

        private void Tbtennguoidung_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Tennguoidung(tbtennguoidung.Text))
            {
                eptennguoidung.Clear();
            }
            else
            {
                eptennguoidung.SetError(tbtennguoidung, "Tên người dùng " + tbtennguoidung.Text + " không khả dụng!");
            }
        }

        private void Tbemail_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Email(tbemail.Text))
            {
                epemail.Clear();
            }
            else
            {
                epemail.SetError(tbemail, "Email không hợp lệ hoặc đã được sử dụng!");
            }
        }

        private void Tbmk_KeyUp(object sender, KeyEventArgs e)
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

        private void Tbsdt_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Sdt(tbsdt.Text))
            {
                epsdt.Clear();
            }
            else
            {
                epsdt.SetError(tbsdt, "Số điện thoại không hợp lệ hoặc đã được sử dụng!");
            }
        }

        private void Bttim_Click(object sender, EventArgs e)
        {
            Tai(bllTaikhoan.Tim(tbtim.Text));
        }

        private void Uc_taikhoan_Load(object sender, EventArgs e)
        {
            Tai(bllTaikhoan.Lay());
        }

        private void Lbtimkiem_Click(object sender, EventArgs e)
        {
            lbtimkiem.Visible = false;
            tbtim.Focus();
        }

        private void Tbtim_Enter(object sender, EventArgs e)
        {
            lbtimkiem.Visible = false;
        }

        private void Tbtim_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtim.Text))
            {
                lbtimkiem.Visible = true;
            }
            else
            {
                lbtimkiem.Visible = false;
            }
        }

        private void Pbmk_Click(object sender, EventArgs e)
        {
            Tool.Anmatkhau(textBoxes, pictureBoxes);
        }
    }
}