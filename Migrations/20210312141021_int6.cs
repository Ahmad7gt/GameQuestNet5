using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameQuest.Migrations
{
    public partial class int6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Deals",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Body", "Created", "ImageUrl", "IsInMenu", "IsPublished", "Title" },
                values: new object[,]
                {
                    { new Guid("bda58cce-b941-403f-a393-282ec49067dc"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 12, 15, 10, 20, 823, DateTimeKind.Local).AddTicks(1302), "", false, false, "About" },
                    { new Guid("e48674f8-f968-457e-9104-ea6ada8c6ed5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 12, 15, 10, 20, 823, DateTimeKind.Local).AddTicks(3079), "", false, false, "FAQ" },
                    { new Guid("db4b4435-40fd-4587-a5a8-486b5add9bcc"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque cursus erat non congue efficitur. Nulla sollicitudin sit amet dolor sed vestibulum. Aenean laoreet, nibh ac hendrerit egestas, metus urna semper orci, nec aliquet urna tellus at nibh. Vivamus vel sapien eget libero cursus hendrerit sed at quam. Etiam nec turpis urna. Donec at lacus in nibh cursus ullamcorper eget vitae lorem. In congue consectetur purus vitae porta. Donec volutpat rhoncus nisl, et placerat tellus fringilla et.", new DateTime(2021, 3, 12, 15, 10, 20, 823, DateTimeKind.Local).AddTicks(3110), "https://puppypetdog.com/wp-content/uploads/2019/11/contact-header-image.jpg", false, false, "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0d7d232b-97dc-4003-8f4d-dde4b2a6f010"), new DateTime(2021, 3, 12, 15, 10, 20, 819, DateTimeKind.Local).AddTicks(9551), "", "Nintendo" },
                    { new Guid("8ac7c9f7-fbba-4ba6-920a-3a6886b3ef7c"), new DateTime(2021, 3, 12, 15, 10, 20, 821, DateTimeKind.Local).AddTicks(7446), "", "Playstation" },
                    { new Guid("27720af0-9eae-4cd9-9260-fc94d98b2f77"), new DateTime(2021, 3, 12, 15, 10, 20, 821, DateTimeKind.Local).AddTicks(7473), "", "Xbox" },
                    { new Guid("fa81d120-385a-4eef-b36b-f4753af085e9"), new DateTime(2021, 3, 12, 15, 10, 20, 821, DateTimeKind.Local).AddTicks(7477), "", "PC" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("dc2dadac-8c3a-44e3-a12d-eae1cb5d6394"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(6796), "", "Games" },
                    { new Guid("3800ba5b-ea51-4372-a93f-10a7fabdd64e"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(7576), "", "Accesories" },
                    { new Guid("04ec2bd1-cbe2-4866-bad7-0a4591e19c09"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(7588), "", "Controllers" },
                    { new Guid("84633f37-2410-43a4-a4e4-909f246544f7"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(7591), "", "Console" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "MainCategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("1470b870-fb8b-4467-bcd8-fb2444d4a4f2"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(8555), new Guid("0d7d232b-97dc-4003-8f4d-dde4b2a6f010"), new Guid("dc2dadac-8c3a-44e3-a12d-eae1cb5d6394") },
                    { new Guid("fd5158e4-6379-483b-b7c4-310933c281bb"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(9899), new Guid("8ac7c9f7-fbba-4ba6-920a-3a6886b3ef7c"), new Guid("dc2dadac-8c3a-44e3-a12d-eae1cb5d6394") },
                    { new Guid("e7f44a2a-2ed8-48a1-9a96-000e13648f0a"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(9911), new Guid("27720af0-9eae-4cd9-9260-fc94d98b2f77"), new Guid("dc2dadac-8c3a-44e3-a12d-eae1cb5d6394") },
                    { new Guid("f3630695-a3c4-41cc-ae90-fff08d9265e9"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(9914), new Guid("fa81d120-385a-4eef-b36b-f4753af085e9"), new Guid("dc2dadac-8c3a-44e3-a12d-eae1cb5d6394") },
                    { new Guid("714379a9-ffb9-4126-9e4a-8d1a0011e226"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(9923), new Guid("27720af0-9eae-4cd9-9260-fc94d98b2f77"), new Guid("3800ba5b-ea51-4372-a93f-10a7fabdd64e") },
                    { new Guid("960b8445-a9be-478b-a37f-92cdc7933df0"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(9925), new Guid("fa81d120-385a-4eef-b36b-f4753af085e9"), new Guid("3800ba5b-ea51-4372-a93f-10a7fabdd64e") },
                    { new Guid("6e96142e-4e35-48a2-9038-460376af3741"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(9917), new Guid("0d7d232b-97dc-4003-8f4d-dde4b2a6f010"), new Guid("04ec2bd1-cbe2-4866-bad7-0a4591e19c09") },
                    { new Guid("4cd8725e-7f7f-47a1-a4cc-767cd6900ae0"), new DateTime(2021, 3, 12, 15, 10, 20, 822, DateTimeKind.Local).AddTicks(9920), new Guid("8ac7c9f7-fbba-4ba6-920a-3a6886b3ef7c"), new Guid("04ec2bd1-cbe2-4866-bad7-0a4591e19c09") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Deals", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("7a48e9f1-853c-4b53-8ca2-11a37907f81a"), new Guid("e7f44a2a-2ed8-48a1-9a96-000e13648f0a"), new DateTime(2021, 3, 12, 15, 10, 20, 823, DateTimeKind.Local).AddTicks(3920), true, "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://halo.wiki.gallery/images/6/6a/Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("9033d6ec-db4c-4198-8fd6-8574d6afe4ef"), new Guid("e7f44a2a-2ed8-48a1-9a96-000e13648f0a"), new DateTime(2021, 3, 12, 15, 10, 20, 823, DateTimeKind.Local).AddTicks(6626), true, "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://upload.wikimedia.org/wikipedia/en/5/5b/Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("de340954-5ab9-4423-ad8a-0e5b8a4a452a"), new Guid("f3630695-a3c4-41cc-ae90-fff08d9265e9"), new DateTime(2021, 3, 12, 15, 10, 20, 823, DateTimeKind.Local).AddTicks(6590), false, "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("6247f1d6-564a-4732-9fe0-c276a95b8845"), new Guid("f3630695-a3c4-41cc-ae90-fff08d9265e9"), new DateTime(2021, 3, 12, 15, 10, 20, 823, DateTimeKind.Local).AddTicks(6646), false, "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 },
                    { new Guid("869afc48-df9d-434e-b238-32e98748e693"), new Guid("714379a9-ffb9-4126-9e4a-8d1a0011e226"), new DateTime(2021, 3, 12, 15, 10, 20, 823, DateTimeKind.Local).AddTicks(6666), false, "The Xbox controller is the primary game controller for Microsoft's Xbox home video game console and was introduced at the Game Developers Conference in 2000. ", "https://www.geeky-gadgets.com/wp-content/uploads/2018/08/Wireless-Controller-Grey-Blue-2.jpg", false, "Xbox Controller", 599.0, 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1470b870-fb8b-4467-bcd8-fb2444d4a4f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4cd8725e-7f7f-47a1-a4cc-767cd6900ae0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e96142e-4e35-48a2-9038-460376af3741"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("960b8445-a9be-478b-a37f-92cdc7933df0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd5158e4-6379-483b-b7c4-310933c281bb"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("bda58cce-b941-403f-a393-282ec49067dc"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("db4b4435-40fd-4587-a5a8-486b5add9bcc"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("e48674f8-f968-457e-9104-ea6ada8c6ed5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6247f1d6-564a-4732-9fe0-c276a95b8845"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a48e9f1-853c-4b53-8ca2-11a37907f81a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("869afc48-df9d-434e-b238-32e98748e693"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9033d6ec-db4c-4198-8fd6-8574d6afe4ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de340954-5ab9-4423-ad8a-0e5b8a4a452a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("84633f37-2410-43a4-a4e4-909f246544f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("714379a9-ffb9-4126-9e4a-8d1a0011e226"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7f44a2a-2ed8-48a1-9a96-000e13648f0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3630695-a3c4-41cc-ae90-fff08d9265e9"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("0d7d232b-97dc-4003-8f4d-dde4b2a6f010"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ac7c9f7-fbba-4ba6-920a-3a6886b3ef7c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("04ec2bd1-cbe2-4866-bad7-0a4591e19c09"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("27720af0-9eae-4cd9-9260-fc94d98b2f77"));

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa81d120-385a-4eef-b36b-f4753af085e9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3800ba5b-ea51-4372-a93f-10a7fabdd64e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc2dadac-8c3a-44e3-a12d-eae1cb5d6394"));

            migrationBuilder.DropColumn(
                name: "Deals",
                table: "Products");

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
    }
}
