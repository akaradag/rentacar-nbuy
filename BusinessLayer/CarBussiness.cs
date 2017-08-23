using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CarBussiness : IBussiness<Car>
    {
        UnitOfWork _uof;
        Customer _user;
        public CarBussiness()
        {
            _uof = new UnitOfWork();
            _user = new Customer();
            _user.RoleID = 0;
        }
        public CarBussiness(Customer user)
        {
            _uof = new UnitOfWork();
            _user = user;
        }

        public bool Add(Car item)
        {
            if (_user.RoleID == 1) // admin
            {
                if (item == null) { throw new Exception("Hatalı işlem."); }
                if (item.Capacity <= 0) { throw new Exception("Aracın kapasitesi hatalı."); }
                if (item.ColorID < 0) { throw new Exception("Aracın rengini giriniz."); }
                if (item.EnginePower <= 0) { throw new Exception("Aracın motor gücü hatalı"); }
                if (item.EngineSize <= 0) { throw new Exception("Aracın motor hacmi hatalı."); }
                if (item.FuelID < 0) { throw new Exception("Aracın benzin tipi hatalı."); }
                if (item.GearID < 0) { throw new Exception("Aracın vites tipi hatalı."); }
                if (item.ModelID < 0) { throw new Exception("Aracın modeli hatalı."); }
                if (item.RentPrice < 0) { throw new Exception("Aracın ücretini giriniz."); }
                try
                {
                    _uof.CarRepository.Add(item);
                    return _uof.ApplyChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Bu işlem için yetkiniz yok.");
            }
        }

        public Car Get(int id = 0)
        {
            if (id != 0)
            {
                try
                {
                    return _uof.CarRepository.Get(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Hatalı işlem.");
            }
        }

        public List<Car> GetByDate(DateTime startingDate, DateTime endingDate)
        {
            if (startingDate != null && endingDate != null)
            {
                try
                {
                    return _uof.CarRepository.GetByDate(startingDate, endingDate);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Hatalı işlem.");
            }
        }

        public List<Car> GetAll()
        {
            try
            {
                return _uof.CarRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Remove(Car item)
        {
            if (_user.RoleID == 1) // admin
            {
                try
                {
                    _uof.CarRepository.Remove(item);
                    return _uof.ApplyChanges();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Bu işlem için yetkiniz yok.");
            }
        }

        public bool Update(Car item)
        {
            if (_user.RoleID == 1)
            {
                if (item == null) { throw new Exception("Hatalı işlem."); }
                if (item.Capacity <= 0) { throw new Exception("Aracın kapasitesi hatalı."); }
                if (item.ColorID < 0) { throw new Exception("Aracın rengini giriniz."); }
                if (item.EnginePower <= 0) { throw new Exception("Aracın motor gücü hatalı"); }
                if (item.EngineSize <= 0) { throw new Exception("Aracın motor hacmi hatalı."); }
                if (item.FuelID < 0) { throw new Exception("Aracın benzin tipi hatalı."); }
                if (item.GearID < 0) { throw new Exception("Aracın vites tipi hatalı."); }
                if (item.ModelID < 0) { throw new Exception("Aracın modeli hatalı."); }
                if (item.RentPrice < 0) { throw new Exception("Aracın ücretini giriniz."); }
                try
                {
                    _uof.CarRepository.Update(item);
                    return _uof.ApplyChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Bu işlem için yetkiniz yok.");
            }
        }
    }
}
