using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Businesses",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Category", "ClosingTime", "Description", "Name", "OpeningTime" },
                values: new object[,]
                {
                    { 1, "8629 120th Ave NE, Kirkland, WA 98033", "Wholesale Club", "8:30PM", "Costco Wholesale Corporation, doing business as Costco, is an American multinational corporation which operates a chain of membership-only warehouse clubs.", "Costco", "10:00AM" },
                    { 2, "12026 NE 124th St, Kirkland, WA 98034", "Restaraunt", "10:00PM", "Fast-food chain serving chicken sandwiches, strips & nuggets along with salads & sides.", "Chic-fil-A", "6:30AM" },
                    { 3, "11020 NE 6th St #90, Bellevue, WA 98004", "Restaraunt", "9:00PM", "Cozy, cream-toned eatery featuring Chinese hot pot with sauces plus other dishes in glam surrounds.", "The Dolar Shop Seattle", "5:00PM" },
                    { 4, "12520 Totem Lake Blvd NE Ste 116, Kirkland, WA 98034", "Grocery Store", "8:00PM", "Grocery chain with a variety of signature items, plus produce, dairy & more (most sell wine & beer).", "Trader Joe's", "9:00AM" },
                    { 5, "457 120th Ave NE, Bellevue, WA 98005", "Electronics Store", "6:00PM", "Chain retailer with a large array of brand-name electronics, computers, appliances & more.", "Best Buy", "10:00AM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Businesses");
        }
    }
}
