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


           
        


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

        }

     
    }
}
