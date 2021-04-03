using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameQuest.Migrations
{
    public partial class int1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInMenu = table.Column<bool>(type: "bit", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MainCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Categories_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Sale = table.Column<double>(type: "float", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deals = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "Title" },
                values: new object[,]
                {
<<<<<<< HEAD:Migrations/20210314170506_int1.cs
                    { new Guid("e14a74ab-26db-4cdb-8aaa-6102a76df757"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(4927), "", false, false, "About" },
                    { new Guid("901918a6-bef4-4ca0-a207-34caede7ef63"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(7595), "", false, false, "FAQ" },
                    { new Guid("441ab33b-b14c-4800-af37-a7812a036095"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(7632), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
=======
                    { new Guid("3612e955-433f-429d-939a-afe2dbd8d312"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(8430), "", false, false, "About" },
                    { new Guid("06e20d97-8867-4d98-855c-be3c270573cb"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 2, 14, 23, 7, 273, DateTimeKind.Local).AddTicks(134), "", false, false, "FAQ" },
                    { new Guid("ec0c3ac3-8618-4e5e-a629-e0db55887c15"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 2, 14, 23, 7, 273, DateTimeKind.Local).AddTicks(196), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
>>>>>>> f07535cc29ccde0620b31c241f30b63d8dbd2a6e:Migrations/20210402122307_init.cs
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
<<<<<<< HEAD:Migrations/20210314170506_int1.cs
                    { new Guid("ec631dd4-daee-40df-ac11-5b2ec3145f2f"), new DateTime(2021, 3, 14, 18, 5, 6, 367, DateTimeKind.Local).AddTicks(5505), "", "Nintendo" },
                    { new Guid("3ca6d567-a99f-44dc-a732-862aa19c2634"), new DateTime(2021, 3, 14, 18, 5, 6, 369, DateTimeKind.Local).AddTicks(8163), "", "Playstation" },
                    { new Guid("bfd6c4d6-1aa0-4ad0-be8d-e6b3ae84d052"), new DateTime(2021, 3, 14, 18, 5, 6, 369, DateTimeKind.Local).AddTicks(8205), "", "Xbox" },
                    { new Guid("4e1f8d82-2cf2-428c-aa10-2dcec848e2b0"), new DateTime(2021, 3, 14, 18, 5, 6, 369, DateTimeKind.Local).AddTicks(8210), "", "PC" }
=======
                    { new Guid("0dd64c02-7aa0-467a-b71c-778cc082e514"), new DateTime(2021, 4, 2, 14, 23, 7, 270, DateTimeKind.Local).AddTicks(5339), "", "Nintendo" },
                    { new Guid("4f6c9c44-d2bf-43af-a372-aff15e48ae28"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(3417), "", "Playstation" },
                    { new Guid("2dfd820a-4260-44ec-95c2-f87576a31294"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(3446), "", "Xbox" },
                    { new Guid("8046fd8e-2643-4f66-9a01-c95ad87fc75e"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(3451), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f56c45b-17d7-4df3-bc35-8824cc426b60", "4e3efbbe-c881-4a6d-b576-cd8e723a9458", "Admin", "ADMIN" },
                    { "d44a7182-a47e-4e90-8c7c-d0deb5c07e9f", "6d91f287-28cb-4805-9aba-4e5815330cf3", "Customer", "CUSTOMER" },
                    { "6277828a-d24a-4b0f-8005-7bcfb7e6166a", "331d5fe8-2282-4b20-bf30-fc7edc3f5558", "User", "USER" }
>>>>>>> f07535cc29ccde0620b31c241f30b63d8dbd2a6e:Migrations/20210402122307_init.cs
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
<<<<<<< HEAD:Migrations/20210314170506_int1.cs
                    { new Guid("c7f68ed4-94be-4ba8-b7c7-75e288f876f9"), new DateTime(2021, 3, 14, 18, 5, 6, 370, DateTimeKind.Local).AddTicks(9768), "", "Games" },
                    { new Guid("97be695e-2f25-448b-b64a-405906780cb9"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(721), "", "Accesories" },
                    { new Guid("de347fa3-5529-4d7e-9dcc-b35e7db554a2"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(736), "", "Controllers" },
                    { new Guid("44e096cf-c329-4b5a-9177-62976359cded"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(740), "", "Console" }
=======
                    { new Guid("e7bc4f99-8b04-4fdd-94b3-1ee74d0d4994"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(4267), "", "Games" },
                    { new Guid("217c83c9-1531-40e5-abc9-a20cc9edfcf0"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(4966), "", "Accesories" },
                    { new Guid("1d5ad12d-d31d-489c-95cd-cf3e016b782d"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(4978), "", "Controllers" },
                    { new Guid("f42ff7d6-7741-47cb-9471-671147f3bfc3"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(4981), "", "Console" }
>>>>>>> f07535cc29ccde0620b31c241f30b63d8dbd2a6e:Migrations/20210402122307_init.cs
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
<<<<<<< HEAD:Migrations/20210314170506_int1.cs
                    { new Guid("9615c035-9bf1-4c0b-9aea-89a705d5006d"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(1929), new Guid("ec631dd4-daee-40df-ac11-5b2ec3145f2f"), new Guid("c7f68ed4-94be-4ba8-b7c7-75e288f876f9") },
                    { new Guid("87df517a-7d38-47c2-8597-d9b031c2f3ba"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3357), new Guid("3ca6d567-a99f-44dc-a732-862aa19c2634"), new Guid("c7f68ed4-94be-4ba8-b7c7-75e288f876f9") },
                    { new Guid("e28207ef-4b89-4ecc-b6b9-a8a48f429b6c"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3372), new Guid("bfd6c4d6-1aa0-4ad0-be8d-e6b3ae84d052"), new Guid("c7f68ed4-94be-4ba8-b7c7-75e288f876f9") },
                    { new Guid("324ae53e-7ee6-4e08-8e99-ac5ecc9dc15a"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3375), new Guid("4e1f8d82-2cf2-428c-aa10-2dcec848e2b0"), new Guid("c7f68ed4-94be-4ba8-b7c7-75e288f876f9") },
                    { new Guid("9cd4df84-17eb-4097-9c04-e613fca6d7ce"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3385), new Guid("bfd6c4d6-1aa0-4ad0-be8d-e6b3ae84d052"), new Guid("97be695e-2f25-448b-b64a-405906780cb9") },
                    { new Guid("bfa74dfb-4dc9-47a7-8048-51901d27516f"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3389), new Guid("4e1f8d82-2cf2-428c-aa10-2dcec848e2b0"), new Guid("97be695e-2f25-448b-b64a-405906780cb9") },
                    { new Guid("d203deeb-88b9-44d1-bbcc-1402d089d004"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3379), new Guid("ec631dd4-daee-40df-ac11-5b2ec3145f2f"), new Guid("de347fa3-5529-4d7e-9dcc-b35e7db554a2") },
                    { new Guid("ae11ac62-f3c0-4e5e-ae70-290fe4f980f3"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(3382), new Guid("3ca6d567-a99f-44dc-a732-862aa19c2634"), new Guid("de347fa3-5529-4d7e-9dcc-b35e7db554a2") }
=======
                    { new Guid("775ae8ee-b03c-40e6-a3eb-af9b1d7a969a"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(5924), new Guid("0dd64c02-7aa0-467a-b71c-778cc082e514"), new Guid("e7bc4f99-8b04-4fdd-94b3-1ee74d0d4994") },
                    { new Guid("02692608-3db2-45de-9c11-e394f3d13b20"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(7101), new Guid("4f6c9c44-d2bf-43af-a372-aff15e48ae28"), new Guid("e7bc4f99-8b04-4fdd-94b3-1ee74d0d4994") },
                    { new Guid("951772f3-566d-402b-b100-af86c9d13c9d"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(7113), new Guid("2dfd820a-4260-44ec-95c2-f87576a31294"), new Guid("e7bc4f99-8b04-4fdd-94b3-1ee74d0d4994") },
                    { new Guid("dbb9b3fc-904a-4dad-857f-6fbb6e5b5048"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(7116), new Guid("8046fd8e-2643-4f66-9a01-c95ad87fc75e"), new Guid("e7bc4f99-8b04-4fdd-94b3-1ee74d0d4994") },
                    { new Guid("df7cfae7-8317-49a8-8fda-b46b12e9ef6d"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(7130), new Guid("2dfd820a-4260-44ec-95c2-f87576a31294"), new Guid("217c83c9-1531-40e5-abc9-a20cc9edfcf0") },
                    { new Guid("e70d3a3a-b40f-46fd-ad63-81e79bdad8c6"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(7133), new Guid("8046fd8e-2643-4f66-9a01-c95ad87fc75e"), new Guid("217c83c9-1531-40e5-abc9-a20cc9edfcf0") },
                    { new Guid("9939c4c8-89fa-45bd-a443-f6c7ee69a1e8"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(7120), new Guid("0dd64c02-7aa0-467a-b71c-778cc082e514"), new Guid("1d5ad12d-d31d-489c-95cd-cf3e016b782d") },
                    { new Guid("bc7522ae-2d1e-44c3-aebc-12ed30b93517"), new DateTime(2021, 4, 2, 14, 23, 7, 272, DateTimeKind.Local).AddTicks(7127), new Guid("4f6c9c44-d2bf-43af-a372-aff15e48ae28"), new Guid("1d5ad12d-d31d-489c-95cd-cf3e016b782d") }
>>>>>>> f07535cc29ccde0620b31c241f30b63d8dbd2a6e:Migrations/20210402122307_init.cs
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Deals", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
<<<<<<< HEAD:Migrations/20210314170506_int1.cs
                    { new Guid("8869f357-6b06-4f7b-8c23-f1283aacfbf0"), new Guid("e28207ef-4b89-4ecc-b6b9-a8a48f429b6c"), new DateTime(2021, 3, 14, 18, 5, 6, 371, DateTimeKind.Local).AddTicks(8907), false, "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("cb7ede06-4066-4747-a551-5be0b914374c"), new Guid("e28207ef-4b89-4ecc-b6b9-a8a48f429b6c"), new DateTime(2021, 3, 14, 18, 5, 6, 372, DateTimeKind.Local).AddTicks(2479), true, "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("5f54c5c4-919c-4eda-93df-a3a08a50990f"), new Guid("324ae53e-7ee6-4e08-8e99-ac5ecc9dc15a"), new DateTime(2021, 3, 14, 18, 5, 6, 372, DateTimeKind.Local).AddTicks(2433), false, "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("30580b7d-3d78-40f2-a52c-62af24d0b44e"), new Guid("324ae53e-7ee6-4e08-8e99-ac5ecc9dc15a"), new DateTime(2021, 3, 14, 18, 5, 6, 372, DateTimeKind.Local).AddTicks(2504), true, "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 },
                    { new Guid("70ba1978-96fd-4d61-af78-4a2b7361d3ae"), new Guid("9cd4df84-17eb-4097-9c04-e613fca6d7ce"), new DateTime(2021, 3, 14, 18, 5, 6, 372, DateTimeKind.Local).AddTicks(2526), true, "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ", "https://www.geeky-gadgets.com/wp-content/uploads/2018/08/Wireless-Controller-Grey-Blue-2.jpg", false, "Xbox Controller", 599.0, 0.0 }
=======
                    { new Guid("75d2dbd2-fff9-474e-b4ea-84b6e8c58156"), new Guid("951772f3-566d-402b-b100-af86c9d13c9d"), new DateTime(2021, 4, 2, 14, 23, 7, 273, DateTimeKind.Local).AddTicks(1030), false, "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("7684ec6c-d95e-44e2-a369-f0e49ca17226"), new Guid("951772f3-566d-402b-b100-af86c9d13c9d"), new DateTime(2021, 4, 2, 14, 23, 7, 273, DateTimeKind.Local).AddTicks(3728), true, "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("7ae8c3bc-869c-4e6a-a262-a31c6e44aa8b"), new Guid("dbb9b3fc-904a-4dad-857f-6fbb6e5b5048"), new DateTime(2021, 4, 2, 14, 23, 7, 273, DateTimeKind.Local).AddTicks(3688), false, "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("41751510-5814-42eb-aa61-448dfa9e181e"), new Guid("dbb9b3fc-904a-4dad-857f-6fbb6e5b5048"), new DateTime(2021, 4, 2, 14, 23, 7, 273, DateTimeKind.Local).AddTicks(3747), true, "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 },
                    { new Guid("cfbb8570-6f05-42c2-86a1-eb61b520c75f"), new Guid("df7cfae7-8317-49a8-8fda-b46b12e9ef6d"), new DateTime(2021, 4, 2, 14, 23, 7, 273, DateTimeKind.Local).AddTicks(3764), true, "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ", "https://www.geeky-gadgets.com/wp-content/uploads/2018/08/Wireless-Controller-Grey-Blue-2.jpg", false, "Xbox Controller", 599.0, 0.0 }
>>>>>>> f07535cc29ccde0620b31c241f30b63d8dbd2a6e:Migrations/20210402122307_init.cs
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MainCategoryId",
                table: "Categories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SubCategoryId",
                table: "Categories",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "MainCategories");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
