using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;
using UTLT;

namespace GUI.uc_chinh
{
    public partial class Uc_nhanvien : UserControl
    {
        private taikhoan taikhoan = null;
        private nhanvien nhanvien = null;
        private Bll_nhanvien bllNhanvien = new Bll_nhanvien();
        private Bll_taikhoan bllTaikhoan = new Bll_taikhoan();

        public Uc_nhanvien()
        {
            InitializeComponent();
            TuyChinhMsBox.Yes = "Có";
            TuyChinhMsBox.No = "Không";
            TuyChinhMsBox.Bat();
        }

        private void Tai(List<nhanvien> nhanviens)
        {
            dtgvnhanvien.DataSource = nhanviens.Select(v => new {v.ma, v.ten, v.diachi, v.sdt, v.email}).ToList();
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm nhân viên mới không?", "Thông báo", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                if (Tool.Tennguoidung(tbtennguoidung.Text) && Tool.Email(tbemail.Text) &&
                    Tool.Sdt(tbsdt.Text) && tbtennv.Text.Length >= 4)
                {
                    taikhoan taikhoanthem = new taikhoan()
                    {
                        tennguoidung = tbtennguoidung.Text,
                        matkhau = Tool.Sha256(tbtennguoidung.Text + "123"),
                        diachi = tbdiachi.Text,
                        email = tbemail.Text,
                        sdt = tbsdt.Text,
                        quyen = true,
                        ngaydangky = DateTime.Now,
                    };
                    bllTaikhoan.Them(taikhoanthem);

                    nhanvien nhanvienthem = new nhanvien()
                    {
                        ma = bllNhanvien.Mamoi(),
                        ten = tbtennv.Text,
                        diachi = tbdiachi.Text,
                        email = tbemail.Text,
                        sdt = tbsdt.Text,
                        tennguoidung = tbtennguoidung.Text
                    };

                    bllNhanvien.Them(nhanvienthem);
                    MessageBox.Show("Thêm nhân viên thành công. Mật khẩu mặc đinh: " + tbtennguoidung.Text + "123.", " Thông báo");
                    Tai(bllNhanvien.Lay());
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
                    if (Tool.Tennguoidung(tbtennguoidung.Text) == false)
                    {
                        eptennguoidung.SetError(tbtennguoidung, "Tên người dùng " + tbtennguoidung.Text + " không khả dụng!");
                    }
                    if (tbtennv.Text.Length < 4)
                    {
                        eptennv.SetError(tbtennv, "Tên nhân viên " + tbtennv.Text + " không khả dụng!");
                    }
                    if (Tool.Email(tbemail.Text) == false)
                    {
                        epemail.SetError(tbemail, "Email không hợp lệ hoặc đã được sử dụng!");
                    }
                    if (Tool.Sdt(tbsdt.Text) == false)
                    {
                        epsdt.SetError(tbsdt, "Số điện thoại không hợp lệ hoặc đã được sử dụng!");
                    }
                }
            }
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

        private void Btsua_Click(object sender, EventArgs e)
        {
            if (nhanvien != null)
            {
                if (MessageBox.Show($"Bạn có muốn sửa tài khoản \"{nhanvien.tennguoidung}\" không?\nLưu ý: Bạn phải liên hệ với admin để đổi tên người dùng.", "Thông báo",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Tool.Tennguoidunglay(tbtennguoidung.Text) && Tool.Emaillay(tbemail.Text) &&
                            Tool.Sdtlay(tbsdt.Text))
                    {
                        nhanvien nhanviensua = new nhanvien()
                        {
                            ma = nhanvien.ma,
                            ten = tbtennv.Text,
                            email = tbemail.Text,
                            sdt = tbsdt.Text,
                            diachi = tbdiachi.Text
                        };
                        if (bllNhanvien.Sua(nhanviensua))
                        {
                            Tai(bllNhanvien.Lay());
                            MessageBox.Show("Sửa nhân viên thành công.", "Thông báo");
                            Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên thất bại!", "Thông báo");
                        if (Tool.Tennguoidunglay(tbtennguoidung.Text) == false)
                        {
                            eptennguoidung.SetError(tbtennguoidung,
                                "Tên người dùng " + tbtennguoidung.Text + " không khả dụng!");
                        }

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
            else MessageBox.Show("Vui lòng chọn một nhân viên!", "Thông báo");
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            if (nhanvien != null)
            {
                if (MessageBox.Show($"Bạn có muốn xoá nhân viên \"{tbtennv.Text}\"?\nTài khoản của nhân viên này cũng sẽ bị xóa.", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    if (bllNhanvien.Xoa(nhanvien.ma))
                    {
                        MessageBox.Show("Xoá nhân viên thành công.", "Thông báo");
                        Tai(bllNhanvien.Lay());
                        Clear();
                    }
                }
            }
            else MessageBox.Show("Vui lòng chọn một nhân viên!", "Thông báo");
        }

        private void Btmoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Bttim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbtim.Text))
            {
                Tai(bllNhanvien.Tim(tbtim.Text));
            }
            else
            {
                Tai(bllNhanvien.Lay());
            }
        }

        private void Uc_nhanvien_Load(object sender, EventArgs e)
        {
            Tai(bllNhanvien.Lay());
        }

        private void Dtgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            epemail.Clear();
            epmk.Clear();
            epsdt.Clear();
            eptennguoidung.Clear();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Bll_nhanvien.nhanvienchon = bllNhanvien.LayNhanVienMa(Convert.ToInt32(dtgvnhanvien["Column1", e.RowIndex].Value));
                nhanvien = Bll_nhanvien.nhanvienchon;
                taikhoan = bllTaikhoan.LayTaikhoanTen(nhanvien.tennguoidung);
                tbtennv.Text = nhanvien.ten;
                tbemail.Text = nhanvien.email;
                tbsdt.Text = nhanvien.sdt;
                tbdiachi.Text = nhanvien.diachi;
                tbtennguoidung.Text = nhanvien.tennguoidung;
            }
        }

        private void Tbtennv_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbtennv.Text.Length >= 4 || string.IsNullOrEmpty(tbtennv.Text))
            {
                eptennv.Clear();
            }
            else
            {
                eptennv.SetError(tbtennv, "Tên nhân viên " + tbtennv.Text + " không khả dụng!");
            }
        }

        private void Tbtennguoidung_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Tennguoidung(tbtennguoidung.Text) || string.IsNullOrEmpty(tbtennguoidung.Text))
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
            if (Tool.Email(tbemail.Text) || string.IsNullOrEmpty(tbemail.Text))
            {
                epemail.Clear();
            }
            else
            {
                epemail.SetError(tbemail, "Email không hợp lệ hoặc đã được sử dụng!");
            }
        }

        private void Tbsdt_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tool.Sdt(tbsdt.Text) || string.IsNullOrEmpty(tbsdt.Text))
            {
                epsdt.Clear();
            }
            else
            {
                epsdt.SetError(tbsdt, "Số điện thoại không hợp lệ hoặc đã được sử dụng!");
            }
        }

        private void Clear()
        {
            nhanvien = null;
            epemail.Clear();
            eptennv.Clear();
            epmk.Clear();
            epsdt.Clear();
            eptennguoidung.Clear();
            tbemail.Clear();
            tbtennguoidung.Clear();
            tbdiachi.Clear();
            tbsdt.Clear();
            tbtim.Clear();
            tbtennv.Clear();
        }
    }
}
