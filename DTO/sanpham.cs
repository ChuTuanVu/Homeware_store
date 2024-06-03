namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sanpham()
        {
            this.hoadonxuats = new HashSet<hoadonxuat>();
        }
    
        public int ma { get; set; }
        public string ten { get; set; }
        public double gia { get; set; }
        public byte[] anh { get; set; }
        public Nullable<int> soluong { get; set; }
        public int danhmuc { get; set; }
        public Nullable<int> nhacungcap { get; set; }
    
        public virtual danhmuc danhmuc1 { get; set; }
        public virtual giohang giohang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoadonxuat> hoadonxuats { get; set; }
        public virtual nhacungcap nhacungcap1 { get; set; }
    }
}