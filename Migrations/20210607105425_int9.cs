using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameQuest.Migrations
{
    public partial class int9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("458f0d38-a51b-4ac4-9212-9f4004394f75"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c4b06df-41aa-4ca6-aa03-c8cc23a3eea1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ca219fc-1c99-4488-a51e-981189dd1776"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3cf0ac7-e838-4c1f-a3aa-b0114d20108e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce264731-8e46-4734-b4c9-d9f17ba53e3b"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("7822a3c4-88d1-41fc-bdd1-864c31a9ba92"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("f92374e8-a74e-4898-8450-098e667af4d7"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("fd10202b-3d1a-468b-b51d-229a99e1ea9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c6a82ea-449b-4ebf-9968-862e816fe63e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("854a0d07-ba30-40ea-8725-62e3bf6ba9e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87c6069f-01a3-45ef-88cc-27420bda4069"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b765864-01ab-417a-abb5-9a217251c701"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d20f62c1-1813-48ae-ac8c-a4192f0f1625"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5a3d180c-a86c-4c22-87f0-cd5ea1dc5bd3");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "df8fdd95-629d-420a-bc15-d6dccf425089");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e2d31f37-056b-47d7-8b2f-828573c66b46");

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("af01c1c6-98f2-46ac-9f5a-5be918321dd8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("839cd9e5-f9f2-43e6-acba-d48ba1dd2496"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c990c11-9eae-4ec7-8fc9-ad5868ec1e02"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c56f7dbf-c548-426f-85ef-80665803660b"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("094867f6-ed1d-449d-8571-f60d8aa6def8"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("37d22b85-e315-4a8c-9a1b-c61774c80413"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5388070f-f0da-4ee5-b7eb-896b6b980925"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("17c006f6-e9b6-4491-b6ea-fc7be9cb9b2b"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3399790-a369-4b9e-a4de-eab8f139ff10"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0ab5c338-09d8-48ca-b30c-c27da3e779d0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a010e8e5-5b44-469f-9ab2-79e6047f5a8e"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("fd10202b-3d1a-468b-b51d-229a99e1ea9e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 19, 18, 7, 50, 53, DateTimeKind.Local).AddTicks(489), "", false, false, "About" },
                    { new Guid("f92374e8-a74e-4898-8450-098e667af4d7"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 19, 18, 7, 50, 53, DateTimeKind.Local).AddTicks(2248), "", false, false, "FAQ" },
                    { new Guid("7822a3c4-88d1-41fc-bdd1-864c31a9ba92"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 4, 19, 18, 7, 50, 53, DateTimeKind.Local).AddTicks(2279), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("37d22b85-e315-4a8c-9a1b-c61774c80413"), new DateTime(2021, 4, 19, 18, 7, 50, 50, DateTimeKind.Local).AddTicks(6842), "", "Nintendo" },
                    { new Guid("094867f6-ed1d-449d-8571-f60d8aa6def8"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(5381), "", "Playstation" },
                    { new Guid("e3399790-a369-4b9e-a4de-eab8f139ff10"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(5408), "", "Xbox" },
                    { new Guid("17c006f6-e9b6-4491-b6ea-fc7be9cb9b2b"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(5414), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e2d31f37-056b-47d7-8b2f-828573c66b46", "5a110a32-dee4-40a5-9b9a-47515febfeff", "Admin", "ADMIN" },
                    { "5a3d180c-a86c-4c22-87f0-cd5ea1dc5bd3", "421662ee-cedb-4fa8-a09c-49dd0e014475", "Customer", "CUSTOMER" },
                    { "df8fdd95-629d-420a-bc15-d6dccf425089", "291aff07-1948-4eaa-a3de-2964dcdd4baa", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("a010e8e5-5b44-469f-9ab2-79e6047f5a8e"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(6197), "", "Games" },
                    { new Guid("0ab5c338-09d8-48ca-b30c-c27da3e779d0"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(6910), "", "Accesories" },
                    { new Guid("5388070f-f0da-4ee5-b7eb-896b6b980925"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(6921), "", "Controllers" },
                    { new Guid("af01c1c6-98f2-46ac-9f5a-5be918321dd8"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(6930), "", "Console" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("458f0d38-a51b-4ac4-9212-9f4004394f75"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(7898), new Guid("37d22b85-e315-4a8c-9a1b-c61774c80413"), new Guid("a010e8e5-5b44-469f-9ab2-79e6047f5a8e") },
                    { new Guid("ce264731-8e46-4734-b4c9-d9f17ba53e3b"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(9110), new Guid("094867f6-ed1d-449d-8571-f60d8aa6def8"), new Guid("a010e8e5-5b44-469f-9ab2-79e6047f5a8e") },
                    { new Guid("9c990c11-9eae-4ec7-8fc9-ad5868ec1e02"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(9122), new Guid("e3399790-a369-4b9e-a4de-eab8f139ff10"), new Guid("a010e8e5-5b44-469f-9ab2-79e6047f5a8e") },
                    { new Guid("c56f7dbf-c548-426f-85ef-80665803660b"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(9126), new Guid("17c006f6-e9b6-4491-b6ea-fc7be9cb9b2b"), new Guid("a010e8e5-5b44-469f-9ab2-79e6047f5a8e") },
                    { new Guid("839cd9e5-f9f2-43e6-acba-d48ba1dd2496"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(9135), new Guid("e3399790-a369-4b9e-a4de-eab8f139ff10"), new Guid("0ab5c338-09d8-48ca-b30c-c27da3e779d0") },
                    { new Guid("c3cf0ac7-e838-4c1f-a3aa-b0114d20108e"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(9142), new Guid("17c006f6-e9b6-4491-b6ea-fc7be9cb9b2b"), new Guid("0ab5c338-09d8-48ca-b30c-c27da3e779d0") },
                    { new Guid("6c4b06df-41aa-4ca6-aa03-c8cc23a3eea1"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(9129), new Guid("37d22b85-e315-4a8c-9a1b-c61774c80413"), new Guid("5388070f-f0da-4ee5-b7eb-896b6b980925") },
                    { new Guid("9ca219fc-1c99-4488-a51e-981189dd1776"), new DateTime(2021, 4, 19, 18, 7, 50, 52, DateTimeKind.Local).AddTicks(9132), new Guid("094867f6-ed1d-449d-8571-f60d8aa6def8"), new Guid("5388070f-f0da-4ee5-b7eb-896b6b980925") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Deals", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("854a0d07-ba30-40ea-8725-62e3bf6ba9e2"), new Guid("9c990c11-9eae-4ec7-8fc9-ad5868ec1e02"), new DateTime(2021, 4, 19, 18, 7, 50, 53, DateTimeKind.Local).AddTicks(3049), false, "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("2c6a82ea-449b-4ebf-9968-862e816fe63e"), new Guid("9c990c11-9eae-4ec7-8fc9-ad5868ec1e02"), new DateTime(2021, 4, 19, 18, 7, 50, 53, DateTimeKind.Local).AddTicks(5819), true, "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("87c6069f-01a3-45ef-88cc-27420bda4069"), new Guid("c56f7dbf-c548-426f-85ef-80665803660b"), new DateTime(2021, 4, 19, 18, 7, 50, 53, DateTimeKind.Local).AddTicks(5784), false, "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("9b765864-01ab-417a-abb5-9a217251c701"), new Guid("c56f7dbf-c548-426f-85ef-80665803660b"), new DateTime(2021, 4, 19, 18, 7, 50, 53, DateTimeKind.Local).AddTicks(5839), true, "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 },
                    { new Guid("d20f62c1-1813-48ae-ac8c-a4192f0f1625"), new Guid("839cd9e5-f9f2-43e6-acba-d48ba1dd2496"), new DateTime(2021, 4, 19, 18, 7, 50, 53, DateTimeKind.Local).AddTicks(5862), true, "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ", "https://www.geeky-gadgets.com/wp-content/uploads/2018/08/Wireless-Controller-Grey-Blue-2.jpg", false, "Xbox Controller", 599.0, 0.0 }
                });
        }
    }
}
