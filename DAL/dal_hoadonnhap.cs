using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class dal_hoadonnhap
    {
        private da1Entities da1Entities = new da1Entities();

        public List<hoadonnhap> Lay()
        {
            return da1Entities.hoadonnhaps.ToList();
        }

        public void Them(hoadonnhap hoadonnhapthem)
        {
            da1Entities.hoadonnhaps.Add(hoadonnhapthem);
            da1Entities.SaveChanges();
        }

        public void Sua(hoadonnhap hoadonnhapsua)
        {
            hoadonnhap hoadonnhap = da1Entities.hoadonnhaps.Find(hoadonnhapsua.ma);
            hoadonnhap.manv = hoadonnhapsua.manv;
            hoadonnhap.mancc = hoadonnhapsua.mancc;
            hoadonnhap.ngaynhap = hoadonnhapsua.ngaynhap;
            hoadonnhap.tongtien = hoadonnhapsua.tongtien;
            da1Entities.SaveChanges();
        }

        public void Xoa(hoadonnhap hoadonnhapxoa)
        {
            da1Entities.hoadonnhaps.Remove(hoadonnhapxoa);
            da1Entities.SaveChanges();
        }
    }
}