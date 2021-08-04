using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge2
{
    public class Technician
    {
        [Key]
        public int TechnicianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal CustomerRating { get; set; }

        [ForeignKey(nameof(Vehicle))]
        public Vehicle VehicleId { get; set; } //prop we want for FK
        public virtual Vehicle Vehicle { get; set; } //used referentially
    }
}
