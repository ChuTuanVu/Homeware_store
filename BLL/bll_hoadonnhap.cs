using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class bll_hoadonnhap
    {
        private dal_hoadonnhap dalHoadonnhap = new dal_hoadonnhap();

        public List<hoadonnhap> Lay()
        {
            return dalHoadonnhap.Lay();
        }

        public bool Them(hoadonnhap hoadonnhapthem)
        {
            if (Lay().SingleOrDefault(v => v.masp == hoadonnhapthem.masp) == null)
            {
                hoadonnhapthem.ma = Ma();
                dalHoadonnhap.Them(hoadonnhapthem);
                return true;
            }
            return false;
        }

        public hoadonnhap LayHoaDonNhapMa(int ma)
        {
            return Lay().SingleOrDefault(v => v.ma == ma);
        }

        public string SoLuongHoaDonNhap()
        {
            return Lay().Count().ToString();
        }

        public long TongTienNhap()
        {
            return Convert.ToInt64(Lay().Sum(v => v.tongtien));
        }

        public long TongTienNhapHomNay()
        {
            return Convert.ToInt64(Lay().Where(v => v.ngaynhap.Value.ToShortDateString() == DateTime.Now.ToShortDateString()).Sum(v => v.tongtien));
        }

        public int Ma()
        {
            return Lay().Count() == 0 ? 1 : Lay().Last().ma + 1;
        }
    }
}