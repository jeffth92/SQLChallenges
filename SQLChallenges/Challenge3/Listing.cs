using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge3
{
    public class Listing
    {
        [Key]
        public int ListingId { get; set; }
        public DateTime DateListed { get; set; }
        public bool IsRented { get; set; }

        [ForeignKey(nameof(House))]
        public House HouseId { get; set; }
        public virtual House House { get; set; }
    }
}
