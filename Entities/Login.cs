using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Login
    {
        public int CustomerID { get; set; }
        public string  UserName { get; set; }
        public string  Password { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
