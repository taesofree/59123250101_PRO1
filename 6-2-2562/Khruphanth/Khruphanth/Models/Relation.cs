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
    
    public partial class Relation
    {
        public int RID { get; set; }
        public Nullable<int> RSubjId { get; set; }
        public Nullable<int> RCId { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
