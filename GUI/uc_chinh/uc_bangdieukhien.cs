using System.Windows.Forms;
using BLL;
using UTLT;

namespace GUI.ucchinh
{
    public partial class uc_bangdieukhien : UserControl
    {
        private Bll_taikhoan bllTaikhoan = new Bll_taikhoan();
        private Bll_nhacungcap bllNhacungcap = new Bll_nhacungcap();
        private Bll_hoadonxuat bllHoadonxuat = new Bll_hoadonxuat();
        private bll_hoadonnhap bllHoadonnhap = new bll_hoadonnhap();

        public uc_bangdieukhien()
        {
            InitializeComponent();
        }

        private void Uc_bangdieukhien_Load(object sender, System.EventArgs e)
        {
            lbttmh.Text = Tool.VND(bllHoadonnhap.TongTienNhap());
            lbttmhhn.Text = Tool.VND(bllHoadonnhap.TongTienNhapHomNay());

            lbttbh.Text = Tool.VND(bllHoadonxuat.TongTienXuat());
            lbttbhhn.Text = Tool.VND(bllHoadonxuat.TongTienXuatHomNay());

            lbtdsbh.Text = Tool.VND((bllHoadonxuat.TongTienXuat() - bllHoadonnhap.TongTienNhap()));
            lbtdsbhhn.Text = Tool.VND((bllHoadonxuat.TongTienXuatHomNay() - bllHoadonnhap.TongTienNhapHomNay()));

            lbtaikhoan.Text = bllTaikhoan.SoLuongTaiKhoan();
            lbncc.Text = bllNhacungcap.SoLuongNhacungcap();
            lbhoadonxuat.Text = bllHoadonxuat.SoLuongHoaDonXuat();
            lbhoadonnhap.Text = bllHoadonnhap.SoLuongHoaDonNhap();
        }

        //private long dsbh()
        //{
        //    long tien = (bllHoadonxuat.TongTienXuat() - bllHoadonnhap.TongTienNhap());
        //    if (tien < 0)
        //    {
        //        return 0;
        //    }
        //    return tien;
        //}
    }
}