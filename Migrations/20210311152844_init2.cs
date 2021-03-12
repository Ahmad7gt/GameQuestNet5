using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameQuest.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("247bbcab-0361-462c-8403-c4f1db9e8a94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ceac10a-ac19-4c01-a007-6210b625323a"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("02a8cfa6-28d9-4b09-a9f0-bde8ebbf5734"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("8d551941-de8d-48b4-aa76-5803a483d1b7"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("f25e49d0-f763-40ab-b0ce-8117f53021e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("145dac60-4055-4fdb-aefd-af19c34f5df1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52630fee-4e90-4e78-b631-e40d1cc19cd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58fc5376-1724-4848-a143-fe9ef9bb0bc9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8022908-31c8-4007-9cd2-98bf2559aade"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("35f2b18a-3ad7-494e-b2be-f89dd7d1c493"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("773a9da0-ae98-4b48-a9ac-527c9cee8d44"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c616c83b-ed19-44ce-8f8a-4a65dce9c5f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c9501a8-c12a-490c-9db7-3ca40bd039e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c75534c3-d341-49be-a7c6-b4cb15727113"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("6dc619dc-3cea-4637-ab0e-03272591c36e"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("cbba82d9-be24-46a0-b1f2-13ce027e3a6d"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("68ee4388-6fdd-490f-974d-1c9312c9af56"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("a0200076-d7cc-4bd1-9364-3859abfbedd7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d814d727-8dc8-4e5d-8676-06effec1f2c8"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("f25e49d0-f763-40ab-b0ce-8117f53021e7"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(6568), "", false, false, "About" },
                    { new Guid("02a8cfa6-28d9-4b09-a9f0-bde8ebbf5734"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(8312), "", false, false, "FAQ" },
                    { new Guid("8d551941-de8d-48b4-aa76-5803a483d1b7"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(8343), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6dc619dc-3cea-4637-ab0e-03272591c36e"), new DateTime(2021, 3, 11, 14, 17, 14, 742, DateTimeKind.Local).AddTicks(5158), "", "Nintendo" },
                    { new Guid("cbba82d9-be24-46a0-b1f2-13ce027e3a6d"), new DateTime(2021, 3, 11, 14, 17, 14, 744, DateTimeKind.Local).AddTicks(2917), "", "Playstation" },
                    { new Guid("a0200076-d7cc-4bd1-9364-3859abfbedd7"), new DateTime(2021, 3, 11, 14, 17, 14, 744, DateTimeKind.Local).AddTicks(2947), "", "Xbox" },
                    { new Guid("68ee4388-6fdd-490f-974d-1c9312c9af56"), new DateTime(2021, 3, 11, 14, 17, 14, 744, DateTimeKind.Local).AddTicks(2951), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("d814d727-8dc8-4e5d-8676-06effec1f2c8"), new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(2268), "", "Games" },
                    { new Guid("773a9da0-ae98-4b48-a9ac-527c9cee8d44"), new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(3030), "", "Accesories" },
                    { new Guid("c616c83b-ed19-44ce-8f8a-4a65dce9c5f4"), new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(3042), "", "Controllers" },
                    { new Guid("35f2b18a-3ad7-494e-b2be-f89dd7d1c493"), new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(3045), "", "Console" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("2ceac10a-ac19-4c01-a007-6210b625323a"), new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(4081), new Guid("6dc619dc-3cea-4637-ab0e-03272591c36e"), new Guid("d814d727-8dc8-4e5d-8676-06effec1f2c8") },
                    { new Guid("247bbcab-0361-462c-8403-c4f1db9e8a94"), new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(5274), new Guid("cbba82d9-be24-46a0-b1f2-13ce027e3a6d"), new Guid("d814d727-8dc8-4e5d-8676-06effec1f2c8") },
                    { new Guid("5c9501a8-c12a-490c-9db7-3ca40bd039e3"), new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(5287), new Guid("a0200076-d7cc-4bd1-9364-3859abfbedd7"), new Guid("d814d727-8dc8-4e5d-8676-06effec1f2c8") },
                    { new Guid("c75534c3-d341-49be-a7c6-b4cb15727113"), new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(5290), new Guid("68ee4388-6fdd-490f-974d-1c9312c9af56"), new Guid("d814d727-8dc8-4e5d-8676-06effec1f2c8") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("58fc5376-1724-4848-a143-fe9ef9bb0bc9"), new Guid("5c9501a8-c12a-490c-9db7-3ca40bd039e3"), new DateTime(2021, 3, 11, 14, 17, 14, 745, DateTimeKind.Local).AddTicks(9109), "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("145dac60-4055-4fdb-aefd-af19c34f5df1"), new Guid("5c9501a8-c12a-490c-9db7-3ca40bd039e3"), new DateTime(2021, 3, 11, 14, 17, 14, 746, DateTimeKind.Local).AddTicks(1489), "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("c8022908-31c8-4007-9cd2-98bf2559aade"), new Guid("c75534c3-d341-49be-a7c6-b4cb15727113"), new DateTime(2021, 3, 11, 14, 17, 14, 746, DateTimeKind.Local).AddTicks(1453), "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("52630fee-4e90-4e78-b631-e40d1cc19cd7"), new Guid("c75534c3-d341-49be-a7c6-b4cb15727113"), new DateTime(2021, 3, 11, 14, 17, 14, 746, DateTimeKind.Local).AddTicks(1509), "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 }
                });
        }
    }
}
