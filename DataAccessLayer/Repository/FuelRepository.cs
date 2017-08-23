using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class FuelRepository : BaseRepository<Fuel>
    {
        public FuelRepository(RentACarContext context) : base(context)
        {
        }
    }
}
