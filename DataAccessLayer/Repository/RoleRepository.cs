using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(RentACarContext context) : base(context)
        {
        }
    }
}
