//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcOtel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblKullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblKullanici()
        {
            this.TblRezs = new HashSet<TblRez>();
        }
    
        public int KId { get; set; }
        public string KAd { get; set; }
        public string KSoyad { get; set; }
        public Nullable<short> KYas { get; set; }
        public string KTcNo { get; set; }
        public string KSifre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblRez> TblRezs { get; set; }
    }
}