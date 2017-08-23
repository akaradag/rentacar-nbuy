using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Model
    {
        public int ID { get; set; }

        public string  Name { get; set; }

        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
