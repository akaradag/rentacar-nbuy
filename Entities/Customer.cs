using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        public Customer()
        {
            CarHistories = new HashSet<CarHistory>();
        }
        public int ID { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string  Email { get; set; }
        public string  Phone { get; set; }
        public string  Address { get; set; }
        public int SocialNumber { get; set; }

        public virtual int RoleID { get; set; }
        public virtual Role Role { get; set; }

        public virtual Login Login { get; set; }

        

        public virtual ICollection<CarHistory> CarHistories { get; set; }
    }
}
