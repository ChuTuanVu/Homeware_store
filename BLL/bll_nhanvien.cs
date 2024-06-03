using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class Bll_nhanvien
    {
        private Dal_nhanvien dalNhanvien = new Dal_nhanvien();
        public static nhanvien nhanvienchon = null;

        public List<nhanvien> Lay()
        {
            return dalNhanvien.Lay();
        }

        public bool Them(nhanvien nhanvienthem)
        {
            if (Lay().SingleOrDefault(v => v.ma == nhanvienthem.ma) == null)
            {
                dalNhanvien.Them(nhanvienthem);
                return true;
            }
            return false;
        }

        public bool Sua(nhanvien nhanviensua)
        {
            if (LayNhanVienMa(nhanviensua.ma) != null)
            {
                dalNhanvien.Sua(nhanviensua);
                return true;
            }
            return false;
        }

        public bool Xoa(int ma)
        {
            nhanvien nhanvienxoa = LayNhanVienMa(ma);
            if (nhanvienxoa != null)
            {
                dalNhanvien.Xoa(ma);
                return true;
            }
            return false;
        }

        public int Mamoi()
        {
            return Lay().Count() == 0 ? 1 : Lay().Last().ma + 1;
        }

        public nhanvien LayNhanVienTen(string tennguoidung)
        {
            return Lay().SingleOrDefault(v => v.ten == tennguoidung);
        }

        public nhanvien LayNhanVienMa(int ma)
        {
            return Lay().SingleOrDefault(v => v.ma == ma);
        }

        public List<nhanvien> Tim(string dieukien)
        {
            var ketqua = Lay().Where(v => v.ma.ToString() == dieukien || v.ten == dieukien || v.email == dieukien || v.sdt == dieukien).ToList();
            return ketqua;
        }
    }
}