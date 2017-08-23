using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CarHistory
    {
        public CarHistory()
        {
            Bills = new HashSet<Bill>();
        }
        public int ID { get; set; }
        public int CarID { get; set; }
        public virtual Car Car { get; set; }

        public int CarStateID { get; set; }

        public DateTime TransactionDate { get; set; }

        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }

        public virtual  Nullable<int> CustomerID { get; set; }

        //NAV
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual CarState CarState { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
