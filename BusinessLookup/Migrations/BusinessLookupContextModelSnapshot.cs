﻿// <auto-generated />
using BusinessLookup.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusinessLookup.Migrations
{
    [DbContext(typeof(BusinessLookupContext))]
    partial class BusinessLookupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BusinessLookup.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Category");

                    b.Property<string>("ClosingTime");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("OpeningTime");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 1,
                            Address = "8629 120th Ave NE, Kirkland, WA 98033",
                            Category = "Wholesale Club",
                            ClosingTime = "8:30PM",
                            Description = "Costco Wholesale Corporation, doing business as Costco, is an American multinational corporation which operates a chain of membership-only warehouse clubs.",
                            Name = "Costco",
                            OpeningTime = "10:00AM"
                        },
                        new
                        {
                            BusinessId = 2,
                            Address = "12026 NE 124th St, Kirkland, WA 98034",
                            Category = "Restaraunt",
                            ClosingTime = "10:00PM",
                            Description = "Fast-food chain serving chicken sandwiches, strips & nuggets along with salads & sides.",
                            Name = "Chic-fil-A",
                            OpeningTime = "6:30AM"
                        },
                        new
                        {
                            BusinessId = 3,
                            Address = "11020 NE 6th St #90, Bellevue, WA 98004",
                            Category = "Restaraunt",
                            ClosingTime = "9:00PM",
                            Description = "Cozy, cream-toned eatery featuring Chinese hot pot with sauces plus other dishes in glam surrounds.",
                            Name = "The Dolar Shop Seattle",
                            OpeningTime = "5:00PM"
                        },
                        new
                        {
                            BusinessId = 4,
                            Address = "12520 Totem Lake Blvd NE Ste 116, Kirkland, WA 98034",
                            Category = "Grocery Store",
                            ClosingTime = "8:00PM",
                            Description = "Grocery chain with a variety of signature items, plus produce, dairy & more (most sell wine & beer).",
                            Name = "Trader Joe's",
                            OpeningTime = "9:00AM"
                        },
                        new
                        {
                            BusinessId = 5,
                            Address = "457 120th Ave NE, Bellevue, WA 98005",
                            Category = "Electronics Store",
                            ClosingTime = "6:00PM",
                            Description = "Chain retailer with a large array of brand-name electronics, computers, appliances & more.",
                            Name = "Best Buy",
                            OpeningTime = "10:00AM"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
