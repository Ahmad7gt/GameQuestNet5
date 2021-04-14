using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameQuest.Data
{
    public class Context : IdentityDbContext<User>
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet <Content> Contents { get; set; }
       

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            using (var dbs = new DatabaseSeed())
            {
                dbs.SeedDataBase(builder);
            }

        }
    }
}
