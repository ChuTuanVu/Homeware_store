using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class Dal_nhacungcap
    {
        private da1Entities da1Entities = new da1Entities();

        public List<nhacungcap> Lay()
        {
            return da1Entities.nhacungcaps.ToList();
        }

        public void Them(nhacungcap nhacungcapthem)
        {
            da1Entities.nhacungcaps.Add(nhacungcapthem);
            da1Entities.SaveChanges();
        }

        public void Sua(nhacungcap nhacungcapsua)
        {
            nhacungcap nhacungcap = da1Entities.nhacungcaps.Find(nhacungcapsua.ma);
            nhacungcap.ten = nhacungcapsua.ten;
            nhacungcap.diachi = nhacungcapsua.diachi;
            nhacungcap.email = nhacungcapsua.email;
            //nhacungcap.sdt = nhacungcapsua.sdt;
            da1Entities.SaveChanges();
        }

        public void Xoa(nhacungcap nhacungcapxoa)
        {
            da1Entities.nhacungcaps.Remove(nhacungcapxoa);
            da1Entities.SaveChanges();
        }
    }
}