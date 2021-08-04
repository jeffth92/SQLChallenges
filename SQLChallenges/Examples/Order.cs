using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Examples
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; } //this is the foreign key
        public Customer Customer { get; set; } //tbr left name the same, likely due to structure in original.
        public short OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int StoreId { get; set; } //build class, primary key of another table, do that. likely called ID
        public int StaffId { get; set; } //just like customer
    }
}
