using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class Dal_sanpham
    {
        private da1Entities da1Entities = new da1Entities();

        public List<sanpham> Lay()
        {
            return da1Entities.sanphams.Include("danhmuc1").ToList();
        }

        public void Them(sanpham sanphamthem)
        {
            da1Entities.sanphams.Add(sanphamthem);
            da1Entities.SaveChanges();
        }

        public void Sua(sanpham sanphamsua)
        {
            sanpham sanpham = da1Entities.sanphams.Find(sanphamsua.ma);
            sanpham.ma = sanphamsua.ma;
            sanpham.ten = sanphamsua.ten;
            sanpham.gia = sanphamsua.gia;
            sanpham.anh = sanphamsua.anh;
            sanpham.soluong = sanphamsua.soluong;
            sanpham.danhmuc = sanphamsua.danhmuc;
            da1Entities.SaveChanges();
        }

        public void Xoa(sanpham sanphamxoa)
        {
            da1Entities.sanphams.Remove(sanphamxoa);
            da1Entities.SaveChanges();
        }
    }
}