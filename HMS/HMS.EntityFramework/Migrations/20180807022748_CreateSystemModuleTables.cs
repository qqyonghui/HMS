using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HMS.EntityFramework.Migrations
{
    public partial class CreateSystemModuleTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastModify = table.Column<Guid>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    TenantId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    RoleId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Discriminator = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysCatagories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastModify = table.Column<Guid>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    TenantId = table.Column<Guid>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysCatagories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastModify = table.Column<Guid>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    TenantId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastModify = table.Column<Guid>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    LoginName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "SysCatagories");

            migrationBuilder.DropTable(
                name: "SysRoles");

            migrationBuilder.DropTable(
                name: "Tenants");
        }
    }
}
