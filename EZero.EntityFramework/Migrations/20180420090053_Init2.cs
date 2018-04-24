using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EZero.EntityFrameworkCore.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Syspermission",
                newName: "Action");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Syspermission",
                maxLength: 32,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Syspermission");

            migrationBuilder.RenameColumn(
                name: "Action",
                table: "Syspermission",
                newName: "Area");
        }
    }
}
