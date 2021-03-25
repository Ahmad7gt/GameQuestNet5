using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameQuest.Migrations
{
    public partial class init : Migration
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
                    { new Guid("f1818ee3-a296-42cc-b0d0-d764993c3e8c"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(9336), "", false, false, "About" },
                    { new Guid("94ad8137-c678-47d7-b851-411c7f2be01d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 25, 14, 36, 15, 467, DateTimeKind.Local).AddTicks(1049), "", false, false, "FAQ" },
                    { new Guid("42b9ef0a-2d66-4541-a5be-bf2cd4a8924e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 25, 14, 36, 15, 467, DateTimeKind.Local).AddTicks(1078), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("17a4cbc2-6220-4d16-90cf-4a1513ebe4b4"), new DateTime(2021, 3, 25, 14, 36, 15, 464, DateTimeKind.Local).AddTicks(6115), "", "Nintendo" },
                    { new Guid("15db7dc7-bdaf-418e-bea1-e16a0c961599"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(4287), "", "Playstation" },
                    { new Guid("44b5a7d0-0689-496f-9b75-cde64e3c714b"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(4314), "", "Xbox" },
                    { new Guid("e170f2f1-b59f-4e9d-8782-7c4ffe33dd8a"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(4319), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d78d993d-ce58-40b6-9d17-0281e360aa12", "33fe44d4-c698-48cf-91a7-b7602ca98393", "Admin", "ADMIN" },
                    { "16ccd85b-53a9-4fdd-adf5-fa96b939ae84", "2e8c2e4b-982e-4d59-9580-c48ad8329143", "Customer", "CUSTOMER" },
                    { "2c0625ae-6c96-429a-8fe5-7791a074292f", "57b0eb26-9c08-4975-8609-6d5bdb749ebb", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("a1b2f954-3788-4649-ae3c-0fff34a59273"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(5116), "", "Games" },
                    { new Guid("bd12e291-b2a3-43bb-a618-96e6f3931b1c"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(5800), "", "Accesories" },
                    { new Guid("49dcba31-bf65-475d-b789-0887be3f72ad"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(5811), "", "Controllers" },
                    { new Guid("59d3eccc-a6e7-4bdf-8713-5e94002e3fcb"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(5814), "", "Console" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("690ebb82-ad03-46cb-8e57-5c400c80b196"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(6770), new Guid("17a4cbc2-6220-4d16-90cf-4a1513ebe4b4"), new Guid("a1b2f954-3788-4649-ae3c-0fff34a59273") },
                    { new Guid("18269948-adec-4fda-8db4-92b44364be3a"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(7941), new Guid("15db7dc7-bdaf-418e-bea1-e16a0c961599"), new Guid("a1b2f954-3788-4649-ae3c-0fff34a59273") },
                    { new Guid("9eaf4fa7-eca6-4215-aabf-c1427a6fa152"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(7952), new Guid("44b5a7d0-0689-496f-9b75-cde64e3c714b"), new Guid("a1b2f954-3788-4649-ae3c-0fff34a59273") },
                    { new Guid("8544311e-ca95-43dd-8f7d-64bd95e03d85"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(7955), new Guid("e170f2f1-b59f-4e9d-8782-7c4ffe33dd8a"), new Guid("a1b2f954-3788-4649-ae3c-0fff34a59273") },
                    { new Guid("9c8f949b-00c3-4808-bdd6-3a17d5e202cd"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(7969), new Guid("44b5a7d0-0689-496f-9b75-cde64e3c714b"), new Guid("bd12e291-b2a3-43bb-a618-96e6f3931b1c") },
                    { new Guid("5984426a-e6d7-4049-a9ca-6bb0e2049eec"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(7971), new Guid("e170f2f1-b59f-4e9d-8782-7c4ffe33dd8a"), new Guid("bd12e291-b2a3-43bb-a618-96e6f3931b1c") },
                    { new Guid("bbdac8db-3710-44d7-9c68-d5036cdc4621"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(7958), new Guid("17a4cbc2-6220-4d16-90cf-4a1513ebe4b4"), new Guid("49dcba31-bf65-475d-b789-0887be3f72ad") },
                    { new Guid("bdd9634e-4683-4854-9cae-ed49b10f2b0b"), new DateTime(2021, 3, 25, 14, 36, 15, 466, DateTimeKind.Local).AddTicks(7966), new Guid("15db7dc7-bdaf-418e-bea1-e16a0c961599"), new Guid("49dcba31-bf65-475d-b789-0887be3f72ad") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Deals", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("80fe86f8-c086-4718-8455-41418f85b48b"), new Guid("9eaf4fa7-eca6-4215-aabf-c1427a6fa152"), new DateTime(2021, 3, 25, 14, 36, 15, 467, DateTimeKind.Local).AddTicks(1861), false, "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("a42ce03a-3d88-4886-9fc2-2c5630723940"), new Guid("9eaf4fa7-eca6-4215-aabf-c1427a6fa152"), new DateTime(2021, 3, 25, 14, 36, 15, 467, DateTimeKind.Local).AddTicks(4569), true, "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("6c477025-56bd-4bfb-b380-720daf272750"), new Guid("8544311e-ca95-43dd-8f7d-64bd95e03d85"), new DateTime(2021, 3, 25, 14, 36, 15, 467, DateTimeKind.Local).AddTicks(4531), false, "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("2db2afa4-ccc2-402c-8ebf-d5ddebee0577"), new Guid("8544311e-ca95-43dd-8f7d-64bd95e03d85"), new DateTime(2021, 3, 25, 14, 36, 15, 467, DateTimeKind.Local).AddTicks(4588), true, "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 },
                    { new Guid("58d792af-d010-4abf-92eb-80f2b1cfd16c"), new Guid("9c8f949b-00c3-4808-bdd6-3a17d5e202cd"), new DateTime(2021, 3, 25, 14, 36, 15, 467, DateTimeKind.Local).AddTicks(4605), true, "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ", "https://www.geeky-gadgets.com/wp-content/uploads/2018/08/Wireless-Controller-Grey-Blue-2.jpg", false, "Xbox Controller", 599.0, 0.0 }
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
