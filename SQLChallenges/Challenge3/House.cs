using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge3
{
    public class House
    {
        [Key]
        public int HouseId { get; set; }
        public short NumberOfBedrooms { get; set; }
        public short NumberOfBaths { get; set; }
        public decimal EstimatedValue { get; set; }
    }
}
