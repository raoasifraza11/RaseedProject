﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Raseedapi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class jobsheetEntities1 : DbContext
    {
        public jobsheetEntities1()
            : base("name=jobsheetEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer_detail_Table> Customer_detail_Table { get; set; }
        public virtual DbSet<jobsheetTable> jobsheetTables { get; set; }
        public virtual DbSet<Product_detail_Table> Product_detail_Table { get; set; }
        public virtual DbSet<reparing_detail_Table> reparing_detail_Table { get; set; }
        public virtual DbSet<userTable> userTables { get; set; }
    }
}
