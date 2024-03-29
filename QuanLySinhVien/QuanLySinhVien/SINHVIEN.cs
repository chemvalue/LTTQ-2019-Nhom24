//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySinhVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            this.NGUOITHANs = new HashSet<NGUOITHAN>();
        }
    
        public string MSV { get; set; }
        public string HoTenSV { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string DanToc { get; set; }
        public string NoiSinh { get; set; }
        public string QueQuan { get; set; }
        public string MaLop { get; set; }
        public string TenPhong { get; set; }
        public string MaNGT { get; set; }
        public string MaDT { get; set; }
    
        public virtual LOAIHINHDT LOAIHINHDT { get; set; }
        public virtual LOP LOP { get; set; }
        public virtual NGOAITRU NGOAITRU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOITHAN> NGUOITHANs { get; set; }
        public virtual NOITRU NOITRU { get; set; }
    }
}
