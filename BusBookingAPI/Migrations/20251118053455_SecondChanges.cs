using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusBookingAPI.Migrations
{
    public partial class SecondChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BusId",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seats",
                table: "Seats",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_BusId",
                table: "Seats",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BusID",
                table: "Bookings",
                column: "BusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Buses_BusID",
                table: "Bookings",
                column: "BusID",
                principalTable: "Buses",
                principalColumn: "BusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Buses_BusId",
                table: "Seats",
                column: "BusId",
                principalTable: "Buses",
                principalColumn: "BusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Buses_BusID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Buses_BusId",
                table: "Seats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seats",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_BusId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_BusID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "BusId",
                table: "Seats");
        }
    }
}
