using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UpiWallet.Model
{
    internal class UpidbContext :DbContext
    {
        public DbSet<UpiModel> tbl_Upi { get; set; }

        public DbSet<TransactionModel> tbl_Transaaction { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseSqlServer("Server=LAPTOP-T663RI27;Database=UpiWallet;integrated security=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionModel>()
            .Property(p => p.TransactionId)
            .ValueGeneratedOnAdd();
        }
    }
}
