//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Khruphanth.Inheritance;

namespace Khruphanth.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_RequestList:PIC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_RequestList()
        {
            this.T_Khruphanth = new HashSet<T_Khruphanth>();
        }
    
        public int RequestLsitID { get; set; }
        public string RL_RequisitionID { get; set; }
        public string RL_TypeID { get; set; }
        public string RL_CategoryID { get; set; }
        public string RL_NameKP { get; set; }
        public Nullable<int> RL_OnStart { get; set; }
        public Nullable<double> RL_Amount { get; set; }
        public Nullable<double> RL_Price { get; set; }
        public string RL_DetailKhru { get; set; }
        public string RL_PictureKhru { get; set; }
        public Nullable<int> RL_PlaceID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Khruphanth> T_Khruphanth { get; set; }
        public virtual T_Place T_Place { get; set; }
        public virtual T_Requisition T_Requisition { get; set; }
        public virtual T_Type T_Type { get; set; }
    }
}
