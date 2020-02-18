using Microsoft.EntityFrameworkCore.Migrations;

namespace rapnetApi.Migrations
{
    public partial class DiamondsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diamonds",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false),
                    Size = table.Column<decimal>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Clarity = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ListPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diamonds", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Diamonds",
                columns: new[] { "Id", "Clarity", "Color", "ListPrice", "Price", "Size" },
                values: new object[] { 1m, "IF", "D", 18000m, 15000m, 1.02m });

            migrationBuilder.InsertData(
                table: "Diamonds",
                columns: new[] { "Id", "Clarity", "Color", "ListPrice", "Price", "Size" },
                values: new object[] { 2m, "VVS1", "E", 21000m, 20000m, 1.5m });

            migrationBuilder.InsertData(
                table: "Diamonds",
                columns: new[] { "Id", "Clarity", "Color", "ListPrice", "Price", "Size" },
                values: new object[] { 3m, "VVS2", "G", 10000m, 12000m, 0.95m });

            migrationBuilder.InsertData(
                table: "Diamonds",
                columns: new[] { "Id", "Clarity", "Color", "ListPrice", "Price", "Size" },
                values: new object[] { 4m, "I2", "F", 55000m, 50000m, 2.15m });

            migrationBuilder.InsertData(
                table: "Diamonds",
                columns: new[] { "Id", "Clarity", "Color", "ListPrice", "Price", "Size" },
                values: new object[] { 5m, "IF", "D", 3000m, 2000m, 0.5m });

            migrationBuilder.InsertData(
                table: "Diamonds",
                columns: new[] { "Id", "Clarity", "Color", "ListPrice", "Price", "Size" },
                values: new object[] { 6m, "I1", "G", 12000m, 15000m, 1.2m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diamonds");
        }
    }
}
