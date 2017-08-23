using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Role
    {
        public Role()
        {
            Customers = new HashSet<Customer>();
        }
        public int Id { get; set; }
        public string  Name { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
