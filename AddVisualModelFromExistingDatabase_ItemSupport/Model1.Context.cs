﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddVisualModelFromExistingDatabase_ItemSupport
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbItemDataSupportEntities : DbContext
    {
        public dbItemDataSupportEntities()
            : base("name=dbItemDataSupportEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblDepartament> tblDepartaments { get; set; }
        public virtual DbSet<tblInforArtCode> tblInforArtCodes { get; set; }
    }
}
