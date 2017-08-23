using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GearRepository : BaseRepository<Gear>
    {
        public GearRepository(RentACarContext context) : base(context)
        {
        }
    }
}
