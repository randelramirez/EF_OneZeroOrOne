using System;

namespace OneToOneFluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            // person without driver license
            using (var context = new DataContext())
            {
                // profile sql command generated
                var person1 = new Person { Name = "Person 1", DriverLicense = new DriverLicense { LicenseNumber = "license for p1" } };
                context.People.Add(person1);
                context.SaveChanges();
            }

            // person with driver license, add DriverLicense
            using (var context = new DataContext())
            {
                // profile sql command generated
                var person2 = new Person { Name = "Person 2" };
                var driverLicenseforP2 = new DriverLicense { LicenseNumber = "license for p2", Person = person2 };
                context.DriverLicenses.Add(driverLicenseforP2);
                context.SaveChanges();
            }

            // person with driver license, add Person
            using (var context = new DataContext())
            {
                // profile sql command generated
                var person3 = new Person { Name = "Person 3" };
                var driverLicenseforP3 = new DriverLicense { LicenseNumber = "license for p3", Person = person3 };
                context.DriverLicenses.Add(driverLicenseforP3);
                context.SaveChanges();
            }

            // person without driver license
            using (var context = new DataContext())
            {
                // profile sql command generated
                var person = new Person { Name = "Person with no license",  };
                context.People.Add(person);
                context.SaveChanges();
                // an exception should be thrown here, but so far it gets inserted on the other hand when I try to insert a DriverLicense without a person it throws an exception
            }

            // driver without person
            using (var context = new DataContext())
            {
                // profile sql command generated
                // expecting an exception once SaveChanges is called
                var driverLicenseforP2 = new DriverLicense { LicenseNumber = "license for nobody" };
                context.DriverLicenses.Add(driverLicenseforP2);
                context.SaveChanges();
                // exception is thrown
            }

            Console.ReadKey();
        }
    }
}
