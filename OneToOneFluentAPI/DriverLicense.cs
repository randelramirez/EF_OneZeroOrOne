using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneFluentAPI
{
    public class DriverLicense
    {
        public int PersonId { get; set; }

        public string LicenseNumber { get; set; }

        public virtual Person Person { get; set; }
    }
}
