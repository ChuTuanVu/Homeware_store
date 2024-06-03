using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class dal_giohang
    {
        private da1Entities da1Entities = new da1Entities();

        public List<giohang> Lay()
        {
            return da1Entities.giohangs.ToList();
        }

        public void Them(giohang giohangthem)
        {
            da1Entities.giohangs.Add(giohangthem);
            da1Entities.SaveChanges();
        }

        public void Sua(giohang giohangsua)
        {
            giohang giohang = da1Entities.giohangs.Find(giohangsua.masp);
            giohang.soluong = giohangsua.soluong;
            da1Entities.SaveChanges();
        }

        public void Xoa(giohang giohangxoa)
        {
            da1Entities.giohangs.Remove(giohangxoa);
            da1Entities.SaveChanges();
        }
    }
}