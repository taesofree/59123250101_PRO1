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
    
    public partial class View_Requisition
    {
        public int TId { get; set; }
        public string TName { get; set; }
        public string TeaId { get; set; }
        public Nullable<int> TeaTitle { get; set; }
        public string TeaName { get; set; }
        public string RequisitionID { get; set; }
        public string Re_TeaId { get; set; }
        public int RequestLsitID { get; set; }
        public string RL_RequisitionID { get; set; }
        public string RL_TypeID { get; set; }
        public string TypeID { get; set; }
        public string TY_NameType { get; set; }
        public string RL_CategoryID { get; set; }
        public string TY_CategoryID { get; set; }
        public string CategoryID { get; set; }
        public string CA_NameCategory { get; set; }
        public string RL_NameKP { get; set; }
        public Nullable<int> RL_OnStart { get; set; }
        public Nullable<double> RL_Amount { get; set; }
        public Nullable<double> RL_Price { get; set; }
        public Nullable<int> RL_PlaceID { get; set; }
        public int PlaceID { get; set; }
        public string PL_NamePlace { get; set; }
        public Nullable<System.DateTime> Re_DateRequi { get; set; }
        public string ConvetDateRei { get; set; }
    }
}
