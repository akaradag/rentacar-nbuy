using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class CarRepository : BaseRepository<Car>
    {
        RentACarContext _db;
        public CarRepository(RentACarContext context) : base(context)
        {
            _db = new RentACarContext();
        }
        public List<Car> GetByDate(DateTime startingDate, DateTime endingDate)
        {
            var query = (from c in _db.Cars
                         join ch in _db.CarHistories on c.ID equals ch.CarID
                         where (startingDate >= ch.StartingDate && startingDate <= ch.EndingDate)
                         || (endingDate >= ch.StartingDate && endingDate <= ch.EndingDate)
                         || (startingDate <= ch.StartingDate && endingDate >= ch.EndingDate)
                         select c).Distinct().ToList();

            var result = _db.Cars.Except(query).ToList();

            return result;
        }
    }
}
