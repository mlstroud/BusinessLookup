using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Models
{
  public class BusinessLookupContext : DbContext
  {
    public BusinessLookupContext(DbContextOptions<BusinessLookupContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business
          {
            BusinessId = 1,
            Name = "Costco",
            Category = "Wholesale Club",
            Description = "Costco Wholesale Corporation, doing business as Costco, is an American multinational corporation which operates a chain of membership-only warehouse clubs.",
            Address = "8629 120th Ave NE, Kirkland, WA 98033",
            OpeningTime = "10:00AM",
            ClosingTime = "8:30PM"
          },
          new Business
          {
            BusinessId = 2,
            Name = "Chic-fil-A",
            Category = "Restaraunt",
            Description = "Fast-food chain serving chicken sandwiches, strips & nuggets along with salads & sides.",
            Address = "12026 NE 124th St, Kirkland, WA 98034",
            OpeningTime = "6:30AM",
            ClosingTime = "10:00PM"
          },
          new Business
          {
            BusinessId = 3,
            Name = "The Dolar Shop Seattle",
            Category = "Restaraunt",
            Description = "Cozy, cream-toned eatery featuring Chinese hot pot with sauces plus other dishes in glam surrounds.",
            Address = "11020 NE 6th St #90, Bellevue, WA 98004",
            OpeningTime = "5:00PM",
            ClosingTime = "9:00PM"
          },
          new Business
          {
            BusinessId = 4,
            Name = "Trader Joe's",
            Category = "Grocery Store",
            Description = "Grocery chain with a variety of signature items, plus produce, dairy & more (most sell wine & beer).",
            Address = "12520 Totem Lake Blvd NE Ste 116, Kirkland, WA 98034",
            OpeningTime = "9:00AM",
            ClosingTime = "8:00PM"
          },
          new Business
          {
            BusinessId = 5,
            Name = "Best Buy",
            Category = "Electronics Store",
            Description = "Chain retailer with a large array of brand-name electronics, computers, appliances & more.",
            Address = "457 120th Ave NE, Bellevue, WA 98005",
            OpeningTime = "10:00AM",
            ClosingTime = "6:00PM"
          }

        );
    }

    public DbSet<Business> Businesses { get; set; }
  }
}