using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsPro.Data.Migrations
{
    public partial class inititalsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Technician",
                columns: table => new
                {
                    TechnicianId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technician", x => x.TechnicianId);
                });

            migrationBuilder.CreateTable(
                name: "Incident",
                columns: table => new
                {
                    IncidentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    TechnicianId = table.Column<int>(nullable: true),
                    DateOpened = table.Column<DateTime>(nullable: false),
                    DateClosed = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incident", x => x.IncidentId);
                    table.ForeignKey(
                        name: "FK_Incident_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incident_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incident_Technician_TechnicianId",
                        column: x => x.TechnicianId,
                        principalTable: "Technician",
                        principalColumn: "TechnicianId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "City", "Country", "Email", "Firstname", "Lastname", "Phone", "PostalCode", "State" },
                values: new object[,]
                {
                    { 1, "1010 Dead End Drive", "Toronto", "Canada", "joe.smith@customer.com", "Joe", "Smith", "416-967-1111", "L4R RY9", "Ontario" },
                    { 2, "2020 Dead End Drive", "Toronto", "Canada", "moe.smith@customer.com", "Moe", "Smith", "416-447-1111", "L4R RY9", "Ontario" },
                    { 3, "3010 Dead End Drive", "Toronto", "Canada", "andrea.smith@customer.com", "Andrea", "Smith", "416-444-1111", "L4R RY9", "Ontario" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Code", "Name", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "G4569", "Event System", 1525.99, new DateTime(2021, 2, 20, 15, 39, 0, 924, DateTimeKind.Local).AddTicks(5224) },
                    { 2, "G4568", "Staff Management Software", 1525.99, new DateTime(2021, 2, 20, 15, 39, 0, 929, DateTimeKind.Local).AddTicks(1950) },
                    { 3, "G4564", "Registration Software", 1525.99, new DateTime(2021, 2, 20, 15, 39, 0, 929, DateTimeKind.Local).AddTicks(1995) }
                });

            migrationBuilder.InsertData(
                table: "Technician",
                columns: new[] { "TechnicianId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "michael.santos@sportspro.com", "Michael Santos", "647=777-7777" },
                    { 2, "lebron.james@sportspro.com", "Lebron James", "647=777-7777" },
                    { 3, "edwinsantos@sportspro.com", "Edwin Santon", "647=777-7777" }
                });

            migrationBuilder.InsertData(
                table: "Incident",
                columns: new[] { "IncidentId", "CustomerId", "DateClosed", "DateOpened", "Description", "ProductId", "TechnicianId", "Title" },
                values: new object[] { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 20, 15, 39, 0, 930, DateTimeKind.Local).AddTicks(839), "Im having issues adding new staff to the system. Please Advise", 2, 1, "Staff management system issue" });

            migrationBuilder.InsertData(
                table: "Incident",
                columns: new[] { "IncidentId", "CustomerId", "DateClosed", "DateOpened", "Description", "ProductId", "TechnicianId", "Title" },
                values: new object[] { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 20, 15, 39, 0, 930, DateTimeKind.Local).AddTicks(870), "I am trying to create a new event for the registration but it crashes when I click submit.", 3, 2, "Registration system frozen" });

            migrationBuilder.InsertData(
                table: "Incident",
                columns: new[] { "IncidentId", "CustomerId", "DateClosed", "DateOpened", "Description", "ProductId", "TechnicianId", "Title" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 20, 15, 39, 0, 930, DateTimeKind.Local).AddTicks(123), "System is constantly crashing. Will not open", 1, 3, "Event System crashes" });

            migrationBuilder.CreateIndex(
                name: "IX_Incident_CustomerId",
                table: "Incident",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_ProductId",
                table: "Incident",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_TechnicianId",
                table: "Incident",
                column: "TechnicianId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incident");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Technician");
        }
    }
}
