using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    QuoteID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuoteText = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Citation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.QuoteID);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteID", "Author", "Citation", "Date", "QuoteText", "Subject" },
                values: new object[] { 1, "Ingmar Bergman", "The Internet", "April 4, 1946", "No form of art goes beyond ordinary consciousness as film does, straight to our emotions, deep into the twilight room of the soul.", "Film" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteID", "Author", "Citation", "Date", "QuoteText", "Subject" },
                values: new object[] { 2, "Jean-Luc Godard", "The Internet", "June 1965", "The cinema is not an art which films life: the cinema is something between art and life.", "Film" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteID", "Author", "Citation", "Date", "QuoteText", "Subject" },
                values: new object[] { 3, "David Lynch", "The Internet", "September 2003", "It’s better not to know so much about what things mean or how they might be interpreted or you’ll be too afraid to let things keep happening.", "Film" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
