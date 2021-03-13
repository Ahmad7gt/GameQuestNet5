using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameQuest.Migrations
{
    public partial class int8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19721406-7d90-4df6-8d0d-41c8ee31e5be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c8d24b9-971c-4dae-b9dd-ff589f63d2c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c811050-4bda-4509-8012-57c9d756c16c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eeab5e0a-14cf-4949-9980-461e43317711"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3aba071-94ea-401a-9066-26bf968217da"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("09bca75a-cc7a-4f0e-bd8f-091345f3910c"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("7610160e-75c6-4b32-b004-fe320d228bad"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("b27f9010-6ff5-4c3e-8232-f8aeed5ed0e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cad9758-20b1-4e73-b9de-c35083971a65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60df76bb-e195-4549-9228-2a78633c60ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66fdbb3b-4edf-4fee-acdf-bc9076ece9ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afca2679-f3ef-46d2-97e8-e478fd17ad31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3f27eda-d5d8-452c-afa4-0c5c60e570a1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b9eb52b5-75a4-4cc0-9f4d-1e10277d6455"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5bcc1b1f-7349-41f7-a8aa-109c3621e85a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6936629c-a5b3-40d8-badf-9c2bd37c5215"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6fb95a0-2e53-412d-a979-6b76593a3507"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("b6552132-68f1-45a2-83a7-473d85b58c20"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("f170173b-c7a4-4d5d-a823-560192b0d83d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("16fb9c68-78ff-47d7-95b8-f295831aca02"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("744d6485-70a4-41fc-8233-b1cf8ce6d6f5"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("9fb9188e-c383-4c95-ae33-3860af2a2cf6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("014b38a9-e9f9-4997-b988-c2ff2581df90"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b916765-044b-4330-8dfb-b4cc6691e7a0"));

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "Title" },
                values: new object[,]
                {
                    { new Guid("634522b5-648d-46d9-865c-a6f9f77a4eb0"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(7188), "", false, false, "About" },
                    { new Guid("18565523-9e38-4fdf-9929-069467956545"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(8897), "", false, false, "FAQ" },
                    { new Guid("43eebb9d-a09d-413e-be9a-be9c95dbc92f"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(9002), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("57ec9b6f-8d17-4649-93ef-a835401da650"), new DateTime(2021, 3, 12, 17, 4, 28, 779, DateTimeKind.Local).AddTicks(5706), "", "Nintendo" },
                    { new Guid("5b23c619-e83a-4ef5-b0e2-a68db4e9c9db"), new DateTime(2021, 3, 12, 17, 4, 28, 781, DateTimeKind.Local).AddTicks(3692), "", "Playstation" },
                    { new Guid("6625fbb2-4dbb-44aa-b632-a7da6392f44d"), new DateTime(2021, 3, 12, 17, 4, 28, 781, DateTimeKind.Local).AddTicks(3719), "", "Xbox" },
                    { new Guid("ea616535-809e-475d-b5c0-e6119a4a3554"), new DateTime(2021, 3, 12, 17, 4, 28, 781, DateTimeKind.Local).AddTicks(3724), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("86abf015-a517-4083-beeb-e637dabf8989"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(2811), "", "Games" },
                    { new Guid("548bba37-aafa-4393-ba8b-8e9a7935aaad"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(3570), "", "Accesories" },
                    { new Guid("b09e3c71-c76e-4b00-a5ea-d97e7728aa92"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(3582), "", "Controllers" },
                    { new Guid("06dff85b-7338-4f12-91e6-2391cb7ced53"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(3585), "", "Console" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("abf18658-ae9a-45bc-9fc4-df2bbae37ad8"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(4534), new Guid("57ec9b6f-8d17-4649-93ef-a835401da650"), new Guid("86abf015-a517-4083-beeb-e637dabf8989") },
                    { new Guid("5d68f624-a1b6-4ad8-a45f-d6eb26c3997d"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(5735), new Guid("5b23c619-e83a-4ef5-b0e2-a68db4e9c9db"), new Guid("86abf015-a517-4083-beeb-e637dabf8989") },
                    { new Guid("d3af0023-8519-442e-89db-dcc3af58d2bf"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(5747), new Guid("6625fbb2-4dbb-44aa-b632-a7da6392f44d"), new Guid("86abf015-a517-4083-beeb-e637dabf8989") },
                    { new Guid("13839018-1925-47e4-8381-5c5427c40fa2"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(5750), new Guid("ea616535-809e-475d-b5c0-e6119a4a3554"), new Guid("86abf015-a517-4083-beeb-e637dabf8989") },
                    { new Guid("e1d9ecdd-77c2-46a4-9495-bcf6add7bed1"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(5764), new Guid("6625fbb2-4dbb-44aa-b632-a7da6392f44d"), new Guid("548bba37-aafa-4393-ba8b-8e9a7935aaad") },
                    { new Guid("cd50a0f0-d7fa-425c-b2a1-7b1769689b5d"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(5767), new Guid("ea616535-809e-475d-b5c0-e6119a4a3554"), new Guid("548bba37-aafa-4393-ba8b-8e9a7935aaad") },
                    { new Guid("ebc0939c-8e7c-4627-b888-92e936a47f52"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(5759), new Guid("57ec9b6f-8d17-4649-93ef-a835401da650"), new Guid("b09e3c71-c76e-4b00-a5ea-d97e7728aa92") },
                    { new Guid("a9b0155a-20de-4add-905b-a4d58cdefddf"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(5762), new Guid("5b23c619-e83a-4ef5-b0e2-a68db4e9c9db"), new Guid("b09e3c71-c76e-4b00-a5ea-d97e7728aa92") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Deals", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("30e5c327-cdc8-4f90-bdd3-24aeb9e5a6c0"), new Guid("d3af0023-8519-442e-89db-dcc3af58d2bf"), new DateTime(2021, 3, 12, 17, 4, 28, 782, DateTimeKind.Local).AddTicks(9798), false, "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("c7fcede9-d07b-44f9-8119-4554974e9b74"), new Guid("d3af0023-8519-442e-89db-dcc3af58d2bf"), new DateTime(2021, 3, 12, 17, 4, 28, 783, DateTimeKind.Local).AddTicks(2501), true, "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("747967ad-a488-4e07-8fa4-9a7b81e7c9cc"), new Guid("13839018-1925-47e4-8381-5c5427c40fa2"), new DateTime(2021, 3, 12, 17, 4, 28, 783, DateTimeKind.Local).AddTicks(2468), false, "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("fcf84394-f4d8-4476-8ec9-bde4e60bced7"), new Guid("13839018-1925-47e4-8381-5c5427c40fa2"), new DateTime(2021, 3, 12, 17, 4, 28, 783, DateTimeKind.Local).AddTicks(2520), true, "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 },
                    { new Guid("c9981b02-86c7-437d-abc1-90454645b12e"), new Guid("e1d9ecdd-77c2-46a4-9495-bcf6add7bed1"), new DateTime(2021, 3, 12, 17, 4, 28, 783, DateTimeKind.Local).AddTicks(2537), true, "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ", "https://www.geeky-gadgets.com/wp-content/uploads/2018/08/Wireless-Controller-Grey-Blue-2.jpg", false, "Xbox Controller", 599.0, 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d68f624-a1b6-4ad8-a45f-d6eb26c3997d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9b0155a-20de-4add-905b-a4d58cdefddf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abf18658-ae9a-45bc-9fc4-df2bbae37ad8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd50a0f0-d7fa-425c-b2a1-7b1769689b5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ebc0939c-8e7c-4627-b888-92e936a47f52"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("18565523-9e38-4fdf-9929-069467956545"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("43eebb9d-a09d-413e-be9a-be9c95dbc92f"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("634522b5-648d-46d9-865c-a6f9f77a4eb0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30e5c327-cdc8-4f90-bdd3-24aeb9e5a6c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("747967ad-a488-4e07-8fa4-9a7b81e7c9cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7fcede9-d07b-44f9-8119-4554974e9b74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9981b02-86c7-437d-abc1-90454645b12e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fcf84394-f4d8-4476-8ec9-bde4e60bced7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("06dff85b-7338-4f12-91e6-2391cb7ced53"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("13839018-1925-47e4-8381-5c5427c40fa2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3af0023-8519-442e-89db-dcc3af58d2bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1d9ecdd-77c2-46a4-9495-bcf6add7bed1"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("57ec9b6f-8d17-4649-93ef-a835401da650"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b23c619-e83a-4ef5-b0e2-a68db4e9c9db"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b09e3c71-c76e-4b00-a5ea-d97e7728aa92"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("6625fbb2-4dbb-44aa-b632-a7da6392f44d"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea616535-809e-475d-b5c0-e6119a4a3554"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("548bba37-aafa-4393-ba8b-8e9a7935aaad"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("86abf015-a517-4083-beeb-e637dabf8989"));

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "Title" },
                values: new object[,]
                {
                    { new Guid("09bca75a-cc7a-4f0e-bd8f-091345f3910c"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(8185), "", false, false, "About" },
                    { new Guid("b27f9010-6ff5-4c3e-8232-f8aeed5ed0e1"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 12, 15, 19, 34, 865, DateTimeKind.Local).AddTicks(10), "", false, false, "FAQ" },
                    { new Guid("7610160e-75c6-4b32-b004-fe320d228bad"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 12, 15, 19, 34, 865, DateTimeKind.Local).AddTicks(42), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("f170173b-c7a4-4d5d-a823-560192b0d83d"), new DateTime(2021, 3, 12, 15, 19, 34, 861, DateTimeKind.Local).AddTicks(5094), "", "Nintendo" },
                    { new Guid("b6552132-68f1-45a2-83a7-473d85b58c20"), new DateTime(2021, 3, 12, 15, 19, 34, 863, DateTimeKind.Local).AddTicks(3929), "", "Playstation" },
                    { new Guid("9fb9188e-c383-4c95-ae33-3860af2a2cf6"), new DateTime(2021, 3, 12, 15, 19, 34, 863, DateTimeKind.Local).AddTicks(3959), "", "Xbox" },
                    { new Guid("744d6485-70a4-41fc-8233-b1cf8ce6d6f5"), new DateTime(2021, 3, 12, 15, 19, 34, 863, DateTimeKind.Local).AddTicks(3964), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("8b916765-044b-4330-8dfb-b4cc6691e7a0"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(3678), "", "Games" },
                    { new Guid("014b38a9-e9f9-4997-b988-c2ff2581df90"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(4460), "", "Accesories" },
                    { new Guid("16fb9c68-78ff-47d7-95b8-f295831aca02"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(4483), "", "Controllers" },
                    { new Guid("b9eb52b5-75a4-4cc0-9f4d-1e10277d6455"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(4487), "", "Console" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("f3aba071-94ea-401a-9066-26bf968217da"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(5521), new Guid("f170173b-c7a4-4d5d-a823-560192b0d83d"), new Guid("8b916765-044b-4330-8dfb-b4cc6691e7a0") },
                    { new Guid("19721406-7d90-4df6-8d0d-41c8ee31e5be"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(6757), new Guid("b6552132-68f1-45a2-83a7-473d85b58c20"), new Guid("8b916765-044b-4330-8dfb-b4cc6691e7a0") },
                    { new Guid("a6fb95a0-2e53-412d-a979-6b76593a3507"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(6770), new Guid("9fb9188e-c383-4c95-ae33-3860af2a2cf6"), new Guid("8b916765-044b-4330-8dfb-b4cc6691e7a0") },
                    { new Guid("6936629c-a5b3-40d8-badf-9c2bd37c5215"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(6773), new Guid("744d6485-70a4-41fc-8233-b1cf8ce6d6f5"), new Guid("8b916765-044b-4330-8dfb-b4cc6691e7a0") },
                    { new Guid("5bcc1b1f-7349-41f7-a8aa-109c3621e85a"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(6787), new Guid("9fb9188e-c383-4c95-ae33-3860af2a2cf6"), new Guid("014b38a9-e9f9-4997-b988-c2ff2581df90") },
                    { new Guid("1c8d24b9-971c-4dae-b9dd-ff589f63d2c4"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(6790), new Guid("744d6485-70a4-41fc-8233-b1cf8ce6d6f5"), new Guid("014b38a9-e9f9-4997-b988-c2ff2581df90") },
                    { new Guid("9c811050-4bda-4509-8012-57c9d756c16c"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(6776), new Guid("f170173b-c7a4-4d5d-a823-560192b0d83d"), new Guid("16fb9c68-78ff-47d7-95b8-f295831aca02") },
                    { new Guid("eeab5e0a-14cf-4949-9980-461e43317711"), new DateTime(2021, 3, 12, 15, 19, 34, 864, DateTimeKind.Local).AddTicks(6779), new Guid("b6552132-68f1-45a2-83a7-473d85b58c20"), new Guid("16fb9c68-78ff-47d7-95b8-f295831aca02") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Deals", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("66fdbb3b-4edf-4fee-acdf-bc9076ece9ea"), new Guid("a6fb95a0-2e53-412d-a979-6b76593a3507"), new DateTime(2021, 3, 12, 15, 19, 34, 865, DateTimeKind.Local).AddTicks(917), false, "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("60df76bb-e195-4549-9228-2a78633c60ef"), new Guid("a6fb95a0-2e53-412d-a979-6b76593a3507"), new DateTime(2021, 3, 12, 15, 19, 34, 865, DateTimeKind.Local).AddTicks(3841), false, "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("3cad9758-20b1-4e73-b9de-c35083971a65"), new Guid("6936629c-a5b3-40d8-badf-9c2bd37c5215"), new DateTime(2021, 3, 12, 15, 19, 34, 865, DateTimeKind.Local).AddTicks(3714), false, "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("d3f27eda-d5d8-452c-afa4-0c5c60e570a1"), new Guid("6936629c-a5b3-40d8-badf-9c2bd37c5215"), new DateTime(2021, 3, 12, 15, 19, 34, 865, DateTimeKind.Local).AddTicks(3877), false, "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 },
                    { new Guid("afca2679-f3ef-46d2-97e8-e478fd17ad31"), new Guid("5bcc1b1f-7349-41f7-a8aa-109c3621e85a"), new DateTime(2021, 3, 12, 15, 19, 34, 865, DateTimeKind.Local).AddTicks(3898), true, "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ", "https://www.geeky-gadgets.com/wp-content/uploads/2018/08/Wireless-Controller-Grey-Blue-2.jpg", false, "Xbox Controller", 599.0, 0.0 }
                });
        }
    }
}
