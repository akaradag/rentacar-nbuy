using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Brand
    {
        public Brand()
        {
            Models = new HashSet<Model>();
        }
        public int ID { get; set; }
        public string  Name { get; set; }

        public virtual ICollection<Model> Models { get; set; }
    }
}
