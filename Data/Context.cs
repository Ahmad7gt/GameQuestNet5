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

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            builder.Entity<IdentityRole>().ToTable("Roles");

            builder.Entity<Product>().HasData(new Product
            {
                Name = "Halo: Combat Evolved",
                Description = "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.",
                ImgUrl = "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png",
                Price = 599.0

            });

            builder.Entity<Product>().HasData(new Product
            {
                Name = "Counter-Strike: Global Offensive",
                Description = "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.",
                ImgUrl = "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg",
                Price = 49.0
            });

            builder.Entity<Product>().HasData(new Product
            {
                Name = "Fable",
                Description = "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios",
                ImgUrl = "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg",
                Price = 599.0

            });

            builder.Entity<Product>().HasData(new Product
            {
                Name = "F1 2020",
                Description = "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.",
                ImgUrl = "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg",
                Price = 599.0

            });

        }
    }
}
