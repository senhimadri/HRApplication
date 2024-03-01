using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRApplication.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EndAdition2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblAccountInfo",
                columns: table => new
                {
                    IntPrimaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAccountInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblDepartmentInfo",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrDepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrDepartmentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IntAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDepartmentInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblDesignationInfo",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrDesignationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrDesignationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IntAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDesignationInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblGenderInfo",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrGenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrGenderCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IntAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGenderInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblLeaveTypeInfo",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrLeaveTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrLeaveTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IntAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLeaveTypeInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblReligionInfo",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrReligionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrReligionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IntAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblReligionInfo", x => x.IntPrimaryId);
                });

            migrationBuilder.CreateTable(
                name: "TblEmployeeBasicInfo",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrEmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrEmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DteDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntDepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    IntDesignationId = table.Column<long>(type: "bigint", nullable: false),
                    IntGenderId = table.Column<long>(type: "bigint", nullable: false),
                    IntReligionId = table.Column<long>(type: "bigint", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IntAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmployeeBasicInfo", x => x.IntPrimaryId);
                    table.ForeignKey(
                        name: "FK_TblEmployeeBasicInfo_TblDepartmentInfo_IntDepartmentId",
                        column: x => x.IntDepartmentId,
                        principalTable: "TblDepartmentInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblEmployeeBasicInfo_TblDesignationInfo_IntDesignationId",
                        column: x => x.IntDesignationId,
                        principalTable: "TblDesignationInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblEmployeeBasicInfo_TblGenderInfo_IntGenderId",
                        column: x => x.IntGenderId,
                        principalTable: "TblGenderInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblEmployeeBasicInfo_TblReligionInfo_IntReligionId",
                        column: x => x.IntReligionId,
                        principalTable: "TblReligionInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblLeaveApplication",
                columns: table => new
                {
                    IntPrimaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntEmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    IntLeaveTypeId = table.Column<long>(type: "bigint", nullable: false),
                    DteApplicationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DteFromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DteToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    StrLeaveReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntCreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteCtratedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DteUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IntAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLeaveApplication", x => x.IntPrimaryId);
                    table.ForeignKey(
                        name: "FK_TblLeaveApplication_TblEmployeeBasicInfo_IntEmployeeId",
                        column: x => x.IntEmployeeId,
                        principalTable: "TblEmployeeBasicInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblLeaveApplication_TblLeaveTypeInfo_IntLeaveTypeId",
                        column: x => x.IntLeaveTypeId,
                        principalTable: "TblLeaveTypeInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblLeaveBalance",
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
                    IntAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLeaveBalance", x => x.IntPrimaryId);
                    table.ForeignKey(
                        name: "FK_TblLeaveBalance_TblEmployeeBasicInfo_IntEmployeeId",
                        column: x => x.IntEmployeeId,
                        principalTable: "TblEmployeeBasicInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblLeaveBalance_TblLeaveTypeInfo_IntLeaveTypeId",
                        column: x => x.IntLeaveTypeId,
                        principalTable: "TblLeaveTypeInfo",
                        principalColumn: "IntPrimaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TblGenderInfo",
                columns: new[] { "IntPrimaryId", "DteCtratedAt", "DteUpdatedAt", "IntAccountId", "IntCreatedBy", "IntUpdatedBy", "IsActive", "StrGenderCode", "StrGenderName" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0L, 0L, false, "M", "Male" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0L, 0L, false, "F", "Female" },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0L, 0L, false, "O", "Others" }
                });

            migrationBuilder.InsertData(
                table: "TblLeaveTypeInfo",
                columns: new[] { "IntPrimaryId", "DteCtratedAt", "DteUpdatedAt", "IntAccountId", "IntCreatedBy", "IntUpdatedBy", "IsActive", "StrLeaveTypeCode", "StrLeaveTypeName" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0L, 0L, false, "CA001", "Casual Leave" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0L, 0L, false, "SCK002", "Sick Leave" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblEmployeeBasicInfo_IntDepartmentId",
                table: "TblEmployeeBasicInfo",
                column: "IntDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmployeeBasicInfo_IntDesignationId",
                table: "TblEmployeeBasicInfo",
                column: "IntDesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmployeeBasicInfo_IntGenderId",
                table: "TblEmployeeBasicInfo",
                column: "IntGenderId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmployeeBasicInfo_IntReligionId",
                table: "TblEmployeeBasicInfo",
                column: "IntReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_TblLeaveApplication_IntEmployeeId",
                table: "TblLeaveApplication",
                column: "IntEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblLeaveApplication_IntLeaveTypeId",
                table: "TblLeaveApplication",
                column: "IntLeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblLeaveBalance_IntEmployeeId",
                table: "TblLeaveBalance",
                column: "IntEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblLeaveBalance_IntLeaveTypeId",
                table: "TblLeaveBalance",
                column: "IntLeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblAccountInfo");

            migrationBuilder.DropTable(
                name: "TblLeaveApplication");

            migrationBuilder.DropTable(
                name: "TblLeaveBalance");

            migrationBuilder.DropTable(
                name: "TblEmployeeBasicInfo");

            migrationBuilder.DropTable(
                name: "TblLeaveTypeInfo");

            migrationBuilder.DropTable(
                name: "TblDepartmentInfo");

            migrationBuilder.DropTable(
                name: "TblDesignationInfo");

            migrationBuilder.DropTable(
                name: "TblGenderInfo");

            migrationBuilder.DropTable(
                name: "TblReligionInfo");
        }
    }
}
