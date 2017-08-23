using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BillRepository : BaseRepository<Bill>
    {
        RentACarContext _context;
        public BillRepository(RentACarContext context) : base(context)
        {
            _context = context;
        }
        public List<Bill> GetByCustomerId(int customerId)
        {
            return _context.Bills.Where(x => x.CarHistory.CustomerID == customerId).ToList();
        }
    }
}
