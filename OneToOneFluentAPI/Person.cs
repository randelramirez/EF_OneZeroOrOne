﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneFluentAPI
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual DriverLicense DriverLicense { get; set; }
    }
}
