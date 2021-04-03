﻿// <auto-generated />
using System;
using GameQuest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameQuest.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210314170506_int1")]
    partial class int1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameQuest.Data.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MainCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MainCategoryId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9615c035-9bf1-4c0b-9aea-89a705d5006d"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(1929),
                            MainCategoryId = new Guid("ec631dd4-daee-40df-ac11-5b2ec3145f2f"),
                            SubCategoryId = new Guid("c7f68ed4-94be-4ba8-b7c7-75e288f876f9")
                        },
                        new
                        {
                            Id = new Guid("87df517a-7d38-47c2-8597-d9b031c2f3ba"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3357),
                            MainCategoryId = new Guid("3ca6d567-a99f-44dc-a732-862aa19c2634"),
                            SubCategoryId = new Guid("c7f68ed4-94be-4ba8-b7c7-75e288f876f9")
                        },
                        new
                        {
                            Id = new Guid("e28207ef-4b89-4ecc-b6b9-a8a48f429b6c"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3372),
                            MainCategoryId = new Guid("bfd6c4d6-1aa0-4ad0-be8d-e6b3ae84d052"),
                            SubCategoryId = new Guid("c7f68ed4-94be-4ba8-b7c7-75e288f876f9")
                        },
                        new
                        {
                            Id = new Guid("324ae53e-7ee6-4e08-8e99-ac5ecc9dc15a"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3375),
                            MainCategoryId = new Guid("4e1f8d82-2cf2-428c-aa10-2dcec848e2b0"),
                            SubCategoryId = new Guid("c7f68ed4-94be-4ba8-b7c7-75e288f876f9")
                        },
                        new
                        {
                            Id = new Guid("d203deeb-88b9-44d1-bbcc-1402d089d004"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3379),
                            MainCategoryId = new Guid("ec631dd4-daee-40df-ac11-5b2ec3145f2f"),
                            SubCategoryId = new Guid("de347fa3-5529-4d7e-9dcc-b35e7db554a2")
                        },
                        new
                        {
                            Id = new Guid("ae11ac62-f3c0-4e5e-ae70-290fe4f980f3"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3382),
                            MainCategoryId = new Guid("3ca6d567-a99f-44dc-a732-862aa19c2634"),
                            SubCategoryId = new Guid("de347fa3-5529-4d7e-9dcc-b35e7db554a2")
                        },
                        new
                        {
                            Id = new Guid("9cd4df84-17eb-4097-9c04-e613fca6d7ce"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3385),
                            MainCategoryId = new Guid("bfd6c4d6-1aa0-4ad0-be8d-e6b3ae84d052"),
                            SubCategoryId = new Guid("97be695e-2f25-448b-b64a-405906780cb9")
                        },
                        new
                        {
                            Id = new Guid("bfa74dfb-4dc9-47a7-8048-51901d27516f"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3389),
                            MainCategoryId = new Guid("4e1f8d82-2cf2-428c-aa10-2dcec848e2b0"),
                            SubCategoryId = new Guid("97be695e-2f25-448b-b64a-405906780cb9")
                        });
                });

            modelBuilder.Entity("GameQuest.Data.Content", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInMenu")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e14a74ab-26db-4cdb-8aaa-6102a76df757"),
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.",
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(4927),
                            ImageUrl = "",
                            IsInMenu = false,
                            IsPublished = false,
                            Title = "About"
                        },
                        new
                        {
                            Id = new Guid("901918a6-bef4-4ca0-a207-34caede7ef63"),
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.",
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(7595),
                            ImageUrl = "",
                            IsInMenu = false,
                            IsPublished = false,
                            Title = "FAQ"
                        },
                        new
                        {
                            Id = new Guid("441ab33b-b14c-4800-af37-a7812a036095"),
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.",
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(7632),
                            ImageUrl = "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg",
                            IsInMenu = false,
                            IsPublished = false,
                            Title = "Contact"
                        });
                });

            modelBuilder.Entity("GameQuest.Data.MainCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ec631dd4-daee-40df-ac11-5b2ec3145f2f"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 367, DateTimeKind.Local).AddTicks(5505),
                            Description = "",
                            Name = "Nintendo"
                        },
                        new
                        {
                            Id = new Guid("3ca6d567-a99f-44dc-a732-862aa19c2634"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 369, DateTimeKind.Local).AddTicks(8163),
                            Description = "",
                            Name = "Playstation"
                        },
                        new
                        {
                            Id = new Guid("bfd6c4d6-1aa0-4ad0-be8d-e6b3ae84d052"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 369, DateTimeKind.Local).AddTicks(8205),
                            Description = "",
                            Name = "Xbox"
                        },
                        new
                        {
                            Id = new Guid("4e1f8d82-2cf2-428c-aa10-2dcec848e2b0"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 369, DateTimeKind.Local).AddTicks(8210),
                            Description = "",
                            Name = "PC"
                        });
                });

            modelBuilder.Entity("GameQuest.Data.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GameQuest.Data.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deals")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Sale")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8869f357-6b06-4f7b-8c23-f1283aacfbf0"),
                            CategoryId = new Guid("e28207ef-4b89-4ecc-b6b9-a8a48f429b6c"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(8907),
                            Deals = false,
                            Description = "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.",
                            ImgUrl = "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png",
                            IsVisible = false,
                            Name = "Halo: Combat Evolved",
                            Price = 599.0,
                            Sale = 0.0
                        },
                        new
                        {
                            Id = new Guid("5f54c5c4-919c-4eda-93df-a3a08a50990f"),
                            CategoryId = new Guid("324ae53e-7ee6-4e08-8e99-ac5ecc9dc15a"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 372, DateTimeKind.Local).AddTicks(2433),
                            Deals = false,
                            Description = "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.",
                            ImgUrl = "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg",
                            IsVisible = false,
                            Name = "Counter-Strike: Global Offensive",
                            Price = 49.0,
                            Sale = 0.0
                        },
                        new
                        {
                            Id = new Guid("cb7ede06-4066-4747-a551-5be0b914374c"),
                            CategoryId = new Guid("e28207ef-4b89-4ecc-b6b9-a8a48f429b6c"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 372, DateTimeKind.Local).AddTicks(2479),
                            Deals = true,
                            Description = "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios",
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg",
                            IsVisible = false,
                            Name = "Fable",
                            Price = 599.0,
                            Sale = 0.0
                        },
                        new
                        {
                            Id = new Guid("30580b7d-3d78-40f2-a52c-62af24d0b44e"),
                            CategoryId = new Guid("324ae53e-7ee6-4e08-8e99-ac5ecc9dc15a"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 372, DateTimeKind.Local).AddTicks(2504),
                            Deals = true,
                            Description = "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.",
                            ImgUrl = "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg",
                            IsVisible = false,
                            Name = "F1 2020",
                            Price = 599.0,
                            Sale = 0.0
                        },
                        new
                        {
                            Id = new Guid("70ba1978-96fd-4d61-af78-4a2b7361d3ae"),
                            CategoryId = new Guid("9cd4df84-17eb-4097-9c04-e613fca6d7ce"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 372, DateTimeKind.Local).AddTicks(2526),
                            Deals = true,
                            Description = "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ",
                            ImgUrl = "https://www.geeky-gadgets.com/wp-content/uploads/2018/08/Wireless-Controller-Grey-Blue-2.jpg",
                            IsVisible = false,
                            Name = "Xbox Controller",
                            Price = 599.0,
                            Sale = 0.0
                        });
                });

            modelBuilder.Entity("GameQuest.Data.SubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c7f68ed4-94be-4ba8-b7c7-75e288f876f9"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 370, DateTimeKind.Local).AddTicks(9768),
                            Description = "",
                            Name = "Games"
                        },
                        new
                        {
                            Id = new Guid("97be695e-2f25-448b-b64a-405906780cb9"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(721),
                            Description = "",
                            Name = "Accesories"
                        },
                        new
                        {
                            Id = new Guid("de347fa3-5529-4d7e-9dcc-b35e7db554a2"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(736),
                            Description = "",
                            Name = "Controllers"
                        },
                        new
                        {
                            Id = new Guid("44e096cf-c329-4b5a-9177-62976359cded"),
                            Created = new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(740),
                            Description = "",
                            Name = "Console"
                        });
                });

            modelBuilder.Entity("GameQuest.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("GameQuest.Data.Category", b =>
                {
                    b.HasOne("GameQuest.Data.MainCategory", "MainCategory")
                        .WithMany()
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameQuest.Data.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCategory");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("GameQuest.Data.Order", b =>
                {
                    b.HasOne("GameQuest.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameQuest.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GameQuest.Data.Product", b =>
                {
                    b.HasOne("GameQuest.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GameQuest.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GameQuest.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameQuest.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GameQuest.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}