//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddVisualModelFromExistingDatabase_DashboardSP
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblError
    {
        public int Employee_ID { get; set; }
        public int Error_ID { get; set; }
        public int Count_NrErrors { get; set; }
        public int Year { get; set; }
        public int Week_Nr { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> Error_Date { get; set; }
        public Nullable<int> Error_AddedBy { get; set; }
        public int Error_PK { get; set; }
    }
}