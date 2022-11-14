using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagementSystem.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    DesignationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationName = table.Column<string>(nullable: true),
                    DepartmentName = table.Column<string>(nullable: true),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.DesignationID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDTO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<string>(nullable: true),
                    EmployeeName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    DepartmentName = table.Column<string>(nullable: true),
                    DesignationID = table.Column<int>(nullable: false),
                    DesignationName = table.Column<string>(nullable: true),
                    RoleName = table.Column<string>(nullable: true),
                    MemberSince = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDTO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRules",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentRule = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRules", x => x.PaymentID);
                });

            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "RequestLeave",
                columns: table => new
                {
                    LeaveID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: false),
                    LeaveType = table.Column<string>(nullable: true),
                    When = table.Column<DateTime>(nullable: false),
                    LeaveReason = table.Column<string>(nullable: true),
                    LeaveStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestLeave", x => x.LeaveID);
                });

            migrationBuilder.CreateTable(
                name: "WorkingHours",
                columns: table => new
                {
                    HoursID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: false),
                    CompanyWokingHours = table.Column<double>(nullable: false),
                    EmployeeWorkingHours = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingHours", x => x.HoursID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    DesignationID = table.Column<int>(nullable: false),
                    MemberSince = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Designation_DesignationID",
                        column: x => x.DesignationID,
                        principalTable: "Designation",
                        principalColumn: "DesignationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DesignationID",
                table: "Employee",
                column: "DesignationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeDTO");

            migrationBuilder.DropTable(
                name: "PaymentRules");

            migrationBuilder.DropTable(
                name: "Register");

            migrationBuilder.DropTable(
                name: "RequestLeave");

            migrationBuilder.DropTable(
                name: "WorkingHours");

            migrationBuilder.DropTable(
                name: "Designation");
        }
    }
}
