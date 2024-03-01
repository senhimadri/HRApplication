using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRApplication.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class First_Script : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "base");

            migrationBuilder.EnsureSchema(
                name: "emp");

            migrationBuilder.EnsureSchema(
                name: "lev");

            migrationBuilder.CreateTable(
                name: "TblAccountInfo",
                schema: "base",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    StrAccountName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StrAccountDescreption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAccountInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblDepartmentInfo",
                schema: "emp",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrDepartmentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StrDepartmentCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDepartmentInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblDesignationInfo",
                schema: "emp",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrDesignationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StrDesignationCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDesignationInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblGenderInfo",
                schema: "emp",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrGenderName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StrGenderCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGenderInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblLeaveTypeInfo",
                schema: "lev",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrLeaveTypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StrLeaveTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLeaveTypeInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblReligionInfo",
                schema: "emp",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrReligionName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StrReligionCode = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblReligionInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblBusinessUnitInfo",
                schema: "base",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false),
                    StrBusinessUnitName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StrBusinessUnitDescreption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntAccountId = table.Column<long>(type: "bigint", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBusinessUnitInfo", x => x.IntPrimaryId);
                    table.ForeignKey(
                        name: "FK_TblBusinessUnitInfo_TblAccountInfo_IntPrimaryId",
                        column: x => x.IntPrimaryId,
                        principalSchema: "base",
                        principalTable: "TblAccountInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblEmployeeBasicInfo",
                schema: "emp",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrEmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StrEmployeeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DteDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IntDepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    IntDesignationId = table.Column<long>(type: "bigint", nullable: false),
                    IntGenderId = table.Column<long>(type: "bigint", nullable: false),
                    IntReligionId = table.Column<long>(type: "bigint", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IntAccountId = table.Column<long>(type: "bigint", nullable: false),
                    IntBusinessUnitId = table.Column<long>(type: "bigint", nullable: false),
                    IntWorkplaceGroupId = table.Column<long>(type: "bigint", nullable: false),
                    IntWorkPlaceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmployeeBasicInfo", x => x.IntPrimaryId);
                    table.ForeignKey(
                        name: "FK_TblEmployeeBasicInfo_TblDepartmentInfo_IntDepartmentId",
                        column: x => x.IntDepartmentId,
                        principalSchema: "emp",
                        principalTable: "TblDepartmentInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblEmployeeBasicInfo_TblDesignationInfo_IntDesignationId",
                        column: x => x.IntDesignationId,
                        principalSchema: "emp",
                        principalTable: "TblDesignationInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblEmployeeBasicInfo_TblGenderInfo_IntGenderId",
                        column: x => x.IntGenderId,
                        principalSchema: "emp",
                        principalTable: "TblGenderInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblEmployeeBasicInfo_TblReligionInfo_IntReligionId",
                        column: x => x.IntReligionId,
                        principalSchema: "emp",
                        principalTable: "TblReligionInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblWorkplaceGroupInfo",
                schema: "base",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false),
                    StrWorkplaceGroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StrWorkplaceGroupDescreption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntBusinessUnitId = table.Column<long>(type: "bigint", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblWorkplaceGroupInfo", x => x.IntPrimaryId);
                    table.ForeignKey(
                        name: "FK_TblWorkplaceGroupInfo_TblBusinessUnitInfo_IntPrimaryId",
                        column: x => x.IntPrimaryId,
                        principalSchema: "base",
                        principalTable: "TblBusinessUnitInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblLeaveApplication",
                schema: "lev",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntEmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    IntLeaveTypeId = table.Column<long>(type: "bigint", nullable: false),
                    DteApplicationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DteFromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DteToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    StrLeaveReason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IntAccountId = table.Column<long>(type: "bigint", nullable: false),
                    IntBusinessUnitId = table.Column<long>(type: "bigint", nullable: false),
                    IntWorkplaceGroupId = table.Column<long>(type: "bigint", nullable: false),
                    IntWorkPlaceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLeaveApplication", x => x.IntPrimaryId);
                    table.ForeignKey(
                        name: "FK_TblLeaveApplication_TblEmployeeBasicInfo_IntEmployeeId",
                        column: x => x.IntEmployeeId,
                        principalSchema: "emp",
                        principalTable: "TblEmployeeBasicInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblLeaveApplication_TblLeaveTypeInfo_IntLeaveTypeId",
                        column: x => x.IntLeaveTypeId,
                        principalSchema: "lev",
                        principalTable: "TblLeaveTypeInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblLeaveBalance",
                schema: "lev",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntEmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    IntLeaveTypeId = table.Column<long>(type: "bigint", nullable: false),
                    IntYearId = table.Column<int>(type: "int", nullable: false),
                    IntLeaveBalance = table.Column<int>(type: "int", nullable: false),
                    IntLeaveTaken = table.Column<int>(type: "int", nullable: false),
                    IntLeaveRemaining = table.Column<int>(type: "int", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IntAccountId = table.Column<long>(type: "bigint", nullable: false),
                    IntBusinessUnitId = table.Column<long>(type: "bigint", nullable: false),
                    IntWorkplaceGroupId = table.Column<long>(type: "bigint", nullable: false),
                    IntWorkPlaceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLeaveBalance", x => x.IntPrimaryId);
                    table.ForeignKey(
                        name: "FK_TblLeaveBalance_TblEmployeeBasicInfo_IntEmployeeId",
                        column: x => x.IntEmployeeId,
                        principalSchema: "emp",
                        principalTable: "TblEmployeeBasicInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblLeaveBalance_TblLeaveTypeInfo_IntLeaveTypeId",
                        column: x => x.IntLeaveTypeId,
                        principalSchema: "lev",
                        principalTable: "TblLeaveTypeInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblWorkplaceInfo",
                schema: "base",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false),
                    StrWorkplaceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StrWorkplaceDescreption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntWorkplaceGroupId = table.Column<long>(type: "bigint", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblWorkplaceInfo", x => x.IntPrimaryId);
                    table.ForeignKey(
                        name: "FK_TblWorkplaceInfo_TblWorkplaceGroupInfo_IntPrimaryId",
                        column: x => x.IntPrimaryId,
                        principalSchema: "base",
                        principalTable: "TblWorkplaceGroupInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "emp",
                table: "TblDepartmentInfo",
                columns: new[] { "IntPrimaryId", "DteCtratedAt", "DteUpdatedAt", "IntCreatedBy", "IntUpdatedBy", "IsActive", "StrDepartmentCode", "StrDepartmentName" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 0L, false, "ADM001", "Administration" });

            migrationBuilder.InsertData(
                schema: "emp",
                table: "TblDesignationInfo",
                columns: new[] { "IntPrimaryId", "DteCtratedAt", "DteUpdatedAt", "IntCreatedBy", "IntUpdatedBy", "IsActive", "StrDesignationCode", "StrDesignationName" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 0L, false, "ADM001", "Admin" });

            migrationBuilder.InsertData(
                schema: "emp",
                table: "TblGenderInfo",
                columns: new[] { "IntPrimaryId", "DteCtratedAt", "DteUpdatedAt", "IntCreatedBy", "IntUpdatedBy", "IsActive", "StrGenderCode", "StrGenderName" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 0L, false, "M", "Male" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 0L, false, "F", "Female" },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 0L, false, "O", "Others" }
                });

            migrationBuilder.InsertData(
                schema: "lev",
                table: "TblLeaveTypeInfo",
                columns: new[] { "IntPrimaryId", "DteCtratedAt", "DteUpdatedAt", "IntCreatedBy", "IntUpdatedBy", "IsActive", "StrLeaveTypeCode", "StrLeaveTypeName" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 0L, false, "CA001", "Casual Leave" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 0L, false, "SCK002", "Sick Leave" }
                });

            migrationBuilder.InsertData(
                schema: "emp",
                table: "TblReligionInfo",
                columns: new[] { "IntPrimaryId", "DteCtratedAt", "DteUpdatedAt", "IntCreatedBy", "IntUpdatedBy", "IsActive", "StrReligionCode", "StrReligionName" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 0L, false, "O", "Others" });

            migrationBuilder.CreateIndex(
                name: "IX_TblEmployeeBasicInfo_IntDepartmentId",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                column: "IntDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmployeeBasicInfo_IntDesignationId",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                column: "IntDesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmployeeBasicInfo_IntGenderId",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                column: "IntGenderId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmployeeBasicInfo_IntReligionId",
                schema: "emp",
                table: "TblEmployeeBasicInfo",
                column: "IntReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_TblLeaveApplication_IntEmployeeId",
                schema: "lev",
                table: "TblLeaveApplication",
                column: "IntEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblLeaveApplication_IntLeaveTypeId",
                schema: "lev",
                table: "TblLeaveApplication",
                column: "IntLeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblLeaveBalance_IntEmployeeId",
                schema: "lev",
                table: "TblLeaveBalance",
                column: "IntEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblLeaveBalance_IntLeaveTypeId",
                schema: "lev",
                table: "TblLeaveBalance",
                column: "IntLeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblLeaveApplication",
                schema: "lev");

            migrationBuilder.DropTable(
                name: "TblLeaveBalance",
                schema: "lev");

            migrationBuilder.DropTable(
                name: "TblWorkplaceInfo",
                schema: "base");

            migrationBuilder.DropTable(
                name: "TblEmployeeBasicInfo",
                schema: "emp");

            migrationBuilder.DropTable(
                name: "TblLeaveTypeInfo",
                schema: "lev");

            migrationBuilder.DropTable(
                name: "TblWorkplaceGroupInfo",
                schema: "base");

            migrationBuilder.DropTable(
                name: "TblDepartmentInfo",
                schema: "emp");

            migrationBuilder.DropTable(
                name: "TblDesignationInfo",
                schema: "emp");

            migrationBuilder.DropTable(
                name: "TblGenderInfo",
                schema: "emp");

            migrationBuilder.DropTable(
                name: "TblReligionInfo",
                schema: "emp");

            migrationBuilder.DropTable(
                name: "TblBusinessUnitInfo",
                schema: "base");

            migrationBuilder.DropTable(
                name: "TblAccountInfo",
                schema: "base");
        }
    }
}
