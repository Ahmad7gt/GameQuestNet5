using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameQuest.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b62bcdd-6840-4322-9fe5-2d4cbc35db44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("15e69ffa-904b-4b82-a33c-9aa39420dad7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("186eec0a-7487-4f5c-aa55-a7339b9a9962"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2aca9f8e-c6b5-44bb-8527-ee035f2d1cf4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5aff1c74-cd10-4ef6-bdb4-20242fe54659"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0130686-82b1-4140-8115-924692a1e807"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("0e4d29b6-4ad8-4625-a835-1c98e5382fb1"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("77aaf122-ba22-45f0-ac2c-60d4385444c2"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("eba18fcb-6ca4-4872-88e2-f1337093f7e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00d5a519-05b6-4e96-bb31-273b1d26a549"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02a021d1-f057-454b-a393-74562be85fde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("452cf9eb-0f15-4ed0-93cf-5464540a15bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71e7028e-829a-4d6a-a813-10625a902aaa"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("178663a4-9c88-4a26-8dec-6d005b15a514"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cbdcd3e1-4bb0-4b01-89e7-3c19ddbd7bca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc3b5827-0dd8-4193-9149-8c6c21ec3b26"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("53d13caa-07d6-4b93-8a27-797970dece44"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a72a467-3d2b-4a22-8cca-33b69a3911ce"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("106b3a9f-d4a3-4ef0-bd2f-d015b9042395"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("803737d5-c0ab-4138-894a-ffdd8ac9724c"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("4cf3e05d-535c-42a6-bd83-816ce165e1c8"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce9d420e-8de1-42ea-b667-0276e827c559"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("490926ad-020b-448f-9678-a1b245f0a533"));

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "Title" },
                values: new object[,]
                {
                    { new Guid("8d7dcde4-b1bd-4cc8-82de-3ffc521fdc2d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(8021), "", false, false, "About" },
                    { new Guid("74d29da4-f825-4b66-95f0-99d88f924a82"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(9742), "", false, false, "FAQ" },
                    { new Guid("9fce354c-aaac-44d7-b645-58930fbf54c1"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(9772), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("795a41fe-4f99-4165-8589-28553b0c350e"), new DateTime(2021, 3, 11, 16, 42, 26, 441, DateTimeKind.Local).AddTicks(6947), "", "Nintendo" },
                    { new Guid("c688e03a-a49e-44f4-b859-3b74ea9d2387"), new DateTime(2021, 3, 11, 16, 42, 26, 443, DateTimeKind.Local).AddTicks(4593), "", "Playstation" },
                    { new Guid("6cd5be82-ec93-43db-ac48-3847ed2547ab"), new DateTime(2021, 3, 11, 16, 42, 26, 443, DateTimeKind.Local).AddTicks(4621), "", "Xbox" },
                    { new Guid("1bb97cc7-1320-46b1-b20c-73bb7b7a2ad5"), new DateTime(2021, 3, 11, 16, 42, 26, 443, DateTimeKind.Local).AddTicks(4626), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("c0132582-812a-4b7f-bbce-d39a13f7e8ac"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(3708), "", "Games" },
                    { new Guid("19e8efd1-349b-45c4-8b00-5f757d10d0f8"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(4469), "", "Accesories" },
                    { new Guid("83956d64-585b-4933-bcbc-dd8369f182b8"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(4480), "", "Controllers" },
                    { new Guid("e4b7d776-d4d3-4b9c-9590-95ab5abff45d"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(4483), "", "Console" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("fc3182dd-7240-4618-afc6-ec36b2587edc"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(5503), new Guid("795a41fe-4f99-4165-8589-28553b0c350e"), new Guid("c0132582-812a-4b7f-bbce-d39a13f7e8ac") },
                    { new Guid("516e2427-158d-4e97-885e-97924553dfc0"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(6711), new Guid("c688e03a-a49e-44f4-b859-3b74ea9d2387"), new Guid("c0132582-812a-4b7f-bbce-d39a13f7e8ac") },
                    { new Guid("345983ac-f325-4d1f-b3e9-c3e8858c63e6"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(6723), new Guid("6cd5be82-ec93-43db-ac48-3847ed2547ab"), new Guid("c0132582-812a-4b7f-bbce-d39a13f7e8ac") },
                    { new Guid("83d0866b-a618-4a0e-9e2d-581413c334e5"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(6727), new Guid("1bb97cc7-1320-46b1-b20c-73bb7b7a2ad5"), new Guid("c0132582-812a-4b7f-bbce-d39a13f7e8ac") },
                    { new Guid("54885de2-60b8-4108-8667-945b74de5bb0"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(6735), new Guid("6cd5be82-ec93-43db-ac48-3847ed2547ab"), new Guid("19e8efd1-349b-45c4-8b00-5f757d10d0f8") },
                    { new Guid("e525a3fd-3b78-4683-9f67-bd243e648341"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(6738), new Guid("1bb97cc7-1320-46b1-b20c-73bb7b7a2ad5"), new Guid("19e8efd1-349b-45c4-8b00-5f757d10d0f8") },
                    { new Guid("8d01b1de-efc8-4758-acff-18d667966b3f"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(6730), new Guid("795a41fe-4f99-4165-8589-28553b0c350e"), new Guid("83956d64-585b-4933-bcbc-dd8369f182b8") },
                    { new Guid("401629a7-d813-49f5-8ac8-c118331339c0"), new DateTime(2021, 3, 11, 16, 42, 26, 444, DateTimeKind.Local).AddTicks(6732), new Guid("c688e03a-a49e-44f4-b859-3b74ea9d2387"), new Guid("83956d64-585b-4933-bcbc-dd8369f182b8") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("a24851f8-f86f-4816-a67f-61ce7bc89c5b"), new Guid("345983ac-f325-4d1f-b3e9-c3e8858c63e6"), new DateTime(2021, 3, 11, 16, 42, 26, 445, DateTimeKind.Local).AddTicks(554), "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("2279a094-37bd-49c6-aa6d-1b6bdae7df98"), new Guid("345983ac-f325-4d1f-b3e9-c3e8858c63e6"), new DateTime(2021, 3, 11, 16, 42, 26, 445, DateTimeKind.Local).AddTicks(2976), "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("e14d3c8d-d861-4c48-8d94-2162e6304e83"), new Guid("83d0866b-a618-4a0e-9e2d-581413c334e5"), new DateTime(2021, 3, 11, 16, 42, 26, 445, DateTimeKind.Local).AddTicks(2942), "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("a43174f6-8e89-4397-a641-966b981e9d5b"), new Guid("83d0866b-a618-4a0e-9e2d-581413c334e5"), new DateTime(2021, 3, 11, 16, 42, 26, 445, DateTimeKind.Local).AddTicks(2995), "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 },
                    { new Guid("f5ddb180-c74d-4ba3-9656-1d26c62d833d"), new Guid("54885de2-60b8-4108-8667-945b74de5bb0"), new DateTime(2021, 3, 11, 16, 42, 26, 445, DateTimeKind.Local).AddTicks(3014), "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ", "https://www.geeky-gadgets.com/wp-content/uploads/2018/08/Wireless-Controller-Grey-Blue-2.jpg", false, "Xbox Controller", 599.0, 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("401629a7-d813-49f5-8ac8-c118331339c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("516e2427-158d-4e97-885e-97924553dfc0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d01b1de-efc8-4758-acff-18d667966b3f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e525a3fd-3b78-4683-9f67-bd243e648341"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc3182dd-7240-4618-afc6-ec36b2587edc"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("74d29da4-f825-4b66-95f0-99d88f924a82"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("8d7dcde4-b1bd-4cc8-82de-3ffc521fdc2d"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("9fce354c-aaac-44d7-b645-58930fbf54c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2279a094-37bd-49c6-aa6d-1b6bdae7df98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a24851f8-f86f-4816-a67f-61ce7bc89c5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a43174f6-8e89-4397-a641-966b981e9d5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e14d3c8d-d861-4c48-8d94-2162e6304e83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5ddb180-c74d-4ba3-9656-1d26c62d833d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4b7d776-d4d3-4b9c-9590-95ab5abff45d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("345983ac-f325-4d1f-b3e9-c3e8858c63e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54885de2-60b8-4108-8667-945b74de5bb0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83d0866b-a618-4a0e-9e2d-581413c334e5"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("795a41fe-4f99-4165-8589-28553b0c350e"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("c688e03a-a49e-44f4-b859-3b74ea9d2387"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("83956d64-585b-4933-bcbc-dd8369f182b8"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("1bb97cc7-1320-46b1-b20c-73bb7b7a2ad5"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("6cd5be82-ec93-43db-ac48-3847ed2547ab"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("19e8efd1-349b-45c4-8b00-5f757d10d0f8"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0132582-812a-4b7f-bbce-d39a13f7e8ac"));

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "Title" },
                values: new object[,]
                {
                    { new Guid("77aaf122-ba22-45f0-ac2c-60d4385444c2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(4883), "", false, false, "About" },
                    { new Guid("eba18fcb-6ca4-4872-88e2-f1337093f7e7"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(6683), "", false, false, "FAQ" },
                    { new Guid("0e4d29b6-4ad8-4625-a835-1c98e5382fb1"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(6714), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("53d13caa-07d6-4b93-8a27-797970dece44"), new DateTime(2021, 3, 11, 16, 28, 44, 279, DateTimeKind.Local).AddTicks(3734), "", "Nintendo" },
                    { new Guid("5a72a467-3d2b-4a22-8cca-33b69a3911ce"), new DateTime(2021, 3, 11, 16, 28, 44, 281, DateTimeKind.Local).AddTicks(1422), "", "Playstation" },
                    { new Guid("ce9d420e-8de1-42ea-b667-0276e827c559"), new DateTime(2021, 3, 11, 16, 28, 44, 281, DateTimeKind.Local).AddTicks(1449), "", "Xbox" },
                    { new Guid("4cf3e05d-535c-42a6-bd83-816ce165e1c8"), new DateTime(2021, 3, 11, 16, 28, 44, 281, DateTimeKind.Local).AddTicks(1454), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("490926ad-020b-448f-9678-a1b245f0a533"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(489), "", "Games" },
                    { new Guid("106b3a9f-d4a3-4ef0-bd2f-d015b9042395"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(1257), "", "Accesories" },
                    { new Guid("803737d5-c0ab-4138-894a-ffdd8ac9724c"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(1268), "", "Controllers" },
                    { new Guid("178663a4-9c88-4a26-8dec-6d005b15a514"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(1272), "", "Console" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("15e69ffa-904b-4b82-a33c-9aa39420dad7"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(2233), new Guid("53d13caa-07d6-4b93-8a27-797970dece44"), new Guid("490926ad-020b-448f-9678-a1b245f0a533") },
                    { new Guid("2aca9f8e-c6b5-44bb-8527-ee035f2d1cf4"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(3462), new Guid("5a72a467-3d2b-4a22-8cca-33b69a3911ce"), new Guid("490926ad-020b-448f-9678-a1b245f0a533") },
                    { new Guid("dc3b5827-0dd8-4193-9149-8c6c21ec3b26"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(3474), new Guid("ce9d420e-8de1-42ea-b667-0276e827c559"), new Guid("490926ad-020b-448f-9678-a1b245f0a533") },
                    { new Guid("cbdcd3e1-4bb0-4b01-89e7-3c19ddbd7bca"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(3476), new Guid("4cf3e05d-535c-42a6-bd83-816ce165e1c8"), new Guid("490926ad-020b-448f-9678-a1b245f0a533") },
                    { new Guid("e0130686-82b1-4140-8115-924692a1e807"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(3485), new Guid("ce9d420e-8de1-42ea-b667-0276e827c559"), new Guid("106b3a9f-d4a3-4ef0-bd2f-d015b9042395") },
                    { new Guid("0b62bcdd-6840-4322-9fe5-2d4cbc35db44"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(3488), new Guid("4cf3e05d-535c-42a6-bd83-816ce165e1c8"), new Guid("106b3a9f-d4a3-4ef0-bd2f-d015b9042395") },
                    { new Guid("5aff1c74-cd10-4ef6-bdb4-20242fe54659"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(3479), new Guid("53d13caa-07d6-4b93-8a27-797970dece44"), new Guid("803737d5-c0ab-4138-894a-ffdd8ac9724c") },
                    { new Guid("186eec0a-7487-4f5c-aa55-a7339b9a9962"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(3482), new Guid("5a72a467-3d2b-4a22-8cca-33b69a3911ce"), new Guid("803737d5-c0ab-4138-894a-ffdd8ac9724c") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("452cf9eb-0f15-4ed0-93cf-5464540a15bd"), new Guid("dc3b5827-0dd8-4193-9149-8c6c21ec3b26"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(7456), "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("71e7028e-829a-4d6a-a813-10625a902aaa"), new Guid("dc3b5827-0dd8-4193-9149-8c6c21ec3b26"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(9874), "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("00d5a519-05b6-4e96-bb31-273b1d26a549"), new Guid("cbdcd3e1-4bb0-4b01-89e7-3c19ddbd7bca"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(9842), "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("02a021d1-f057-454b-a393-74562be85fde"), new Guid("cbdcd3e1-4bb0-4b01-89e7-3c19ddbd7bca"), new DateTime(2021, 3, 11, 16, 28, 44, 282, DateTimeKind.Local).AddTicks(9893), "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 }
                });
        }
    }
}
