using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rev.Models
{
    public class Vehicle
    {
        public string Color { get; set; }
        public string Vin { get; set; }
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public float Price { get; set; }
        public bool IsNew { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}
