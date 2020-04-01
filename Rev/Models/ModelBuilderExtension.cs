using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rev.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType { Id = 1, Name = "ATV" },
                new VehicleType { Id = 2, Name = "Dirt Bike" },
                new VehicleType { Id = 3, Name = "Street" }
                );

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle { Id = 1, TypeId = 1, Make = "CAN-AM", Model = "Outlander Max XT 570", Color = "Silver", Year = "2020", Vin = "3JBLPAT28LJ000104", IsNew = true },
                new Vehicle { Id = 2, TypeId = 1, Make = "Kawasaki", Model = "Brute Force 300", Color = "Red", Year = "2020", Vin = "RGSWM2237LBD20953", IsNew = true },
                new Vehicle { Id = 3, TypeId = 1, Make = "Suzuki", Model = "QuadSport", Color = "Yellow", Year = "2020", Vin = "RFDAD4137L1100548", IsNew = true },
                new Vehicle { Id = 4, TypeId = 1, Make = "Polaris", Model = "Scrambler XP 1000 S", Color = "Black", Year = "2020", Vin = "RFDAD4137L1100548", IsNew = true },
                new Vehicle { Id = 5, TypeId = 1, Make = "Honda", Model = "FourTrax Rancher 4X4 EPS", Color = "Red", Year = "2020", Vin = "RFDAD4137L1100548", IsNew = true },
                new Vehicle { Id = 6, TypeId = 2, Make = "Honda", Model = "CRF 450r", Color = "Red", Year = "2020", Vin = "JH2PE0735LK300021", IsNew = true },
                new Vehicle { Id = 7, TypeId = 2, Make = "Kawasaki", Model = "KLX 100", Color = "Green", Year = "2020", Vin = "JKALXSC33LDAC7113", IsNew = true },
                new Vehicle { Id = 8, TypeId = 2, Make = "KTM", Model = "XC 350 F", Color = "Orange", Year = "2020", Vin = "VBKXCN439LM289821", IsNew = true },
                new Vehicle { Id = 9, TypeId = 2, Make = "Suzuki", Model = "RM-Z 450", Color = "Yellow", Year = "2020", Vin = "JS1DZ11C0L7100269", IsNew = true },
                new Vehicle { Id = 10, TypeId = 2, Make = "Suzuki", Model = "DR-Z 125L", Color = "Yellow", Year = "2019", Vin = "S1DF4336K2100389", IsNew = false },
                new Vehicle { Id = 11, TypeId = 3, Make = "Ducati", Model = "Panigale", Color = "Red", Year = "2020", Vin = "ZDMDAGNWXLB013520", IsNew = true },
                new Vehicle { Id = 12, TypeId = 3, Make = "Kawasaki", Model = "Ninja ZX-6R", Color = "Orange", Year = "2020", Vin = "JKBZXJH17LA005450", IsNew = true },
                new Vehicle { Id = 13, TypeId = 3, Make = "Yamaha", Model = "R6", Color = "White", Year = "2018", Vin = "JYARJ28Y1JA001448", IsNew = false },
                new Vehicle { Id = 14, TypeId = 3, Make = "Honda", Model = "CBR 650F", Color = "Black", Year = "2014", Vin = "MLHRC7406E5001369", IsNew = false },
                new Vehicle { Id = 15, TypeId = 3, Make = "Suzuki", Model = "GSX-S 1000F", Color = "White", Year = "2018", Vin = "JS1GT7CB3J2100444", IsNew = false }
                );
        }
    }
}

