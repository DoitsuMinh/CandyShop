using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class InitialMigrationSeedingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Candies",
                columns: table => new
                {
                    CandyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnail = table.Column<string>(nullable: true),
                    IsOnSale = table.Column<bool>(nullable: false),
                    IsInStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candies", x => x.CandyId);
                    table.ForeignKey(
                        name: "FK_Candies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 5, null, "Kẹo cứng" },
                    { 1, null, "Kẹo chocolate" },
                    { 2, null, "Kẹo trái cây" },
                    { 3, null, "Kẹo dẻo" },
                    { 4, null, "Kẹo Halloween" }
                });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CategoryId", "Description", "ImageThumbnail", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 13, 5, "Kẹo cứng hương theo màu.", "\\Images\\thumbnails\\hardCandy-small.jpg", "\\Images\\hardCandy.jpg", true, false, "Kẹo cứng", 6.95m },
                    { 14, 5, "Kẹo cứng hương theo màu.", "\\Images\\thumbnails\\hardCandy2-small.jpg", "\\Images\\hardCandy2.jpg", true, true, "Kẹo cứng 2", 2.95m },
                    { 15, 5, "Kẹo cứng hương theo màu.", "\\Images\\thumbnails\\hardCandy3-small.jpg", "\\Images\\hardCandy3.jpg", true, false, "Kẹo cứng ngon", 16.95m },
                    { 1, 1, "Kẹo chocolate với nhiều hương khác nhau.", "\\Images\\thumbnails\\chocolateCandy-small.jpg", "\\Images\\chocolateCandy.jpg", true, false, "Kẹo Chocolate thập cẩm", 4.95m },
                    { 2, 1, "Kẹo chocolate với nhiều hương khác nhau.", "\\Images\\thumbnails\\chocolateCandy2-small.jpg", "\\Images\\chocolateCandy2.jpg", true, true, "Kẹo Chocolate thập cẩm 2", 3.95m },
                    { 3, 1, "Kẹo chocolate đắng.", "\\Images\\thumbnails\\chocolateCandy3-small.jpg", "\\Images\\chocolateCandy3.jpg", true, false, "Kẹo Chocolate", 5.75m },
                    { 4, 2, "Kẹo trái cây nhiều hương.", "\\Images\\thumbnails\\fruitCandy-small.jpg", "\\Images\\fruitCandy.jpg", true, false, "Kẹo trái cây thập cẩm", 3.95m },
                    { 5, 2, "Kẹo hương trái cây.", "\\Images\\thumbnails\\fruitCandy2-small.jpg", "\\Images\\fruitCandy2.jpg", true, true, "Kẹo trái cây", 7.00m },
                    { 6, 2, "Kẹo nhiều hương vị.", "\\Images\\thumbnails\\fruitCandy3-small.jpg", "\\Images\\fruitCandy3.jpg", true, true, "Kẹo trái cây thập cẩm 2", 11.25m },
                    { 7, 3, "Kẹo dẻo nhiều hương vị.", "\\Images\\thumbnails\\gummyCandy-small.jpg", "\\Images\\gummyCandy.jpg", true, true, "Kẹo dẻo thập cẩm", 3.95m },
                    { 8, 3, "Kẹo dẻo nhiều hương vị.", "\\Images\\thumbnails\\gummyCandy2-small.jpg", "\\Images\\gummyCandy2.jpg", true, false, "Kẹo dẻo thập cẩm 2", 1.95m },
                    { 9, 3, "Kẹo siêu dẻo.", "\\Images\\thumbnails\\gummyCandy3-small.jpg", "\\Images\\gummyCandy3.jpg", true, false, "Kẹo dẻo", 13.95m },
                    { 10, 4, "Kẹo dịp lễ Halloween.", "\\Images\\thumbnails\\halloweenCandy-small.jpg", "\\Images\\halloweenCandy.jpg", true, true, "Kẹo Halloween", 1.95m },
                    { 11, 4, "Kẹo Halloween nhiều hương.", "\\Images\\thumbnails\\halloweenCandy2-small.jpg", "\\Images\\halloweenCandy2.jpg", true, true, "Kẹo Halloween thập cẩm", 12.95m },
                    { 12, 4, "Kẹo dịp Halloween.", "\\Images\\thumbnails\\halloweenCandy3-small.jpg", "\\Images\\halloweenCandy3.jpg", true, true, "Kẹo Halloween 2", 21.95m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candies_CategoryId",
                table: "Candies",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candies");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
