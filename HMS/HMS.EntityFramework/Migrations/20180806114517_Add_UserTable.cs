using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HMS.EntityFramework.Migrations
{
    public partial class Add_UserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SysUser",
                columns: table => new
                {
                    CreateBy = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastModify = table.Column<Guid>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    LoginName = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: true),
                    UserName = table.Column<string>(maxLength: 100, nullable: true),
                    RoleId = table.Column<Guid>(nullable: false),
                    TenantId = table.Column<Guid>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    lastLoginTime = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUser", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SysUser");
        }
    }
}
