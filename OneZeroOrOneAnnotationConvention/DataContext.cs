using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneZeroOrOneAnnotationConvention
{
    public class DataContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public DbSet<DriverLicense> DriverLicenses { get; set; }
    }
}
