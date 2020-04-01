using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rev.Classes
{
    public class VehicleQueryParameters :QueryParameters
    {
        public string Sku { get; set; }
        public string Name { get; set; }
    }
}
