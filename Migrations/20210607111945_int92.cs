using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameQuest.Migrations
{
    public partial class int92 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41c1398a-d19c-407e-aaeb-6c9a8bd7f95f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7697d86b-f1fe-4349-9651-cf1c52fbb064"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a20f53f5-d8a2-4e95-a84a-7489b529912d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce8f50f1-4c7b-4021-91c2-b21a3392b065"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eca450b0-3e1d-4be6-8bf7-dee28897d266"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("434da7ed-325a-40fa-8c87-5fb570017c97"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("d4cf0daa-4dc8-4d81-bc94-77716afda0bd"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("ee2b9625-28fc-4e4e-add7-f4e851d53c70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28ac7b70-27ca-4fd4-937a-3bc18f74d904"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47752d01-0d6a-4428-884e-b2da4e14194f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baf3a81e-a8d0-46a7-8cb2-532256327a66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d08e234d-68ad-45e3-a477-65eacf21ab06"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fccf3457-13e9-4467-966a-7896691f28ae"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "23028413-9c5e-432c-877a-7370d2f08e7e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "998eaa1a-4d27-4723-8147-162d0e3ac19c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f0ec90ac-d63b-4765-9c74-a46478411e87");

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("357c4233-1f11-4f36-bc83-62618dadedfe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a525830-bab6-4954-97cf-2b4ad4a0cfcb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bf0ca8f-0433-4e8b-b2a9-11e2ab044054"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c866d41-2bb2-495f-91fc-9a089d633637"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("31d7347e-3bd6-4803-b4b6-a9ba22c9fcdd"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("a8796c3d-b160-443a-bf6b-40f0e0dc1137"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e5e1b8a-6a35-4db7-91d2-f0a6999a0024"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("a48d48db-216f-4223-84d5-54b984ea963f"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9d54f73-9590-4827-95c3-56cb0047b1de"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce7278e0-c191-4dcc-b864-75ae2469a279"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f56b0275-a0f3-4db1-a8e9-bff12909fcdf"));

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "Title" },
                values: new object[,]
                {
                    { new Guid("517e6321-83f9-45c1-8f27-b387023f0b0a"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(2164), "", false, false, "About" },
                    { new Guid("805761b8-1ab8-4611-8e6a-0cf7116ef351"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(3877), "", false, false, "FAQ" },
                    { new Guid("3fd2530d-b9f5-4178-9c74-3848701009d1"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(3908), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("be3246c2-af60-4379-b2e3-7ec5830547cf"), new DateTime(2021, 6, 7, 13, 19, 45, 229, DateTimeKind.Local).AddTicks(8753), "", "Nintendo" },
                    { new Guid("2cb4fdab-0ad7-44ba-be97-8e3bdda59a10"), new DateTime(2021, 6, 7, 13, 19, 45, 231, DateTimeKind.Local).AddTicks(7147), "", "Playstation" },
                    { new Guid("2ac55fe7-c35b-424b-ba7a-1b79fcbf6b45"), new DateTime(2021, 6, 7, 13, 19, 45, 231, DateTimeKind.Local).AddTicks(7177), "", "Xbox" },
                    { new Guid("45d556af-71c0-4d3f-8a07-b2c5d338b8e4"), new DateTime(2021, 6, 7, 13, 19, 45, 231, DateTimeKind.Local).AddTicks(7183), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0bc7e17e-6a10-4a83-a9ac-bcc1e574268f", "7d7cd4cf-d756-4681-b5e6-da9f43a8640b", "Admin", "ADMIN" },
                    { "55103d4d-b86d-4874-afee-c6b2087874e0", "8ebb31b8-fb29-41f8-b03f-c92ea64de2ee", "Customer", "CUSTOMER" },
                    { "6689cd7e-44b8-4f1f-8425-83e8f50f5ea7", "f2cae3a7-04d8-4d4c-8289-5010a51b146e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("d009f05c-c08c-484e-b0b2-40725a824bf3"), new DateTime(2021, 6, 7, 13, 19, 45, 231, DateTimeKind.Local).AddTicks(7957), "", "Games" },
                    { new Guid("90498246-2c4f-4dac-a141-dbc92048afd3"), new DateTime(2021, 6, 7, 13, 19, 45, 231, DateTimeKind.Local).AddTicks(8649), "", "Accesories" },
                    { new Guid("80bcabfb-1967-4c38-806b-4b85b05c76e1"), new DateTime(2021, 6, 7, 13, 19, 45, 231, DateTimeKind.Local).AddTicks(8660), "", "Controllers" },
                    { new Guid("1818d458-0773-4d3c-bfad-bd43d3e36149"), new DateTime(2021, 6, 7, 13, 19, 45, 231, DateTimeKind.Local).AddTicks(8669), "", "Console" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("d79a9e83-5ff3-46a8-9b8b-a50ea39cf2af"), new DateTime(2021, 6, 7, 13, 19, 45, 231, DateTimeKind.Local).AddTicks(9657), new Guid("be3246c2-af60-4379-b2e3-7ec5830547cf"), new Guid("d009f05c-c08c-484e-b0b2-40725a824bf3") },
                    { new Guid("fcf5014a-f0cf-4c71-ab12-b99d354a9e28"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(842), new Guid("2cb4fdab-0ad7-44ba-be97-8e3bdda59a10"), new Guid("d009f05c-c08c-484e-b0b2-40725a824bf3") },
                    { new Guid("db621865-a293-4156-8df6-7d005495b036"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(854), new Guid("2ac55fe7-c35b-424b-ba7a-1b79fcbf6b45"), new Guid("d009f05c-c08c-484e-b0b2-40725a824bf3") },
                    { new Guid("70156b17-5a70-4622-bc9c-074b91a88acf"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(858), new Guid("45d556af-71c0-4d3f-8a07-b2c5d338b8e4"), new Guid("d009f05c-c08c-484e-b0b2-40725a824bf3") },
                    { new Guid("41c77b24-7fd4-4380-ac5f-545537e835a2"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(867), new Guid("2ac55fe7-c35b-424b-ba7a-1b79fcbf6b45"), new Guid("90498246-2c4f-4dac-a141-dbc92048afd3") },
                    { new Guid("19bb2b32-73ea-4f57-9451-73181797bb9d"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(875), new Guid("45d556af-71c0-4d3f-8a07-b2c5d338b8e4"), new Guid("90498246-2c4f-4dac-a141-dbc92048afd3") },
                    { new Guid("d7f4256a-28a0-4e11-ac26-136349fbfbf0"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(861), new Guid("be3246c2-af60-4379-b2e3-7ec5830547cf"), new Guid("80bcabfb-1967-4c38-806b-4b85b05c76e1") },
                    { new Guid("8ce2013a-dde2-4b10-a50d-be13a09e2b2a"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(864), new Guid("2cb4fdab-0ad7-44ba-be97-8e3bdda59a10"), new Guid("80bcabfb-1967-4c38-806b-4b85b05c76e1") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Deals", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("543c8d84-6e24-42e8-ad2e-e93b4ca5458b"), new Guid("db621865-a293-4156-8df6-7d005495b036"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(4667), false, "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("211b2afd-94e8-4215-b0ec-e16486c1e01d"), new Guid("db621865-a293-4156-8df6-7d005495b036"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(7363), true, "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("b8fd98a3-9fb3-4962-b129-6b6996f1e178"), new Guid("70156b17-5a70-4622-bc9c-074b91a88acf"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(7330), false, "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("d508a61e-f3b7-447c-838a-eb6ef0469dfc"), new Guid("70156b17-5a70-4622-bc9c-074b91a88acf"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(7412), true, "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 },
                    { new Guid("2e29824f-e1a7-4b8e-a796-1680ca75c478"), new Guid("41c77b24-7fd4-4380-ac5f-545537e835a2"), new DateTime(2021, 6, 7, 13, 19, 45, 232, DateTimeKind.Local).AddTicks(7436), true, "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ", "https://mspoweruser.com/wp-content/uploads/2018/07/xbox-diamond-white-controller.jpg", false, "Xbox Controller", 599.0, 20.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19bb2b32-73ea-4f57-9451-73181797bb9d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ce2013a-dde2-4b10-a50d-be13a09e2b2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d79a9e83-5ff3-46a8-9b8b-a50ea39cf2af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7f4256a-28a0-4e11-ac26-136349fbfbf0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcf5014a-f0cf-4c71-ab12-b99d354a9e28"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("3fd2530d-b9f5-4178-9c74-3848701009d1"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("517e6321-83f9-45c1-8f27-b387023f0b0a"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("805761b8-1ab8-4611-8e6a-0cf7116ef351"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("211b2afd-94e8-4215-b0ec-e16486c1e01d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e29824f-e1a7-4b8e-a796-1680ca75c478"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("543c8d84-6e24-42e8-ad2e-e93b4ca5458b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8fd98a3-9fb3-4962-b129-6b6996f1e178"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d508a61e-f3b7-447c-838a-eb6ef0469dfc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0bc7e17e-6a10-4a83-a9ac-bcc1e574268f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "55103d4d-b86d-4874-afee-c6b2087874e0");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6689cd7e-44b8-4f1f-8425-83e8f50f5ea7");

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1818d458-0773-4d3c-bfad-bd43d3e36149"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41c77b24-7fd4-4380-ac5f-545537e835a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70156b17-5a70-4622-bc9c-074b91a88acf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db621865-a293-4156-8df6-7d005495b036"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("2cb4fdab-0ad7-44ba-be97-8e3bdda59a10"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("be3246c2-af60-4379-b2e3-7ec5830547cf"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("80bcabfb-1967-4c38-806b-4b85b05c76e1"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("2ac55fe7-c35b-424b-ba7a-1b79fcbf6b45"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("45d556af-71c0-4d3f-8a07-b2c5d338b8e4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("90498246-2c4f-4dac-a141-dbc92048afd3"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d009f05c-c08c-484e-b0b2-40725a824bf3"));

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "Title" },
                values: new object[,]
                {
                    { new Guid("ee2b9625-28fc-4e4e-add7-f4e851d53c70"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(3614), "", false, false, "About" },
                    { new Guid("d4cf0daa-4dc8-4d81-bc94-77716afda0bd"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(5386), "", false, false, "FAQ" },
                    { new Guid("434da7ed-325a-40fa-8c87-5fb570017c97"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(5415), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("31d7347e-3bd6-4803-b4b6-a9ba22c9fcdd"), new DateTime(2021, 6, 7, 12, 54, 25, 384, DateTimeKind.Local).AddTicks(9544), "", "Nintendo" },
                    { new Guid("a8796c3d-b160-443a-bf6b-40f0e0dc1137"), new DateTime(2021, 6, 7, 12, 54, 25, 386, DateTimeKind.Local).AddTicks(8419), "", "Playstation" },
                    { new Guid("a48d48db-216f-4223-84d5-54b984ea963f"), new DateTime(2021, 6, 7, 12, 54, 25, 386, DateTimeKind.Local).AddTicks(8449), "", "Xbox" },
                    { new Guid("e9d54f73-9590-4827-95c3-56cb0047b1de"), new DateTime(2021, 6, 7, 12, 54, 25, 386, DateTimeKind.Local).AddTicks(8455), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23028413-9c5e-432c-877a-7370d2f08e7e", "d1c6e57b-1785-422b-8259-589d41341b8a", "Admin", "ADMIN" },
                    { "f0ec90ac-d63b-4765-9c74-a46478411e87", "6b88c5ca-0113-41ac-9939-c8647d522050", "Customer", "CUSTOMER" },
                    { "998eaa1a-4d27-4723-8147-162d0e3ac19c", "5c663c8b-d688-4a41-8ead-b3fe4c313b18", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("f56b0275-a0f3-4db1-a8e9-bff12909fcdf"), new DateTime(2021, 6, 7, 12, 54, 25, 386, DateTimeKind.Local).AddTicks(9302), "", "Games" },
                    { new Guid("ce7278e0-c191-4dcc-b864-75ae2469a279"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(36), "", "Accesories" },
                    { new Guid("9e5e1b8a-6a35-4db7-91d2-f0a6999a0024"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(77), "", "Controllers" },
                    { new Guid("357c4233-1f11-4f36-bc83-62618dadedfe"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(87), "", "Console" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("a20f53f5-d8a2-4e95-a84a-7489b529912d"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(1054), new Guid("31d7347e-3bd6-4803-b4b6-a9ba22c9fcdd"), new Guid("f56b0275-a0f3-4db1-a8e9-bff12909fcdf") },
                    { new Guid("7697d86b-f1fe-4349-9651-cf1c52fbb064"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(2256), new Guid("a8796c3d-b160-443a-bf6b-40f0e0dc1137"), new Guid("f56b0275-a0f3-4db1-a8e9-bff12909fcdf") },
                    { new Guid("1a525830-bab6-4954-97cf-2b4ad4a0cfcb"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(2267), new Guid("a48d48db-216f-4223-84d5-54b984ea963f"), new Guid("f56b0275-a0f3-4db1-a8e9-bff12909fcdf") },
                    { new Guid("2c866d41-2bb2-495f-91fc-9a089d633637"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(2270), new Guid("e9d54f73-9590-4827-95c3-56cb0047b1de"), new Guid("f56b0275-a0f3-4db1-a8e9-bff12909fcdf") },
                    { new Guid("1bf0ca8f-0433-4e8b-b2a9-11e2ab044054"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(2280), new Guid("a48d48db-216f-4223-84d5-54b984ea963f"), new Guid("ce7278e0-c191-4dcc-b864-75ae2469a279") },
                    { new Guid("ce8f50f1-4c7b-4021-91c2-b21a3392b065"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(2288), new Guid("e9d54f73-9590-4827-95c3-56cb0047b1de"), new Guid("ce7278e0-c191-4dcc-b864-75ae2469a279") },
                    { new Guid("eca450b0-3e1d-4be6-8bf7-dee28897d266"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(2274), new Guid("31d7347e-3bd6-4803-b4b6-a9ba22c9fcdd"), new Guid("9e5e1b8a-6a35-4db7-91d2-f0a6999a0024") },
                    { new Guid("41c1398a-d19c-407e-aaeb-6c9a8bd7f95f"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(2277), new Guid("a8796c3d-b160-443a-bf6b-40f0e0dc1137"), new Guid("9e5e1b8a-6a35-4db7-91d2-f0a6999a0024") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Deals", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("fccf3457-13e9-4467-966a-7896691f28ae"), new Guid("1a525830-bab6-4954-97cf-2b4ad4a0cfcb"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(6199), false, "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("47752d01-0d6a-4428-884e-b2da4e14194f"), new Guid("1a525830-bab6-4954-97cf-2b4ad4a0cfcb"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(8994), true, "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("28ac7b70-27ca-4fd4-937a-3bc18f74d904"), new Guid("2c866d41-2bb2-495f-91fc-9a089d633637"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(8959), false, "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("d08e234d-68ad-45e3-a477-65eacf21ab06"), new Guid("2c866d41-2bb2-495f-91fc-9a089d633637"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(9013), true, "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 },
                    { new Guid("baf3a81e-a8d0-46a7-8cb2-532256327a66"), new Guid("1bf0ca8f-0433-4e8b-b2a9-11e2ab044054"), new DateTime(2021, 6, 7, 12, 54, 25, 387, DateTimeKind.Local).AddTicks(9035), true, "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ", "https://mspoweruser.com/wp-content/uploads/2018/07/xbox-diamond-white-controller.jpg", false, "Xbox Controller", 599.0, 20.0 }
                });
        }
    }
}
