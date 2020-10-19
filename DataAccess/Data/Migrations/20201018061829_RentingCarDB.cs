using Microsoft.EntityFrameworkCore.Migrations;

namespace SimulationProject5.Data.Migrations
{
    public partial class RentingCarDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarModel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    Speed = table.Column<int>(nullable: false),
                    Engine = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Available = table.Column<int>(nullable: false),
                    CartypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarTypes_CartypeId",
                        column: x => x.CartypeId,
                        principalTable: "CarTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentalCars",
                columns: table => new
                {
                    Idclient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nameclient = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Adhar = table.Column<string>(nullable: false),
                    CarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalCars", x => x.Idclient);
                    table.ForeignKey(
                        name: "FK_RentalCars_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CartypeId",
                table: "Cars",
                column: "CartypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalCars_CarId",
                table: "RentalCars",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authens");

            migrationBuilder.DropTable(
                name: "RentalCars");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarTypes");
        }
    }
}
