using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mentor_MVC.Migrations
{
    public partial class NewRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeaturePrice");

            migrationBuilder.CreateTable(
                name: "FeaturePrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeaturePrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeaturePrices_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeaturePrices_Prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeaturePrices_FeatureId",
                table: "FeaturePrices",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_FeaturePrices_PriceId",
                table: "FeaturePrices",
                column: "PriceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeaturePrices");

            migrationBuilder.CreateTable(
                name: "FeaturePrice",
                columns: table => new
                {
                    FeaturesId = table.Column<int>(type: "int", nullable: false),
                    PricesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeaturePrice", x => new { x.FeaturesId, x.PricesId });
                    table.ForeignKey(
                        name: "FK_FeaturePrice_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeaturePrice_Prices_PricesId",
                        column: x => x.PricesId,
                        principalTable: "Prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeaturePrice_PricesId",
                table: "FeaturePrice",
                column: "PricesId");
        }
    }
}
