using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;
using UTLT;

namespace GUI.uc_chinh
{
    public partial class Uc_sanpham : UserControl
    {
        private taikhoan taikhoan;
        private sanpham sanpham;
        private int soluongmua = 0;
        private Bll_sanpham bllSanpham = new Bll_sanpham();
        private Bll_danhmuc bllDanhmucsanpham = new Bll_danhmuc();
        private Bll_giohang bllGiohang = new Bll_giohang();
        private Bll_nhanvien bllNhanvien = new Bll_nhanvien();
        private Bll_hoadonxuat bllHoadonxuat = new Bll_hoadonxuat();
        private Bll_nhacungcap bllNhacungcap = new Bll_nhacungcap();
        private bll_hoadonnhap bllHoadonnhap = new bll_hoadonnhap();
        private byte[] bytes;

        public Uc_sanpham()
        {
            InitializeComponent();
            TuyChinhMsBox.Yes = "Có";
            TuyChinhMsBox.No = "Không";
            TuyChinhMsBox.Bat();
        }

        private void Tai(List<sanpham> list)
        {
            dtgvmua.DataSource = list.Where(v => v.danhmuc1 != null).Select(v => new { v.anh, v.ma, v.ten, danhmuc = v.danhmuc1.ten, v.soluong, gia = Tool.VND((long)v.gia) }).ToList();
        }

        private void Tai2(List<giohang> list)
        {
            dtgvgh.DataSource = list.Where(v  => v.tennguoidung == taikhoan.tennguoidung).Select(v => new { v.anh, v.masp, v.tensp, v.soluong, gia = Tool.VND((long)v.gia) }).ToList();
        }

        private void Uc_sanpham_Load(object sender, EventArgs e)
        {
            taikhoan = Bll_taikhoan.taikhoanchon;
            Tai(bllSanpham.Lay());
            cbbdanhmuc.DataSource = bllDanhmucsanpham.Lay();
            cbbdanhmuc.DisplayMember = "ten";
            cbbdanhmuc.ValueMember = "ma";

            cbbghnv.DataSource = bllNhanvien.Lay();
            cbbghnv.DisplayMember = "ten";
            cbbghnv.ValueMember = "ma";

            cbbncc.DataSource = bllNhacungcap.Lay();
            cbbncc.DisplayMember = "ten";
            cbbncc.ValueMember = "ma";
            
            cbbmhnv.DataSource = bllNhanvien.Lay();
            cbbmhnv.DisplayMember = "ten";
            cbbmhnv.ValueMember = "ma";
        }

        private void Btthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbten.Text) || string.IsNullOrEmpty(cbbncc.Text) || string.IsNullOrEmpty(cbbdanhmuc.Text) || string.IsNullOrEmpty(tbgia.Text) || string.IsNullOrEmpty(tbsoluong.Text) || string.IsNullOrEmpty(cbbmhnv.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                if (bllSanpham.LaySanphamTen(tbten.Text) != null)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại!", "Thông báo");
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn thêm sản phẩm mới không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int ma = bllSanpham.Ma();
                        sanpham sanphamthem = new sanpham()
                        {
                            ma = ma,
                            ten = tbten.Text,
                            gia = Convert.ToDouble(tbgia.Text),
                            anh = bytes,
                            soluong = Convert.ToInt32(tbsoluong.Text),
                            danhmuc = Convert.ToInt32(cbbdanhmuc.SelectedValue),
                            nhacungcap = Convert.ToInt32(cbbncc.SelectedValue)
                        };
                        bllSanpham.Them(sanphamthem);

                        hoadonnhap hoadonnhapthem = new hoadonnhap()
                        {
                            masp = ma,
                            manv = Convert.ToInt32(cbbghnv.SelectedValue),
                            soluong = Convert.ToInt32(tbsoluong.Text),
                            gia = Convert.ToDouble(tbgia.Text),
                            tongtien = Convert.ToInt32(tbsoluong.Text) * Convert.ToDouble(tbgia.Text),
                            mancc = Convert.ToInt32(cbbncc.SelectedValue),
                            ngaynhap = DateTime.Now
                        };
                        bllHoadonnhap.Them(hoadonnhapthem);
                        MessageBox.Show("Thêm sản phẩm thành công.", "Thông báo");
                        Tai(bllSanpham.Lay());
                        Clear();
                    }
                }
            }
        }

        private void Btsua_Click(object sender, EventArgs e)
        {
            if (sanpham == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm!", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa sản phẩn này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sanpham sanphamsua = new sanpham()
                    {
                        ma = sanpham.ma,
                        ten = tbten.Text,
                        gia = Convert.ToDouble(tbgia.Text),
                        anh = bytes,
                        soluong = Convert.ToInt32(tbsoluong.Text),
                        danhmuc = Convert.ToInt32(cbbdanhmuc.SelectedValue),
                        nhacungcap = Convert.ToInt32(cbbncc.SelectedValue)
                    };
                    if (bllSanpham.Sua(sanphamsua))
                    {
                        MessageBox.Show("Sửa sản phẩm thành công.", "Thông báo");
                        Tai(bllSanpham.Lay());
                        Clear();
                    }
                }
            }
        }

        private void Btxoa_Click(object sender, EventArgs e)
        {
            if (sanpham == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm!", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bllSanpham.Xoa(sanpham.ma))
                    {
                        Tai(bllSanpham.Lay());
                        MessageBox.Show("Xoá sản phẩm thành công!");
                        Clear();
                    }
                }
            }
        }

        private void Dtgvmua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Bll_sanpham.sanphamchon = bllSanpham.LaySanphamMa(Convert.ToInt32(dtgvmua["Column2", e.RowIndex].Value));
                sanpham = Bll_sanpham.sanphamchon;
                tbten.Text = sanpham.ten;
                tbgia.Text = sanpham.gia.ToString();
                tbsoluong.Text = sanpham.soluong.ToString();
                cbbdanhmuc.SelectedValue = sanpham.danhmuc;
                bytes = sanpham.anh;
                cbbncc.SelectedValue = sanpham.nhacungcap;
            }
        }

        private void Btthemanh_Click(object sender, EventArgs e)
        {
            bytes = Tool.PtoB(lbanh);
        }

        private void Bttim_Click(object sender, EventArgs e)
        {
            Tai(bllSanpham.Tim(tbtim.Text));
        }

        private void Btmoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            epgia.Clear();
            epsoluong.Clear();
            lbanh.Text = "Không tệp nào được chọn";
            tbten.Clear();
            tbgia.Clear();
            tbsoluong.Clear();
            tbtim.Clear();
            lbtimkiem.Visible = true;
            sanpham = null;
        }

        private void Nudsoluong_ValueChanged(object sender, EventArgs e)
        {
            if (nudsoluong.Value > soluongmua)
            {
                nudsoluong.Value = soluongmua;
            }
            else
            {
                if (sanpham != null)
                {
                    giohang giohangsua = new giohang()
                    {
                        masp = sanpham.ma,
                        soluong = Convert.ToInt32(nudsoluong.Value),
                    };
                    if (bllGiohang.Sua(giohangsua))
                    {
                        Tai2(bllGiohang.Lay());
                        TongTien();
                        btghmua.Text = bllGiohang.SoLuongSanPham().ToString();
                    }
                }
            }
        }

        private void Btxoagiohang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Loại bỏ sản phẩm này khỏi giỏ hàng?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bllGiohang.Xoa(sanpham.ma))
                {
                    Tai2(bllGiohang.Lay());
                    MessageBox.Show("Loại bỏ sản phẩm thành công.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm!", "Thông báo");
                }
            }
        }

        private void Dtgvgh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Bll_sanpham.sanphamchon = bllSanpham.LaySanphamMa(Convert.ToInt32(dtgvgh["Column8", e.RowIndex].Value));
                sanpham = Bll_sanpham.sanphamchon;
                soluongmua = sanpham.soluong.Value;
                nudsoluong.Value = Convert.ToInt32(dtgvgh["Column11", e.RowIndex].Value);
                lbghcosan.Text = sanpham.soluong.Value + " sản phẩm có sẵn";
            }
        }

        private void Tcsanpham_Click(object sender, EventArgs e)
        {
            Tai2(bllGiohang.Lay());
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

        private void Tbsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                epsoluong.SetError(tbsoluong, "Chỉ được nhập số.");
                e.Handled = true;
            }
            else
            {
                epsoluong.Clear();
            }
        }

        private void Dtgvtt_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex == dtgvgh.Columns["Column11"].Index)
            {
                TongTien();
            }
        }

        private void TongTien()
        {
            long tongtien = 0;
            foreach (DataGridViewRow dataGridViewRow in dtgvgh.Rows)
            {
                if (dataGridViewRow.Cells["Column10"].Value != null && dataGridViewRow.Cells["Column11"].Value != null)
                {
                    long gia = Tool.DNV((dataGridViewRow.Cells["Column10"].Value.ToString()));
                    int soluong = Convert.ToInt32(dataGridViewRow.Cells["Column11"].Value);
                    tongtien += gia * soluong;
                }
            }
            tbghtt.Text = Tool.VND(tongtien);
        }

        private void Btghmua_Click(object sender, EventArgs e)
        {
            if (dtgvgh.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn mua các sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool soluong = true;
                    foreach (DataGridViewRow dataGridViewRow in dtgvgh.Rows)
                    {
                        if (!dataGridViewRow.IsNewRow && Convert.ToInt32(dataGridViewRow.Cells["Column11"].Value) != 0)
                        {
                            soluong = false;
                            break;
                        }
                    }
                    if (soluong)
                    {
                        MessageBox.Show("Thêm số lượng sản phẩm cần mua!", "Thông báo");
                    }
                    else
                    {
                        foreach (DataGridViewRow dataGridViewRow in dtgvgh.Rows)
                        {
                            if (!dataGridViewRow.IsNewRow && Convert.ToInt32(dataGridViewRow.Cells["Column11"].Value) != 0)
                            {
                                sanpham sanphamsua = new sanpham()
                                {
                                    ma = sanpham.ma,
                                    ten = sanpham.ten,
                                    gia = sanpham.gia,
                                    anh = sanpham.anh,
                                    soluong = sanpham.soluong - Convert.ToInt32(nudsoluong.Value),
                                    danhmuc = sanpham.danhmuc
                                };
                                bllSanpham.Sua(sanphamsua);

                                hoadonxuat hoadonxuatthem = new hoadonxuat()
                                {
                                    masp = Convert.ToInt32(dataGridViewRow.Cells["Column8"].Value),
                                    manv = bllNhanvien.LayNhanVienTen(cbbghnv.Text).ma,
                                    soluong = Convert.ToInt32(dataGridViewRow.Cells["Column11"].Value),
                                    gia = Tool.DNV(dataGridViewRow.Cells["Column10"].Value.ToString()),
                                    tongtien = Convert.ToInt32(dataGridViewRow.Cells["Column11"].Value) * Tool.DNV(dataGridViewRow.Cells["Column10"].Value.ToString()),
                                    ngayban = DateTime.Now,
                                    tennguoidung = Bll_taikhoan.taikhoanchon.tennguoidung,
                                };
                                bllHoadonxuat.Them(hoadonxuatthem);
                            }
                        }
                        MessageBox.Show("Mua sản phẩm thành công.\nBạn có thể chuyển đến trang hóa đơn để xem chi tiết.", "Thông báo");
                    }
                }
            }
        }

        private void Btgiohang_Click(object sender, EventArgs e)
        {
            if (sanpham != null)
            {
                List<giohang> gGiohangs = bllGiohang.LayDanhSachGioHangMa(sanpham.ma);
                bool trung = gGiohangs.Any(v => v.tensp == sanpham.ten);
                if (trung)
                {
                    MessageBox.Show("Sản phẩm đã có trong giỏ hàng!", "Thông báo");
                }
                else
                {
                    giohang giohangthem = new giohang()
                    {
                        tennguoidung = taikhoan.tennguoidung,
                        anh = sanpham.anh,
                        tensp = sanpham.ten,
                        masp = sanpham.ma,
                        soluong = 0,
                        gia = (sanpham.gia + sanpham.gia * 0.25)
                    };
                    bllGiohang.Them(giohangthem);
                    MessageBox.Show("Thêm sản phẩm vào giỏ hàng thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm!", "Thông báo");
            }
        }

        private void Tbgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                epgia.SetError(tbgia, "Chỉ được nhập số.");
                e.Handled = true;
            }
            else
            {
                epgia.Clear();
            }
        }
    }
}