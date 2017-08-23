using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bill
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public int CarHistoryID { get; set; }
        public DateTime  Date { get; set; }
        public  int PaymentTypeID { get; set; }
        //NAV
        public virtual PaymentType PaymentType { get; set; }
        public virtual CarHistory CarHistory { get; set; }
        public virtual BillInfo BillInfo { get; set; }


    }
}
