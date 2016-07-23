using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneZeroOrOneAnnotationConvention
{
    public class DriverLicense
    {
        [ForeignKey("Person")]
        public int DriverLicenseId { get; set; }

        public string LicenseNumber { get; set; }

        public virtual Person Person { get; set; }
    }
}
