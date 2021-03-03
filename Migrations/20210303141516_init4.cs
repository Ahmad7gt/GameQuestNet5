using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameQuest.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b2938ae-0241-4fb3-8dae-cc7d0f7cff99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e5ee56c-2e50-4fb8-bd90-0fe9e27258a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("814f4878-1c34-4f16-b4dc-38f9dd2dc96e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b52d07ce-c6f2-4657-89db-3c01bf1c8ad7"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("814f4878-1c34-4f16-b4dc-38f9dd2dc96e"), new DateTime(2021, 3, 3, 15, 14, 8, 76, DateTimeKind.Local).AddTicks(7097), "Halo: Combat Evolved, simply known as Halo, is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001. Microsoft released versions of the game for Windows and Mac OS X in 2003.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.halopedia.org%2FHalo%3A_Combat_Evolved&psig=AOvVaw0WwkEYkMxz6AU6GQlg7sM_&ust=1614867137798000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCPCm1IOnlO8CFQAAAAAdAAAAABAS", false, "Halo: Combat Evolved", 599.0, 0.0 },
                    { new Guid("4b2938ae-0241-4fb3-8dae-cc7d0f7cff99"), new DateTime(2021, 3, 3, 15, 14, 8, 79, DateTimeKind.Local).AddTicks(5396), "Counter-Strike: Global Offensive is a multiplayer first-person shooter video game developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series and was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, while the Linux version was released in 2014.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fcounterstrike.fandom.com%2Fwiki%2FCounter-Strike%3A_Global_Offensive&psig=AOvVaw0GH3GJh6lzN7LfRZkh8Ynk&ust=1614867118807000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCICl4_mmlO8CFQAAAAAdAAAAABAD", false, "Counter-Strike: Global Offensive", 49.0, 0.0 },
                    { new Guid("b52d07ce-c6f2-4657-89db-3c01bf1c8ad7"), new DateTime(2021, 3, 3, 15, 14, 8, 79, DateTimeKind.Local).AddTicks(5528), "Fable is a series of action role-playing video games for Xbox, Microsoft Windows, macOS, Xbox 360 and Xbox One platforms. The series was developed by Lionhead Studios until the studio was closed in 2016, and is published by Xbox Game Studios", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FFable_(2004_video_game)&psig=AOvVaw3k-XQUnlov44uM_BZG8RnD&ust=1614867085556000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCMDJ8ummlO8CFQAAAAAdAAAAABAD", false, "Fable", 599.0, 0.0 },
                    { new Guid("4e5ee56c-2e50-4fb8-bd90-0fe9e27258a8"), new DateTime(2021, 3, 3, 15, 14, 8, 79, DateTimeKind.Local).AddTicks(5551), "F1 2020 is the official video game of the 2020 Formula 1 and Formula 2 Championships developed and published by Codemasters.", "https://s3.gaming-cdn.com/images/products/7589/271x377/f1-2020-cover.jpg", false, "F1 2020", 599.0, 0.0 }
                });
        }
    }
}
