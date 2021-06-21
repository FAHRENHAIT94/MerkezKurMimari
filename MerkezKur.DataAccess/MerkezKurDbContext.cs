using MerkezKur.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MerkezKur.DataAccess
{
    public class MerkezKurDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("User ID=postgres;Password=yasin6161;Host=localhost;Port=5432;Database=Kurs;Pooling=true;Integrated Security=true;");
        
        }
        public DbSet<Kurlar> Kurlars { get; set; }
        //public MerkezKurDbContext(DbContextOptions<MerkezKurDbContext> options) : base(options)
        //{
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)//dbset Kurlar
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(MerkezKurDbContext).Assembly);
        //}
    }
}
