using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CarState
    {
        public CarState()
        {
            CarHistories = new HashSet<CarHistory>();
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CarHistory> CarHistories { get; set; }
    }
}
