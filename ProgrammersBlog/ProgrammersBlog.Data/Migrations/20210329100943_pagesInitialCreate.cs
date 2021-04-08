using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class pagesInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Content", "CreateDate", "CreatedByName", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { 1, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.", new DateTime(2021, 3, 29, 13, 9, 42, 180, DateTimeKind.Local).AddTicks(9376), "Berkay Küçük", true, false, "Berkay Küçük", new DateTime(2021, 3, 29, 13, 9, 42, 180, DateTimeKind.Local).AddTicks(9421), "ilk sayfa", "page", "page", "page", "pageImages/defaultPage.png", "Deneme Sayfası" },
                    { 9, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1118), "Berkay Küçük", true, false, "Berkay Küçük", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1120), "ilk sayfa", "page", "page", "page", "pageImages/defaultPage.png", "Deneme Sayfası 9" },
                    { 3, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1082), "Berkay Küçük", true, false, "Berkay Küçük", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1084), "ilk sayfa", "page", "page", "page", "pageImages/defaultPage.png", "Deneme Sayfası 3" },
                    { 4, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1089), "Berkay Küçük", true, false, "Berkay Küçük", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1090), "ilk sayfa", "page", "page", "page", "pageImages/defaultPage.png", "Deneme Sayfası 4" },
                    { 5, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1095), "Berkay Küçük", true, false, "Berkay Küçük", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1096), "ilk sayfa", "page", "page", "page", "pageImages/defaultPage.png", "Deneme Sayfası 5" },
                    { 2, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1075), "Berkay Küçük", true, false, "Berkay Küçük", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1077), "ilk sayfa", "page", "page", "page", "pageImages/defaultPage.png", "Deneme Sayfası 2" },
                    { 7, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1107), "Berkay Küçük", true, false, "Berkay Küçük", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1108), "ilk sayfa", "page", "page", "page", "pageImages/defaultPage.png", "Deneme Sayfası 7" },
                    { 10, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1124), "Berkay Küçük", true, false, "Berkay Küçük", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1126), "ilk sayfa", "page", "page", "page", "pageImages/defaultPage.png", "Deneme Sayfası 10" },
                    { 8, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1113), "Berkay Küçük", true, false, "Berkay Küçük", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1114), "ilk sayfa", "page", "page", "page", "pageImages/defaultPage.png", "Deneme Sayfası 8" },
                    { 6, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1101), "Berkay Küçük", true, false, "Berkay Küçük", new DateTime(2021, 3, 29, 13, 9, 42, 181, DateTimeKind.Local).AddTicks(1102), "ilk sayfa", "page", "page", "page", "pageImages/defaultPage.png", "Deneme Sayfası 6" }
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10);

        }
    }
}
