using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class Bll_danhmuc
    {
        private Dal_danhmuc dalDanhmuc = new Dal_danhmuc();
        public static danhmuc danhmucchon = null;

        public void Them(danhmuc danhmucthem)
        {
            danhmucthem.ma = Ma();
            dalDanhmuc.Them(danhmucthem);
        }

        public bool Xoa(int ma)
        {
            danhmuc danhmucxoa = LayBangDanhMucMa(ma);
            if (danhmucxoa != null)
            {
                dalDanhmuc.Xoa(ma);
                return true;
            }
            return false;
        }


        public List<danhmuc> Lay()
        {
            return dalDanhmuc.Lay();
        }

        public int Ma()
        {
            return Lay().Count() == 0 ? 1 : Lay().Last().ma + 1;
        }

        public danhmuc LayBangDanhMucMa(int ma)
        {
            return Lay().FirstOrDefault(v => v.ma == ma);
        }

        public List<danhmuc> LayBangTen(string ten)
        {
            return Lay().Where(v => v.ten == ten).ToList();
        }

        public bool Sua(danhmuc danhmucsua)
        {
            if (LayBangDanhMucMa(danhmucsua.ma) != null)
            {
                dalDanhmuc.Sua(danhmucsua);
                return true;
            }
            return false;
        }

        public List<danhmuc> Tim(string dieukien)
        {
            var ketqua = Lay().Where(v => v.ma.ToString() == dieukien || v.ten == dieukien).ToList();
            return ketqua;
        }
    }
}