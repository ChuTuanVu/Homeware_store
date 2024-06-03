using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class Dal_taikhoan
    {
        private da1Entities da1Entities = new da1Entities();

        public List<taikhoan> Lay()
        {
            return da1Entities.taikhoans.ToList();
        }

        public void Them(taikhoan taikhoanthem)
        {
            da1Entities.taikhoans.Add(taikhoanthem);
            da1Entities.SaveChanges();
        }

        public void Sua(taikhoan taikhoansua)
        {
            taikhoan taikhoan = da1Entities.taikhoans.Find(taikhoansua.tennguoidung);
            taikhoan.tennguoidung = taikhoansua.tennguoidung;
            taikhoan.matkhau = taikhoansua.matkhau;
            taikhoan.email = taikhoansua.email;
            taikhoan.sdt = taikhoansua.sdt;
            taikhoan.diachi = taikhoansua.diachi;
            taikhoan.ngaysinh = taikhoansua.ngaysinh;
            da1Entities.SaveChanges();
        }

        public void Xoa(taikhoan taikhoanxoa)
        {
            da1Entities.taikhoans.Remove(taikhoanxoa);
            da1Entities.SaveChanges();
        }
    }
}