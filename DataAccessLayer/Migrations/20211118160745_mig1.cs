using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PortalkahveCustomers",
                columns: table => new
                {
                    PortalkahveCustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortalkahveCustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortalkahveCustomerSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortalkahveCustomerBirtdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalkahveCustomers", x => x.PortalkahveCustomerId);
                });

            migrationBuilder.CreateTable(
                name: "SturbucksCustomers",
                columns: table => new
                {
                    SturbucksCustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SturbucksCustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SturbucksCustomerSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SturbucksCustomerBirtdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SturbucksCustomers", x => x.SturbucksCustomerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortalkahveCustomers");

            migrationBuilder.DropTable(
                name: "SturbucksCustomers");
        }
    }
}
