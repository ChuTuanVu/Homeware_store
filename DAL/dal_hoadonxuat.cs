using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class dal_hoadonxuat
    {
        private da1Entities da1Entities = new da1Entities();

        public List<hoadonxuat> Lay()
        {
            return da1Entities.hoadonxuats.ToList();
        }

        public void Them(hoadonxuat hoadonxuatthem)
        {
            da1Entities.hoadonxuats.Add(hoadonxuatthem);
            da1Entities.SaveChanges();
        }
    }
}