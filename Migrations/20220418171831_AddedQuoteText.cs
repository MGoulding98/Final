using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class AddedQuoteText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuoteText",
                table: "Quotes",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteText",
                table: "Quotes");
        }
    }
}
