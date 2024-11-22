using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Components.Domain;
using CarRentalManagement.Configurations.Entities;

namespace CarRentalManagement.Data
{
    public class CarRentalManagementContext : DbContext
    {
        public CarRentalManagementContext (DbContextOptions<CarRentalManagementContext> options)
            : base(options)
        {
        }

        public DbSet<CarRentalManagement.Components.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());

        }



    }
}
