﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAIS_Server_NewGen
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TAISEntities : DbContext
    {
        public TAISEntities()
            : base("name=TAISEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CAPIAccess> CAPIAccesses { get; set; }
        public virtual DbSet<CreditCardDetail> CreditCardDetails { get; set; }
        public virtual DbSet<CreditMonitoring> CreditMonitorings { get; set; }
        public virtual DbSet<NonAirTransaction> NonAirTransactions { get; set; }
        public virtual DbSet<ProductSetting> ProductSettings { get; set; }
        public virtual DbSet<ProfileAgentInfo> ProfileAgentInfoes { get; set; }
        public virtual DbSet<Transmittal> Transmittals { get; set; }
        public virtual DbSet<UserAccess> UserAccesses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vessel> Vessels { get; set; }
    }
}