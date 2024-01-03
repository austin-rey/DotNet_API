using Microsoft.EntityFrameworkCore;
using Tutorial_API.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tutorial_API.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villas",
                    Details = "Royal Villas Desc",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = ""
                },
                new Villa
                {
                    Id=2, 
                    Name="Royal Villas 2",
                    Details="Royal Villas Desc 2",
                        ImageUrl="",
                    Occupancy=5,
                    Rate=200,
                    Sqft=550,
                    Amenity=""
                }
            ); 
        }
    }
}
