﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlowFB.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FlowFBEntities : DbContext
    {
        public FlowFBEntities()
            : base("name=FlowFBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FFBA_Projects> FFBA_Projects { get; set; }
        public virtual DbSet<FFBA_Purchase> FFBA_Purchase { get; set; }
        public virtual DbSet<FFBA_Purchase_History> FFBA_Purchase_History { get; set; }
        public virtual DbSet<FFBA_Purchase_Proof> FFBA_Purchase_Proof { get; set; }
        public virtual DbSet<FFBA_CostCenter> FFBA_CostCenter { get; set; }
        public virtual DbSet<FFBA_GLCodes> FFBA_GLCodes { get; set; }
        public virtual DbSet<FFBA_TaxCodes> FFBA_TaxCodes { get; set; }
    }
}
