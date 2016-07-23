using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneZeroOrOneAnnotationNonConvention
{
    class Program
    {
        static void Main(string[] args)
        {
            // person without driver license
            using (var context = new DataContext())
            {
                // profile sql command generated
                var person1 = new Person { Name = "Person 1" };
                context.People.Add(person1);
                context.SaveChanges();
            }

            // person with driver license, add DriverLicense
            using (var context = new DataContext())
            {
                // profile sql command generated
                var person2 = new Person { Name = "Person 2" };
                var driverLicenseforP2 = new DriverLicense { LicenseNumber = "975-11480-93475", Person = person2 };
                context.DriverLicenses.Add(driverLicenseforP2);
                context.SaveChanges();
            }

            // person with driver license, add Person
            using (var context = new DataContext())
            {
                // profile sql command generated
                var person3 = new Person { Name = "Person 3" };
                var driverLicenseforP3 = new DriverLicense { LicenseNumber = "975-11480-93475", Person = person3 };
                context.DriverLicenses.Add(driverLicenseforP3);
                context.SaveChanges();
            }

            // driver without person
            using (var context = new DataContext())
            {
                // profile sql command generated
                // expecting an exception once SaveChanges is called
                var driverLicenseforP2 = new DriverLicense { LicenseNumber = "975-11480-93475" };
                context.DriverLicenses.Add(driverLicenseforP2);
                context.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}
