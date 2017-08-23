using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PaymentType
    {
        public PaymentType()
        {
            Bills = new HashSet<Bill>();
        }
        public int ID { get; set; }
        public string  Name { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
