//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPMProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUTHU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTHU()
        {
            this.NODAILies = new HashSet<NODAILY>();
        }
    
        public string MaPhieuThu { get; set; }
        public string MaHoaDon { get; set; }
        public Nullable<System.DateTime> NgayLapPhieu { get; set; }
        public Nullable<double> SoTienDaThu { get; set; }
    
        public virtual HOADON HOADON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NODAILY> NODAILies { get; set; }
    }
}