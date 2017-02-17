using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCodSeafood.Models
{
    public class SonOfCodSeafoodContext : IdentityDbContext<ApplicationUser>
    {
        public SonOfCodSeafoodContext()
        {
        }
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<Fish> Fish { get; set; }
        public DbSet<FishChoice> FishChoices { get; set; }
        public SonOfCodSeafoodContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SeaOfCodSeafood;integrated security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                        base.OnModelCreating(modelBuilder);
        }
    }
}
