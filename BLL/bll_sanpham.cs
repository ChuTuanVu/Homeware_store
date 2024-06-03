using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class Bll_sanpham
    {
        private Dal_sanpham dalSanpham = new Dal_sanpham();
        public static sanpham sanphamchon = null;

        public List<sanpham> Lay()
        {
            return dalSanpham.Lay();
        }

        public void Them(sanpham sanphamthem)
        {
            dalSanpham.Them(sanphamthem);
        }

        public bool Sua(sanpham sanphamsua)
        {
            if (LaySanphamMa(sanphamsua.ma) != null)
            {
                dalSanpham.Sua(sanphamsua);
                return true;
            }
            return false;
        }

        public bool Xoa(int ma)
        {
            sanpham sanphamxoa = LaySanphamMa(ma);
            if (sanphamxoa != null)
            {
                dalSanpham.Xoa(sanphamxoa);
                return true;
            }
            return false;
        }

        public sanpham LaySanphamMa(int ma)
        {
            return Lay().SingleOrDefault(v => v.ma == ma);
        }

        public sanpham LaySanphamTen(string ten)
        {
            return Lay().SingleOrDefault(v => v.ten == ten);
        }

        public List<sanpham> Tim(string dieukien)
        {
            if (!string.IsNullOrEmpty(dieukien))
            {
                var ketqua = Lay().Where(v => v.ten == dieukien || v.ma.ToString() == dieukien).ToList();
                return ketqua;
            }
            return dalSanpham.Lay();
        }

        public int Ma()
        {
            return Lay().Count() == 0 ? 1 : Lay().Last().ma + 1;
        }
    }
}