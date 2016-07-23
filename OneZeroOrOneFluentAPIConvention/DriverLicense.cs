using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneZeroOrOneFluentAPIConvention
{
    public class DriverLicense
    {
        public int DriverLicenseId { get; set; }

        public string LicenseNumber { get; set; }

        public virtual Person Person { get; set; }
    }
}
