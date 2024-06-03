using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class Bll_giohang
    {
        private dal_giohang dalGiohang = new dal_giohang();

        public List<giohang> Lay()
        {
            return dalGiohang.Lay();
        }

        public void Them(giohang giohangthem)
        {
            dalGiohang.Them(giohangthem);
        }

        public bool Sua(giohang giohangsua)
        {
            if (LayGioHangMa(giohangsua.masp) != null)
            {
                dalGiohang.Sua(giohangsua);
                return true;
            }
            return false;
        }

        public bool Xoa(int ma)
        {
            giohang giohangxoa = LayGioHangMa(ma);
            if (giohangxoa != null)
            {
                dalGiohang.Xoa(giohangxoa);
                return true;
            }
            return false;
        }

        public giohang LayGioHangMa(int ma)
        {
            return Lay().SingleOrDefault(v => v.masp == ma);
        }

        public List<giohang> LayDanhSachGioHangMa(int ma)
        {
            return Lay().Where(v => v.masp == ma).ToList();
        }

        public int SoLuongSanPham()
        {
            return Lay().Count(v => v.soluong > 0);
        }
    }
}