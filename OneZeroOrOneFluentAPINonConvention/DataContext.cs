using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneZeroOrOneFluentAPINonConvention
{
    public class DataContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public DbSet<DriverLicense> DriverLicenses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure PersonId as PK for DriverLicense
            modelBuilder.Entity<DriverLicense>().HasKey(license => license.PersonId);

            // Configure Person & DriverLicense entity
            modelBuilder.Entity<Person>()
                .HasOptional(person => person.DriverLicense) // Mark Address DriverLicense optional in Person entity
                .WithRequired(license => license.Person); // mark Person property as required in DriverLicense entity. Cannot save DriverLicense without Person

            //// another way
            //modelBuilder.Entity<DriverLicense>()
            //    .HasRequired(license => license.Person) // Mark Person as required in DriverLicense entity
            //    .WithOptional(person => person.DriverLicense); // mark DriverLicense as optional in Person entity. Can save Person without DriverLicense. Cannot save DriverLicense without Person
        }
    }
}
