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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Finished = table.Column<bool>(type: "bit", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "Title" },
                values: new object[,]
                {
                    { new Guid("a599eff5-3828-48f2-89ba-13aabd732afd"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(9040), "", false, false, "About" },
                    { new Guid("0e7361fe-786d-4e9c-8d38-506115770917"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 14, 15, 56, 1, 542, DateTimeKind.Local).AddTicks(782), "", false, false, "FAQ" },
                    { new Guid("e23ec03e-0810-453f-8d08-97d8b84f6279"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 14, 15, 56, 1, 542, DateTimeKind.Local).AddTicks(810), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("06922aba-d04e-4b30-b197-fea31c90d0f0"), new DateTime(2021, 4, 14, 15, 56, 1, 539, DateTimeKind.Local).AddTicks(2637), "", "Nintendo" },
                    { new Guid("a493b94e-f4b8-4e51-9094-26ae07156433"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(3717), "", "Playstation" },
                    { new Guid("34bdd4d8-52d2-4045-97be-6a6a87be407e"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(3745), "", "Xbox" },
                    { new Guid("71c674d5-d268-4db8-adc5-b6fc980fe559"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(3750), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2004c451-5481-453d-b1f5-189dd9930dc7", "cb9e6440-f52e-4c42-97a7-7984b362ff98", "Admin", "ADMIN" },
                    { "c231233b-bca8-4251-959f-51da369c82af", "384fe941-021f-49af-801f-9418626e45c3", "Customer", "CUSTOMER" },
                    { "20a759bb-1e0c-4e86-9968-2bdc1505451f", "2f12ed07-1229-4734-8683-5b8049cc1d62", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("5a4dbd5d-96f3-41aa-9fcd-b2981a1ff84a"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(4734), "", "Games" },
                    { new Guid("41e9ba26-2c2d-4524-b037-2f1257eac655"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(5453), "", "Accesories" },
                    { new Guid("afaf6d75-d7d1-4e43-a2d6-164c4d2041b5"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(5470), "", "Controllers" },
                    { new Guid("44ce85ca-6424-4903-ad4e-8f53843823af"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(5474), "", "Console" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("6a437024-e30c-4751-a048-9e77ac93c1bb"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(6444), new Guid("06922aba-d04e-4b30-b197-fea31c90d0f0"), new Guid("5a4dbd5d-96f3-41aa-9fcd-b2981a1ff84a") },
                    { new Guid("6f2d41dd-d68b-4906-aa7d-cd065dc2c73e"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(7639), new Guid("a493b94e-f4b8-4e51-9094-26ae07156433"), new Guid("5a4dbd5d-96f3-41aa-9fcd-b2981a1ff84a") },
                    { new Guid("2ae4a08c-1f97-43d8-bb29-a29866901708"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(7650), new Guid("34bdd4d8-52d2-4045-97be-6a6a87be407e"), new Guid("5a4dbd5d-96f3-41aa-9fcd-b2981a1ff84a") },
                    { new Guid("3dd47372-e336-4614-abe7-ab85f731eb0e"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(7654), new Guid("71c674d5-d268-4db8-adc5-b6fc980fe559"), new Guid("5a4dbd5d-96f3-41aa-9fcd-b2981a1ff84a") },
                    { new Guid("58f78f78-ddd2-4394-a052-ab3a4e6ad019"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(7668), new Guid("34bdd4d8-52d2-4045-97be-6a6a87be407e"), new Guid("41e9ba26-2c2d-4524-b037-2f1257eac655") },
                    { new Guid("e8c89566-9bf9-4d83-b621-4d390a4344c7"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(7672), new Guid("71c674d5-d268-4db8-adc5-b6fc980fe559"), new Guid("41e9ba26-2c2d-4524-b037-2f1257eac655") },
                    { new Guid("32267ad5-619f-4728-8a8c-0810d7de5c4f"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(7657), new Guid("06922aba-d04e-4b30-b197-fea31c90d0f0"), new Guid("afaf6d75-d7d1-4e43-a2d6-164c4d2041b5") },
                    { new Guid("c2dfc2d3-5855-4417-a839-0683b2d40ccc"), new DateTime(2021, 4, 14, 15, 56, 1, 541, DateTimeKind.Local).AddTicks(7660), new Guid("a493b94e-f4b8-4e51-9094-26ae07156433"), new Guid("afaf6d75-d7d1-4e43-a2d6-164c4d2041b5") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Deals", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("b890fe2a-d2b8-4d93-a4cd-ab01c1d8caa1"), new Guid("2ae4a08c-1f97-43d8-bb29-a29866901708"), new DateTime(2021, 4, 14, 15, 56, 1, 542, DateTimeKind.Local).AddTicks(1621), false, "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("1b8afae4-1618-481e-b713-c8e65ee23f2f"), new Guid("2ae4a08c-1f97-43d8-bb29-a29866901708"), new DateTime(2021, 4, 14, 15, 56, 1, 542, DateTimeKind.Local).AddTicks(4378), true, "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("5edc3b14-6786-4401-ba60-1de6699e76cd"), new Guid("3dd47372-e336-4614-abe7-ab85f731eb0e"), new DateTime(2021, 4, 14, 15, 56, 1, 542, DateTimeKind.Local).AddTicks(4344), false, "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("2cc12bce-c559-47d9-9050-8d2020648ead"), new Guid("3dd47372-e336-4614-abe7-ab85f731eb0e"), new DateTime(2021, 4, 14, 15, 56, 1, 542, DateTimeKind.Local).AddTicks(4402), true, "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 },
                    { new Guid("6a4333b3-6bca-4151-8c1b-69016cd2dd0e"), new Guid("58f78f78-ddd2-4394-a052-ab3a4e6ad019"), new DateTime(2021, 4, 14, 15, 56, 1, 542, DateTimeKind.Local).AddTicks(4420), true, "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ", "https://www.geeky-gadgets.com/wp-content/uploads/2018/08/Wireless-Controller-Grey-Blue-2.jpg", false, "Xbox Controller", 599.0, 0.0 }
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
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

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
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Products");

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
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "MainCategories");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
