using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SturbucksCustomerIdentityNumber",
                table: "SturbucksCustomers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PortalkahveCustomerIdentityNumber",
                table: "PortalkahveCustomers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SturbucksCustomerIdentityNumber",
                table: "SturbucksCustomers");

            migrationBuilder.DropColumn(
                name: "PortalkahveCustomerIdentityNumber",
                table: "PortalkahveCustomers");
        }
    }
}
