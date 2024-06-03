using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace BLL
{
    public class Bll_hoadonxuat
    {
        private dal_hoadonxuat dalHoadonxuat = new dal_hoadonxuat();

        public List<hoadonxuat> Lay()
        {
            return dalHoadonxuat.Lay();
        }

        public bool Them(hoadonxuat hoadonxuatthem)
        {
            if (Lay().SingleOrDefault(v => v.ma == hoadonxuatthem.ma) == null)
            {
                hoadonxuatthem.ma = Ma();
                dalHoadonxuat.Them(hoadonxuatthem);
                return true;
            }
            return false;
        }

        public string SoLuongHoaDonXuat()
        {
            return Lay().Count().ToString();
        }

        public long TongTienXuat()
        {
            return Convert.ToInt64(Lay().Sum(v => v.tongtien));
        }

        public long TongTienXuatHomNay()
        {
            return Convert.ToInt64(Lay().Where(v => v.ngayban.Value.ToShortDateString() == DateTime.Now.ToShortDateString()).Sum(v => v.tongtien));
        }

        public int Ma()
        {
            return Lay().Count() == 0 ? 1 : Lay().Last().ma + 1;
        }
    }
}