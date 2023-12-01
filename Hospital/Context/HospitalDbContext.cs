using Hospital.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Hospital.Context
{
    public class HospitalDbContext : IdentityDbContext<IdentityUser>
    {
        public HospitalDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Doctor> Doctors { get; set; }
        
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
