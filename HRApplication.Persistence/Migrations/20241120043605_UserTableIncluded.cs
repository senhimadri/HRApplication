using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRApplication.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UserTableIncluded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "auth");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "emp",
                table: "TblReligionInfo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "lev",
                table: "TblLeaveTypeInfo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "lev",
                table: "TblLeaveBalance",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "lev",
                table: "TblLeaveApplication",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "emp",
                table: "TblGenderInfo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "emp",
                table: "TblDesignationInfo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "emp",
                table: "TblDepartmentInfo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "TblUserInformation",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUserInformation", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblDepartmentInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L,
                column: "DteUpdatedAt",
                value: null);

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblDesignationInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L,
                column: "DteUpdatedAt",
                value: null);

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblGenderInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L,
                column: "DteUpdatedAt",
                value: null);

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblGenderInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 2L,
                column: "DteUpdatedAt",
                value: null);

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblGenderInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 3L,
                column: "DteUpdatedAt",
                value: null);

            migrationBuilder.UpdateData(
                schema: "lev",
                table: "TblLeaveTypeInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L,
                column: "DteUpdatedAt",
                value: null);

            migrationBuilder.UpdateData(
                schema: "lev",
                table: "TblLeaveTypeInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 2L,
                column: "DteUpdatedAt",
                value: null);

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblReligionInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L,
                column: "DteUpdatedAt",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_TblEmployeeBasicInfo_UserId",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_TblEmployeeBasicInfo_TblUserInformation_UserId",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                column: "UserId",
                principalSchema: "auth",
                principalTable: "TblUserInformation",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblEmployeeBasicInfo_TblUserInformation_UserId",
                schema: "emp",
                table: "TblEmployeeBasicInfo");

            migrationBuilder.DropTable(
                name: "TblUserInformation",
                schema: "auth");

            migrationBuilder.DropIndex(
                name: "IX_TblEmployeeBasicInfo_UserId",
                schema: "emp",
                table: "TblEmployeeBasicInfo");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "emp",
                table: "TblEmployeeBasicInfo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "emp",
                table: "TblReligionInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "lev",
                table: "TblLeaveTypeInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "lev",
                table: "TblLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "lev",
                table: "TblLeaveApplication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "emp",
                table: "TblGenderInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "emp",
                table: "TblDesignationInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteUpdatedAt",
                schema: "emp",
                table: "TblDepartmentInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblDepartmentInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L,
                column: "DteUpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblDesignationInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L,
                column: "DteUpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblGenderInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L,
                column: "DteUpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblGenderInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 2L,
                column: "DteUpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblGenderInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 3L,
                column: "DteUpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "lev",
                table: "TblLeaveTypeInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L,
                column: "DteUpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "lev",
                table: "TblLeaveTypeInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 2L,
                column: "DteUpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "emp",
                table: "TblReligionInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L,
                column: "DteUpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
