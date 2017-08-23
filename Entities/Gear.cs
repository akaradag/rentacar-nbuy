using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Gear
    {
        public Gear()
        {
            Cars = new HashSet<Car>();
        }
        public int ID { get; set; }
        public string  Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
