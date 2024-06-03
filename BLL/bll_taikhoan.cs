using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class Bll_taikhoan
    {
        private Dal_taikhoan dalTaikhoan = new Dal_taikhoan();
        public static taikhoan taikhoanchon = null;

        public List<taikhoan> Lay()
        {
            return dalTaikhoan.Lay();
        }

        public bool Them(taikhoan taikhoanthem)
        {
            if (Lay().SingleOrDefault(v => v.tennguoidung == taikhoanthem.tennguoidung) == null)
            {
                dalTaikhoan.Them(taikhoanthem);
                return true;
            }
            return false;
        }

        public bool Sua(taikhoan taikhoansua)
        {
            if (LayTaikhoanTen(taikhoansua.tennguoidung) != null)
            {
                dalTaikhoan.Sua(taikhoansua);
                return true;
            }
            return false;
        }

        public bool Xoa(string tennguoidung)
        {
            taikhoan taikhoanxoa = LayTaikhoanTen(tennguoidung);
            if (taikhoanxoa != null)
            {
                dalTaikhoan.Xoa(taikhoanxoa);
                return true;
            }
            return false;
        }

        public taikhoan LayTaikhoanTen(string tennguoidung)
        {
            return Lay().SingleOrDefault(v => v.tennguoidung == tennguoidung);
        }

        public taikhoan LayTaikhoanTenMat(string tennguoidung, string matkhau)
        {
            return Lay().SingleOrDefault(v => v.tennguoidung == tennguoidung && v.matkhau == matkhau);
        }

        public string LayTennguoidung(string email, string sdt)
        {
            if (Lay().SingleOrDefault(v => v.email == email && v.sdt == sdt) == null)
            {
                return null;
            }
            return Lay().SingleOrDefault(v => v.email == email && v.sdt == sdt).tennguoidung;
        }

        public bool EmailTrung(string email)
        {
            return Lay().All(v => v.email != email);
        }

        public bool SdtTrung(string sdt)
        {
            return Lay().All(v => v.sdt != sdt);
        }

        public bool TennguoidungTrung(string tennguoidung)
        {
            return Lay().All(v => v.tennguoidung != tennguoidung);
        }

        public List<taikhoan> Tim(string dieukien)
        {
            if (!string.IsNullOrEmpty(dieukien))
            {
                var ketqua = Lay().Where(v => v.tennguoidung == dieukien || v.email == dieukien || v.sdt == dieukien).ToList();
                return ketqua;
            }
            return dalTaikhoan.Lay();
        }

        public string LayTaiKhoanEmailhSdtTen(string emailhsdt, string tennguoidung)
        {
            var taikhoan = Lay().SingleOrDefault(v => (v.email == emailhsdt && v.tennguoidung == tennguoidung) ||
                                                      (v.sdt == emailhsdt && v.tennguoidung == tennguoidung));

            if (taikhoan != null)
            {
                return taikhoan.tennguoidung;
            }
            return null;
        }

        public string SoLuongTaiKhoan()
        {
            return Lay().Where(v => v.quyen == false).Count().ToString();
        }
    }
}