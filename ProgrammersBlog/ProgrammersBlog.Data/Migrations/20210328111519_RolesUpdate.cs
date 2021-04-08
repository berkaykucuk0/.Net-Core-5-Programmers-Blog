using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class RolesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                    
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 23, "240512d2-80bc-47a6-907a-c00fc1f59578", "Page.Read", "PAGE.READ" },
                    { 26, "10ca6001-8e56-4c27-a8f5-daa9bcaefa07", "Page.Delete", "PAGE.DELETE" },
                    { 25, "03a2cbf9-6c36-40c0-a567-0c85012a8cf1", "Page.Update", "PAGE.UPDATE" },
                    { 24, "c93c071b-c4d5-4d89-b9bf-58425405b3cc", "Page.Create", "PAGE.CREATE" }
                });
         
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26);

        }
    }
}
