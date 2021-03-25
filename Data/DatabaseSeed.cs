using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameQuest.Data
{
    public class DatabaseSeed : IDisposable
    {
        public void SeedDataBase(ModelBuilder builder)
        {
            
            // Configure identity server
            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            builder.Entity<IdentityRole>().ToTable("Roles");


            builder.Entity<IdentityRole>().HasData(new IdentityRole 
            { 
                Id = Guid.NewGuid().ToString(),
                Name = "Admin",
                NormalizedName = "ADMIN"

            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Customer",
                NormalizedName = "CUSTOMER"

            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "User",
                NormalizedName = "USER"

            });


            // Create Main Categories
            MainCategory nintendo = new MainCategory("Nintendo", "");
            MainCategory playstation = new MainCategory("Playstation", "");
            MainCategory xbox = new MainCategory("Xbox", "");
            MainCategory pc = new MainCategory("PC", "");

            builder.Entity<MainCategory>().HasData(nintendo);
            builder.Entity<MainCategory>().HasData(playstation);
            builder.Entity<MainCategory>().HasData(xbox);
            builder.Entity<MainCategory>().HasData(pc);


            // Create Sub categoiries
            SubCategory games = new SubCategory("Games", "");
            SubCategory accesories = new SubCategory("Accesories", "");
            SubCategory controllers = new SubCategory("Controllers", "");
            SubCategory console = new SubCategory("Console", "");

            builder.Entity<SubCategory>().HasData(games);
            builder.Entity<SubCategory>().HasData(accesories);
            builder.Entity<SubCategory>().HasData(controllers);
            builder.Entity<SubCategory>().HasData(console);


            // Create Categories
            Category nintentoGames = new Category(nintendo, games);
            Category playstationGames = new Category(playstation, games);
            Category xboxGames = new Category(xbox, games);
            Category pcGames = new Category(pc, games);
            Category nintentoControllers = new Category(nintendo, controllers);
            Category playstationControllers = new Category(playstation, controllers);
            Category xboxAccesories = new Category(xbox, accesories);
            Category pcAccesories = new Category(pc, accesories);

            builder.Entity<Category>().HasData(nintentoGames);
            builder.Entity<Category>().HasData(playstationGames);
            builder.Entity<Category>().HasData(xboxGames);
            builder.Entity<Category>().HasData(pcGames);
            builder.Entity<Category>().HasData(nintentoControllers);
            builder.Entity<Category>().HasData(playstationControllers);
            builder.Entity<Category>().HasData(xboxAccesories);
            builder.Entity<Category>().HasData(pcAccesories);



            // Create content pages
            builder.Entity<Content>().HasData(new Content("About", ToolBox.ContentBodyDemo));
            builder.Entity<Content>().HasData(new Content("FAQ", ToolBox.ContentBodyDemo));
            builder.Entity<Content>().HasData(new Content("Contact", ToolBox.ContentBodyDemo, "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg"));

            // Create products
            builder.Entity<Product>().HasData(new Product
            {
                Name = "Halo: Combat Evolved",
                Description = "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.",
                ImgUrl = "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png",
                Price = 599.0,
                CategoryId = xboxGames.Id,

            });

            builder.Entity<Product>().HasData(new Product
            {
                Name = "Counter-Strike: Global Offensive",
                Description = "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.",
                ImgUrl = "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg",
                Price = 49.0,
                CategoryId = pcGames.Id

            });

            builder.Entity<Product>().HasData(new Product
            {
                Name = "Fable",
                Description = "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios",
                ImgUrl = "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg",
                Price = 599.0,
                CategoryId = xboxGames.Id,
                Deals = true

            });

            builder.Entity<Product>().HasData(new Product
            {
                Name = "F1 2020",
                Description = "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.",
                ImgUrl = "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg",
                Price = 599.0,
                CategoryId = pcGames.Id,
                Deals = true


            });


            builder.Entity<Product>().HasData(new Product
            {
                Name = "Xbox Controller",
                Description = "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ",
                ImgUrl = "https://www.geeky-gadgets.com/wp-content/uploads/2018/08/Wireless-Controller-Grey-Blue-2.jpg",
                Price = 599.0,
                CategoryId = xboxAccesories.Id,
                Deals = true



            });
        }

        public void Dispose()
        {
            
        }
    }
}
