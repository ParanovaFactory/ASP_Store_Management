﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreManagement.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Categories> Tbl_Categories { get; set; }
        public virtual DbSet<Tbl_Customers> Tbl_Customers { get; set; }
        public virtual DbSet<Tbl_Employees> Tbl_Employees { get; set; }
        public virtual DbSet<Tbl_Products> Tbl_Products { get; set; }
        public virtual DbSet<Tbl_Sales> Tbl_Sales { get; set; }
        public virtual DbSet<Tbl_Admins> Tbl_Admins { get; set; }
    }
}