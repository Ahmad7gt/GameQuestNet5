using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameQuest.Migrations
{
    public partial class int7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
