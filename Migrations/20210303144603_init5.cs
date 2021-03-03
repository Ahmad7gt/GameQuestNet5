using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameQuest.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("280d59da-68e5-43e6-9451-a9408680a2d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("327232fa-8ab7-4b42-8ff8-8e2063e1ffca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f37d7be-68be-4017-bd33-33a0ffa05856"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d75aa083-7755-468c-baee-8943f7eeb670"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("db5453ee-eacc-453a-9f25-a84bc7b6042d"), new DateTime(2021, 3, 3, 15, 46, 3, 19, DateTimeKind.Local).AddTicks(3794), "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://www.halopedia.org/Halo:_Combat_Evolved#/media/File:Halo_Combat_Evolved_cover.png", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("583e65d9-f5be-46c0-b759-30ceafd0d91c"), new DateTime(2021, 3, 3, 15, 46, 3, 22, DateTimeKind.Local).AddTicks(7883), "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://static.wikia.nocookie.net/cswikia/images/1/1e/Csgo_steam_store_header_latest.jpg", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("47482e7c-80f9-4d9e-8c97-907e72c0546d"), new DateTime(2021, 3, 3, 15, 46, 3, 22, DateTimeKind.Local).AddTicks(8025), "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://en.wikipedia.org/wiki/Fable_(2004_video_game)#/media/File:Fablebox.jpg", false, "Fable", 599.0, 0.0 },
                    { new Guid("fce71a4a-153c-4335-aa42-33a0d97be1e0"), new DateTime(2021, 3, 3, 15, 46, 3, 22, DateTimeKind.Local).AddTicks(8048), "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47482e7c-80f9-4d9e-8c97-907e72c0546d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("583e65d9-f5be-46c0-b759-30ceafd0d91c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db5453ee-eacc-453a-9f25-a84bc7b6042d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fce71a4a-153c-4335-aa42-33a0d97be1e0"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "Description", "ImgUrl", "IsVisible", "Name", "Price", "Sale" },
                values: new object[,]
                {
                    { new Guid("d75aa083-7755-468c-baee-8943f7eeb670"), new DateTime(2021, 3, 3, 15, 15, 15, 891, DateTimeKind.Local).AddTicks(6377), "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.halopedia.org%2FHalo%3A_Combat_Evolved&psig=AOvVaw0WwkEYkMxz6AU6GQlg7sM_&ust=1614867137798000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCPCm1IOnlO8CFQAAAAAdAAAAABAS", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("327232fa-8ab7-4b42-8ff8-8e2063e1ffca"), new DateTime(2021, 3, 3, 15, 15, 15, 895, DateTimeKind.Local).AddTicks(143), "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fcounterstrike.fandom.com%2Fwiki%2FCounter-Strike%3A_Global_Offensive&psig=AOvVaw0GH3GJh6lzN7LfRZkh8Ynk&ust=1614867118807000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCICl4_mmlO8CFQAAAAAdAAAAABAD", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("3f37d7be-68be-4017-bd33-33a0ffa05856"), new DateTime(2021, 3, 3, 15, 15, 15, 895, DateTimeKind.Local).AddTicks(269), "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FFable_(2004_video_game)&psig=AOvVaw3k-XQUnlov44uM_BZG8RnD&ust=1614867085556000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCMDJ8ummlO8CFQAAAAAdAAAAABAD", false, "Fable", 599.0, 0.0 },
                    { new Guid("280d59da-68e5-43e6-9451-a9408680a2d3"), new DateTime(2021, 3, 3, 15, 15, 15, 895, DateTimeKind.Local).AddTicks(290), "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 }
                });
        }
    }
}
