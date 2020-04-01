using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rev.Classes
{
    public class VehicleQueryParameters :QueryParameters
    {
        public string Make { get; set; }
        public string  Model { get; set; }
        public string  Year { get; set; }

    }
}
