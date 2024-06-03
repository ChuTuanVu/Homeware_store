using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class Dal_nhanvien
    {
        private da1Entities da1Entities = new da1Entities();

        public List<nhanvien> Lay()
        {
            return da1Entities.nhanviens.ToList();
        }

        public void Them(nhanvien nhanvienthem)
        {
            da1Entities.nhanviens.Add(nhanvienthem);
            da1Entities.SaveChanges();
        }

        public void Sua(nhanvien nhanviensua)
        {
            nhanvien nhanvien = da1Entities.nhanviens.Find(nhanviensua.ma);
            nhanvien.ma = nhanviensua.ma;
            nhanvien.ten = nhanviensua.ten;
            nhanvien.diachi = nhanviensua.diachi;
            nhanvien.sdt = nhanviensua.sdt;
            nhanvien.email = nhanviensua.email;
            da1Entities.SaveChanges();
        }

        public void Xoa(int ma)
        {
            da1Entities.Database.ExecuteSqlCommand("EXEC xoanhanvien @ma=" + ma);
        }
    }
}