//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Khruphanth.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Khruphanth
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Khruphanth()
        {
            this.T_DistributorList = new HashSet<T_DistributorList>();
        }
    
        public string KhruphanthID { get; set; }
        public Nullable<int> Kh_RequestLsitID { get; set; }
        public byte[] Kh_QR_CODE { get; set; }
        public Nullable<int> Kh_PlaceID { get; set; }
        public Nullable<int> Kh_StatusID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_DistributorList> T_DistributorList { get; set; }
        public virtual T_RequestList T_RequestList { get; set; }
        public virtual T_Status T_Status { get; set; }
    }
}
