using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BillInfo
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string TaxOffice { get; set; }
        public int? TaxNo { get; set; }
        public bool isPersonelBill { get; set; }
        //NAV
        public virtual Bill Bill { get; set; }
    }
}
