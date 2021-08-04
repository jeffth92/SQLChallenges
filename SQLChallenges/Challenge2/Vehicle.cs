using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge2
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string VIN { get; set; }
        public decimal Miles { get; set; }
    }
}
