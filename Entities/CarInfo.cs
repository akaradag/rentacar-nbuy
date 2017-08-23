using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CarInfo
    {
        public int CarID { get; set; }
        public decimal Weight { get; set; }
        public string  Plate { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public virtual Car Car { get; set; }

        
    }
}
