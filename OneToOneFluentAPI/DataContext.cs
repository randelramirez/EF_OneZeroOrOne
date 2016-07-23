using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneFluentAPI
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
                .HasRequired(person => person.DriverLicense) // Mark DriverLicense required in Person entity
                .WithRequiredPrincipal(license => license.Person); // mark Person property as required in DriverLicense entity. Cannot save DriverLicense without Person and vice-versa

            //// DevTest: tried using both at the same time for 1-1, it did not throw exception still
            //// another way
            //modelBuilder.Entity<DriverLicense>()
            //    .HasRequired(license => license.Person) // Mark Person required in DriverLicense entity
            //    .WithRequiredDependent(person => person.DriverLicense); // // mark Person property as required in DriverLicense entity. Cannot save DriverLicense without Person and vice-versa


        }
    }
}
