using EFCorePreRenderIssue.Server.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePreRenderIssue.Server
{
    public class EFCorePreRenderIssueDbContext : DbContext
    {

      
        public EFCorePreRenderIssueDbContext(DbContextOptions<EFCorePreRenderIssueDbContext> options)
            : base(options)
        {
           
        }
     
        public EFCorePreRenderIssueDbContext()
        {
            Database.EnsureCreated();
        }

      
        public DbSet<Product> Products { get; set; }
       
        public DbSet<Unit> Units { get; set; }
       

      

        protected override void OnModelCreating(ModelBuilder builder)
        {

          


            
          
            builder.Entity<Product>()
                .HasOne(p => p.Unit)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.UnitId);


            builder.Entity<Unit>().HasData(
    new Unit() { Id=1,Name="Kg"}, new Unit() { Id = 2, Name = "Ltr" });

            builder.Entity<Product>().HasData(
   new Product() { Id = 1, Name = "Milk" ,UnitId=2}, new Product() { Id = 2, Name = "Rice",UnitId=1 });





        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

        }

     
    }
}
