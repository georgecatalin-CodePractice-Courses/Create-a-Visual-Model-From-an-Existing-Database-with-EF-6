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
    
    public partial class tblEmployee_Info
    {
        public int Employee_ID { get; set; }
        public string Employee_FirstName { get; set; }
        public string Employee_LastName { get; set; }
        public int Department_ID { get; set; }
        public Nullable<int> SubDepartment_ID { get; set; }
        public string Employee_Function { get; set; }
        public string Employee_doe { get; set; }
        public string Employee_dob { get; set; }
        public string Employee_phone { get; set; }
        public string Employee_email { get; set; }
        public string Employee_hasERP { get; set; }
        public Nullable<int> Employee_ERPcode { get; set; }
        public string Employee_AppRole { get; set; }
    }
}
