using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class Dal_danhmuc
    {
        private da1Entities da1Entities = new da1Entities();

        public List<danhmuc> Lay()
        {
            return da1Entities.danhmucs.ToList();
        }

        public void Them(danhmuc danhmucthem)
        {
            da1Entities.danhmucs.Add(danhmucthem);
            da1Entities.SaveChanges();
        }

        public void Sua(danhmuc danhmucsua)
        {
            danhmuc danhmuc = da1Entities.danhmucs.Find(danhmucsua.ma);
            danhmuc.ten = danhmucsua.ten;
            da1Entities.SaveChanges();
        }

        public void Xoa(int ma)
        {
            da1Entities.Database.ExecuteSqlCommand("EXEC xoadanhmuc @ma=" + ma);
        }
    }
}