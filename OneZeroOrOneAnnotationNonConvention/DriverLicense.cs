using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneZeroOrOneAnnotationNonConvention
{
    public class DriverLicense
    {
        // configure for primary key as well since it does not follow the EF convention
        [Key, ForeignKey("Person")]
        public int PersonId { get; set; }

        public string LicenseNumber { get; set; }

        public virtual Person Person { get; set; }
    }
}
