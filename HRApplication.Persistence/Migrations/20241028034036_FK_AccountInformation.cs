using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRApplication.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FK_AccountInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<long>(
                name: "TblDepartmentInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TblDesignationInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TblEmployeeBasicInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TblGenderInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TblLeaveApplicationIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TblLeaveBalanceIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TblLeaveTypeInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TblReligionInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                type: "bigint",
                nullable: true);

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
                name: "IX_AccountInformation_TblDepartmentInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblDepartmentInfoIntPrimaryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountInformation_TblDesignationInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblDesignationInfoIntPrimaryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountInformation_TblEmployeeBasicInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblEmployeeBasicInfoIntPrimaryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountInformation_TblGenderInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblGenderInfoIntPrimaryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountInformation_TblLeaveApplicationIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblLeaveApplicationIntPrimaryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountInformation_TblLeaveBalanceIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblLeaveBalanceIntPrimaryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountInformation_TblLeaveTypeInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblLeaveTypeInfoIntPrimaryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountInformation_TblReligionInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblReligionInfoIntPrimaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountInformation_TblDepartmentInfo_TblDepartmentInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblDepartmentInfoIntPrimaryId",
                principalSchema: "emp",
                principalTable: "TblDepartmentInfo",
                principalColumn: "IntPrimaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountInformation_TblDesignationInfo_TblDesignationInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblDesignationInfoIntPrimaryId",
                principalSchema: "emp",
                principalTable: "TblDesignationInfo",
                principalColumn: "IntPrimaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountInformation_TblEmployeeBasicInfo_TblEmployeeBasicInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblEmployeeBasicInfoIntPrimaryId",
                principalSchema: "emp",
                principalTable: "TblEmployeeBasicInfo",
                principalColumn: "IntPrimaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountInformation_TblGenderInfo_TblGenderInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblGenderInfoIntPrimaryId",
                principalSchema: "emp",
                principalTable: "TblGenderInfo",
                principalColumn: "IntPrimaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountInformation_TblLeaveApplication_TblLeaveApplicationIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblLeaveApplicationIntPrimaryId",
                principalSchema: "lev",
                principalTable: "TblLeaveApplication",
                principalColumn: "IntPrimaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountInformation_TblLeaveBalance_TblLeaveBalanceIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblLeaveBalanceIntPrimaryId",
                principalSchema: "lev",
                principalTable: "TblLeaveBalance",
                principalColumn: "IntPrimaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountInformation_TblLeaveTypeInfo_TblLeaveTypeInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblLeaveTypeInfoIntPrimaryId",
                principalSchema: "lev",
                principalTable: "TblLeaveTypeInfo",
                principalColumn: "IntPrimaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountInformation_TblReligionInfo_TblReligionInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation",
                column: "TblReligionInfoIntPrimaryId",
                principalSchema: "emp",
                principalTable: "TblReligionInfo",
                principalColumn: "IntPrimaryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountInformation_TblDepartmentInfo_TblDepartmentInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountInformation_TblDesignationInfo_TblDesignationInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountInformation_TblEmployeeBasicInfo_TblEmployeeBasicInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountInformation_TblGenderInfo_TblGenderInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountInformation_TblLeaveApplication_TblLeaveApplicationIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountInformation_TblLeaveBalance_TblLeaveBalanceIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountInformation_TblLeaveTypeInfo_TblLeaveTypeInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountInformation_TblReligionInfo_TblReligionInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropIndex(
                name: "IX_AccountInformation_TblDepartmentInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropIndex(
                name: "IX_AccountInformation_TblDesignationInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropIndex(
                name: "IX_AccountInformation_TblEmployeeBasicInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropIndex(
                name: "IX_AccountInformation_TblGenderInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropIndex(
                name: "IX_AccountInformation_TblLeaveApplicationIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropIndex(
                name: "IX_AccountInformation_TblLeaveBalanceIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropIndex(
                name: "IX_AccountInformation_TblLeaveTypeInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropIndex(
                name: "IX_AccountInformation_TblReligionInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropColumn(
                name: "TblDepartmentInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropColumn(
                name: "TblDesignationInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropColumn(
                name: "TblEmployeeBasicInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropColumn(
                name: "TblGenderInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropColumn(
                name: "TblLeaveApplicationIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropColumn(
                name: "TblLeaveBalanceIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropColumn(
                name: "TblLeaveTypeInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

            migrationBuilder.DropColumn(
                name: "TblReligionInfoIntPrimaryId",
                schema: "base",
                table: "AccountInformation");

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
