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
    
    public partial class project_list
    {
        public int project_id { get; set; }
        public string project_name { get; set; }
        public string project_name_e { get; set; }
        public string stu_id { get; set; }
        public Nullable<int> type_id { get; set; }
        public string TeaId { get; set; }
        public string Data_Post { get; set; }
        public string File { get; set; }
        public string Detail { get; set; }
        public string LinkWeb { get; set; }
        public string LinkVideo { get; set; }
        public Nullable<int> Rate { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual type_project type_project { get; set; }
    }
}
