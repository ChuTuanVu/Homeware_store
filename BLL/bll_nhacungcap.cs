using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class Bll_nhacungcap
    {
        private Dal_nhacungcap dalNhacungcap = new Dal_nhacungcap();
        public static nhacungcap nhacungcapchon = null;
        public List<nhacungcap> Lay()
        {
            return dalNhacungcap.Lay();
        }

        public void Them(nhacungcap nhacungcapthem)
        {
            nhacungcapthem.ma = Ma();
            dalNhacungcap.Them(nhacungcapthem);
        }

        public bool Sua(nhacungcap nhacungcapsua)
        {
            if (LayBangMa(nhacungcapsua.ma) != null)
            {
                dalNhacungcap.Sua(nhacungcapsua);
                return true;
            }
            return false;
        }

        public bool Xoa(int ma)
        {
            nhacungcap nhacungcapxoa = LayBangMa(ma);
            if (nhacungcapxoa != null)
            {
                dalNhacungcap.Xoa(nhacungcapxoa);
                return true;
            }
            return false;
        }

        public nhacungcap LayBangMa(int ma)
        {
            return dalNhacungcap.Lay().FirstOrDefault(v => v.ma == ma);
        }

        public nhacungcap LayBangTen(string ten)
        {
            return dalNhacungcap.Lay().FirstOrDefault(v => v.ten == ten);
        }

        public int Ma()
        {
            return Lay().Count() == 0 ? 1 : Lay().Last().ma + 1;
        }


        public List<nhacungcap> Tim(string dieukien)
        {
            var ketqua = Lay().Where(v => v.ten == dieukien || v.email == dieukien || v.sdt == dieukien || v.ma.ToString() == dieukien).ToList();
            return ketqua;
        }

        public string SoLuongNhacungcap()
        {
            return Lay().Count().ToString();
        }
    }
}