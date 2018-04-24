using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EZero.EntityFrameworkCore.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Syspermission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    Icon = table.Column<string>(maxLength: 32, nullable: true),
                    IsNavigation = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    Pid = table.Column<int>(nullable: true),
                    SerialNumber = table.Column<int>(nullable: false),
                    SyspermissionName = table.Column<string>(maxLength: 64, nullable: false),
                    SyspermissionTitle = table.Column<string>(maxLength: 32, nullable: false),
                    Area = table.Column<string>(maxLength: 32, nullable: true),
                    Controller = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syspermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Syspermission_Syspermission_Pid",
                        column: x => x.Pid,
                        principalTable: "Syspermission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sysrole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 64, nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    SerialNumber = table.Column<int>(nullable: false),
                    SysroleName = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sysrole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sysuser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LoginName = table.Column<string>(maxLength: 16, nullable: false),
                    PassWordHash = table.Column<string>(maxLength: 256, nullable: false),
                    Salt = table.Column<string>(maxLength: 256, nullable: false),
                    UserName = table.Column<string>(maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sysuser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 64, nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    Mobile = table.Column<string>(maxLength: 16, nullable: true),
                    Realname = table.Column<string>(maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysroleSyspermission",
                columns: table => new
                {
                    SysroleId = table.Column<int>(nullable: false),
                    SyspermissionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysroleSyspermission", x => new { x.SysroleId, x.SyspermissionId });
                    table.ForeignKey(
                        name: "FK_SysroleSyspermission_Syspermission_SyspermissionId",
                        column: x => x.SyspermissionId,
                        principalTable: "Syspermission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SysroleSyspermission_Sysrole_SysroleId",
                        column: x => x.SysroleId,
                        principalTable: "Sysrole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysuserSysrole",
                columns: table => new
                {
                    SysuserId = table.Column<int>(nullable: false),
                    SysroleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysuserSysrole", x => new { x.SysuserId, x.SysroleId });
                    table.ForeignKey(
                        name: "FK_SysuserSysrole_Sysrole_SysroleId",
                        column: x => x.SysroleId,
                        principalTable: "Sysrole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SysuserSysrole_Sysuser_SysuserId",
                        column: x => x.SysuserId,
                        principalTable: "Sysuser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Syspermission_Pid",
                table: "Syspermission",
                column: "Pid");

            migrationBuilder.CreateIndex(
                name: "IX_Syspermission_SyspermissionName",
                table: "Syspermission",
                column: "SyspermissionName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SysroleSyspermission_SyspermissionId",
                table: "SysroleSyspermission",
                column: "SyspermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SysuserSysrole_SysroleId",
                table: "SysuserSysrole",
                column: "SysroleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SysroleSyspermission");

            migrationBuilder.DropTable(
                name: "SysuserSysrole");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Syspermission");

            migrationBuilder.DropTable(
                name: "Sysrole");

            migrationBuilder.DropTable(
                name: "Sysuser");
        }
    }
}
