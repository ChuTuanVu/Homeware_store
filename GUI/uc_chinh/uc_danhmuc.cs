using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.ucchinh
{
    public partial class Uc_danhmuc : UserControl
    {
        private Bll_danhmuc bllDanhmuc = new Bll_danhmuc();
        private danhmuc danhmuc;

        public Uc_danhmuc()
        {
            InitializeComponent();
            TuyChinhMsBox.Yes = "Có";
            TuyChinhMsBox.No = "Không";
            TuyChinhMsBox.Bat();
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbten.Text))
            {
                List<danhmuc> danhmuctontai = bllDanhmuc.LayBangTen(tbten.Text);
                if (danhmuctontai.Count > 0)
                {
                    MessageBox.Show("Danh mục đã tồn tại!", "Thông báo");
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn thêm danh mục này không?", "Thông báo", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        danhmuc them = new danhmuc()
                        {
                            ten = tbten.Text
                        };
                        bllDanhmuc.Them(them);
                        MessageBox.Show("Thêm danh mục thành công.", "Thông báo");
                        Tai(bllDanhmuc.Lay());
                        Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Thông báo");
            }
        }

        private void Tai(List<danhmuc> list)
        {
            dtgvdanhmuc.DataSource = list.Select(v => new { v.ma, v.ten, soluong = v.sanphams.Count }).ToList();
        }

        private void Btsua_Click(object sender, EventArgs e)
        {
            if (danhmuc != null)
            {
                if (MessageBox.Show("Bạn có muốn sửa danh mục này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    danhmuc danhmucsua = new danhmuc()
                    {
                        ma = danhmuc.ma,
                        ten = tbten.Text
                    };
                    bllDanhmuc.Sua(danhmucsua);
                    Tai(bllDanhmuc.Lay());
                    MessageBox.Show("Sửa danh mục thành công.", "Thông báo");
                    Clear();
                }
            }
            else MessageBox.Show("Vui lòng chọn 1 danh mục!", "Thông báo");
        }

        private void Dtgvdanhmuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Bll_danhmuc.danhmucchon =
                    bllDanhmuc.LayBangDanhMucMa(Convert.ToInt32(dtgvdanhmuc["Column1", e.RowIndex].Value));
                danhmuc = Bll_danhmuc.danhmucchon;
                tbten.Text = dtgvdanhmuc[1, e.RowIndex].Value.ToString();
            }
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            if (danhmuc != null)
            {
                if (MessageBox.Show("Bạn có muốn xoá danh mục này không?\nCác mặt hàng trong danh mục này sẽ bị xóa!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bllDanhmuc.Xoa(danhmuc.ma);
                    MessageBox.Show("Xoá danh mục thành công.", "Thông báo");
                    Tai(bllDanhmuc.Lay());
                    Clear();
                }
            }
            else MessageBox.Show("Vui lòng chọn 1 danh mục!", "Thông báo");
        }

        private void Btmoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            danhmuc = null;
            lbtimkiem.Visible = true;
            tbtim.Clear();
            tbten.Clear();
        }
        private void Uc_danhmuc_Load(object sender, EventArgs e)
        {
            Tai(bllDanhmuc.Lay());
        }

        private void Bttim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbtim.Text))
            {
                Tai(bllDanhmuc.Tim(tbtim.Text));
            }
            else
            {
                Tai(bllDanhmuc.Lay());
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
    }
}