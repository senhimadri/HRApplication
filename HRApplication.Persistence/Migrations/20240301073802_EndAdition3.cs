using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRApplication.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EndAdition3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "emp");

            migrationBuilder.EnsureSchema(
                name: "lev");

            migrationBuilder.RenameTable(
                name: "TblReligionInfo",
                newName: "TblReligionInfo",
                newSchema: "emp");

            migrationBuilder.RenameTable(
                name: "TblLeaveTypeInfo",
                newName: "TblLeaveTypeInfo",
                newSchema: "lev");

            migrationBuilder.RenameTable(
                name: "TblLeaveBalance",
                newName: "TblLeaveBalance",
                newSchema: "lev");

            migrationBuilder.RenameTable(
                name: "TblLeaveApplication",
                newName: "TblLeaveApplication",
                newSchema: "lev");

            migrationBuilder.RenameTable(
                name: "TblGenderInfo",
                newName: "TblGenderInfo",
                newSchema: "emp");

            migrationBuilder.RenameTable(
                name: "TblEmployeeBasicInfo",
                newName: "TblEmployeeBasicInfo",
                newSchema: "emp");

            migrationBuilder.RenameTable(
                name: "TblDesignationInfo",
                newName: "TblDesignationInfo",
                newSchema: "emp");

            migrationBuilder.RenameTable(
                name: "TblDepartmentInfo",
                newName: "TblDepartmentInfo",
                newSchema: "emp");

            migrationBuilder.AlterColumn<string>(
                name: "StrReligionName",
                schema: "emp",
                table: "TblReligionInfo",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StrReligionCode",
                schema: "emp",
                table: "TblReligionInfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StrLeaveTypeName",
                schema: "lev",
                table: "TblLeaveTypeInfo",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StrLeaveReason",
                schema: "lev",
                table: "TblLeaveApplication",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StrGenderName",
                schema: "emp",
                table: "TblGenderInfo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StrGenderCode",
                schema: "emp",
                table: "TblGenderInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StrEmployeeName",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StrEmployeeCode",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteDateOfBirth",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "StrDesignationName",
                schema: "emp",
                table: "TblDesignationInfo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StrDesignationCode",
                schema: "emp",
                table: "TblDesignationInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StrDepartmentName",
                schema: "emp",
                table: "TblDepartmentInfo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StrDepartmentCode",
                schema: "emp",
                table: "TblDepartmentInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                schema: "emp",
                table: "TblDepartmentInfo",
                columns: new[] { "IntPrimaryId", "DteCtratedAt", "DteUpdatedAt", "IntAccountId", "IntCreatedBy", "IntUpdatedBy", "IsActive", "StrDepartmentCode", "StrDepartmentName" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0L, 0L, false, "ADM001", "Administration" });

            migrationBuilder.InsertData(
                schema: "emp",
                table: "TblDesignationInfo",
                columns: new[] { "IntPrimaryId", "DteCtratedAt", "DteUpdatedAt", "IntAccountId", "IntCreatedBy", "IntUpdatedBy", "IsActive", "StrDesignationCode", "StrDesignationName" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0L, 0L, false, "ADM001", "Admin" });

            migrationBuilder.InsertData(
                schema: "emp",
                table: "TblReligionInfo",
                columns: new[] { "IntPrimaryId", "DteCtratedAt", "DteUpdatedAt", "IntAccountId", "IntCreatedBy", "IntUpdatedBy", "IsActive", "StrReligionCode", "StrReligionName" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0L, 0L, false, "O", "Others" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "emp",
                table: "TblDepartmentInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "emp",
                table: "TblDesignationInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "emp",
                table: "TblReligionInfo",
                keyColumn: "IntPrimaryId",
                keyValue: 1L);

            migrationBuilder.RenameTable(
                name: "TblReligionInfo",
                schema: "emp",
                newName: "TblReligionInfo");

            migrationBuilder.RenameTable(
                name: "TblLeaveTypeInfo",
                schema: "lev",
                newName: "TblLeaveTypeInfo");

            migrationBuilder.RenameTable(
                name: "TblLeaveBalance",
                schema: "lev",
                newName: "TblLeaveBalance");

            migrationBuilder.RenameTable(
                name: "TblLeaveApplication",
                schema: "lev",
                newName: "TblLeaveApplication");

            migrationBuilder.RenameTable(
                name: "TblGenderInfo",
                schema: "emp",
                newName: "TblGenderInfo");

            migrationBuilder.RenameTable(
                name: "TblEmployeeBasicInfo",
                schema: "emp",
                newName: "TblEmployeeBasicInfo");

            migrationBuilder.RenameTable(
                name: "TblDesignationInfo",
                schema: "emp",
                newName: "TblDesignationInfo");

            migrationBuilder.RenameTable(
                name: "TblDepartmentInfo",
                schema: "emp",
                newName: "TblDepartmentInfo");

            migrationBuilder.AlterColumn<string>(
                name: "StrReligionName",
                table: "TblReligionInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "StrReligionCode",
                table: "TblReligionInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "StrLeaveTypeName",
                table: "TblLeaveTypeInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "StrLeaveReason",
                table: "TblLeaveApplication",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "StrGenderName",
                table: "TblGenderInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "StrGenderCode",
                table: "TblGenderInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "StrEmployeeName",
                table: "TblEmployeeBasicInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "StrEmployeeCode",
                table: "TblEmployeeBasicInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DteDateOfBirth",
                table: "TblEmployeeBasicInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StrDesignationName",
                table: "TblDesignationInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "StrDesignationCode",
                table: "TblDesignationInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "StrDepartmentName",
                table: "TblDepartmentInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "StrDepartmentCode",
                table: "TblDepartmentInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
