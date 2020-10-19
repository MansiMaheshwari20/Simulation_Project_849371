using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace SimulationProject5.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<RentalCar> RentalCars { get; set; }
        public DbSet<Authen> Authens { get; set; }
    }
}
