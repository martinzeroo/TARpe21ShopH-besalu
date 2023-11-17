using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TARpe21ShopHõbesalu.Core.Domain;

namespace TARpe21ShopHõbesalu.Data
{
    public class TARpe21ShopHõbesaluContext : DbContext
    {
        public TARpe21ShopHõbesaluContext(DbContextOptions<TARpe21ShopHõbesaluContext> options) : base(options) { }

        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<FileToDatabase> FilesToDatabase { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<FileToApi> FilesToApi { get; set; }

        public DbSet<Car> Cars { get; set; }
    }
}