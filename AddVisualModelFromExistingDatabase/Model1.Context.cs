﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddVisualModelFromExistingDatabase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbRapoarte_ViziteClientiEntities : DbContext
    {
        public dbRapoarte_ViziteClientiEntities()
            : base("name=dbRapoarte_ViziteClientiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_BusinessPartner> tbl_BusinessPartner { get; set; }
        public virtual DbSet<tbl_Contacts_BusinessPartner> tbl_Contacts_BusinessPartner { get; set; }
        public virtual DbSet<tbl_ParticipantsLacon> tbl_ParticipantsLacon { get; set; }
        public virtual DbSet<tbl_SalesReport> tbl_SalesReport { get; set; }
        public virtual DbSet<autonumberid> autonumberids { get; set; }
        public virtual DbSet<tbl_CBP_Attributes> tbl_CBP_Attributes { get; set; }
        public virtual DbSet<tbl_CBP_Categories> tbl_CBP_Categories { get; set; }
    }
}