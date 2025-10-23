using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleCQRS.Migrations
{
    /// <inheritdoc />
    public partial class ChangeProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PromotionPrice",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "IsPromoted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPromoted",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "PromotionPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
