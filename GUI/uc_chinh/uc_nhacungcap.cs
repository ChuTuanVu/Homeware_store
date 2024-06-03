using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;
using UTLT;

namespace GUI.uc_chinh
{
    public partial class Uc_nhacungcap : UserControl
    {
        private Bll_nhacungcap bllNhacungcap = new Bll_nhacungcap();
        private nhacungcap nhacungcap = null;

        public Uc_nhacungcap()
        {
            InitializeComponent();
            TuyChinhMsBox.Yes = "Có";
            TuyChinhMsBox.No = "Không";
            TuyChinhMsBox.Bat();
        }

        private void Tai(List<nhacungcap> list)
        {
            dtgvnhacc.DataSource = list.Select(v => new {v.ma, v.ten, v.diachi, v.email, v.sdt}).ToList();
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbten.Text))
            {
                nhacungcap nhacungcaptontai = bllNhacungcap.LayBangTen(tbten.Text);
                if (nhacungcaptontai != null)
                {
                    MessageBox.Show("Nhà cung cấp đã tồn tại!", "Thông báo");
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn thêm nhà cung cấp không?", "Thông báo", MessageBoxButtons.YesNo)
                        == DialogResult.Yes)
                    {
                        nhacungcap nhacungcapthem = new nhacungcap()
                        {
                            ten = tbten.Text,
                            diachi = tbdiachi.Text,
                            email = tbemail.Text,
                            sdt = tbsdt.Text
                        };
                        bllNhacungcap.Them(nhacungcapthem);
                        MessageBox.Show("Thêm nhà cung cấp thành công.", "Thông báo");
                        Tai(bllNhacungcap.Lay());
                        Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Thông báo");
            }
        }

        private void Btsua_Click(object sender, EventArgs e)
        {
            if (nhacungcap != null)
            {
                if (MessageBox.Show("Bạn có muốn sửa nhà cung cấp không?", "Thông báo", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    nhacungcap nhacungcapsua = new nhacungcap()
                    {
                        ma = nhacungcap.ma,
                        ten = tbten.Text,
                        diachi = tbdiachi.Text,
                        email = tbemail.Text,
                        sdt = tbsdt.Text
                    };
                    bllNhacungcap.Sua(nhacungcapsua);
                    MessageBox.Show("Sửa nhà cung cấp thành công.", "Thông báo");
                    Tai(bllNhacungcap.Lay());
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp!", "Thông báo");
            }
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            if (nhacungcap != null)
            {
                if (MessageBox.Show("Bạn có muốn xoá nhà cung cấp này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bllNhacungcap.Xoa(nhacungcap.ma);
                    MessageBox.Show("Xoá nhà cung cấp thành công.", "Thông báo");
                    Tai(bllNhacungcap.Lay());
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp!", "Thông báo");
            }
        }

        private void Btmoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            lbtimkiem.Visible = true;
            tbemail.Clear();
            tbdiachi.Clear();
            tbsdt.Clear();
            tbten.Clear();
            tbtim.Clear();
            nhacungcap = null;
        }

        private void Bttim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtim.Text))
            {
                Tai(bllNhacungcap.Lay());
            }
            else
            {
                Tai(bllNhacungcap.Tim(tbtim.Text));
            }
        }

        private void Dtgvnhacc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Bll_nhacungcap.nhacungcapchon = bllNhacungcap.LayBangMa(Convert.ToInt32(dtgvnhacc["Column1", e.RowIndex].Value));
                nhacungcap = Bll_nhacungcap.nhacungcapchon;
                tbten.Text = nhacungcap.ten;
                tbdiachi.Text = nhacungcap.diachi;
                tbemail.Text = nhacungcap.email;
                tbsdt.Text = nhacungcap.sdt;
            }
        }

        private void Uc_nhacungcap_Load(object sender, EventArgs e)
        {
            Tai(bllNhacungcap.Lay());
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

        private void Tbemail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbemail.Text))
            {
                epemail.Clear();
            }
        }

        private void Tbsdt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbsdt.Text))
            {
                epsdt.Clear();
            }
        }
    }
}