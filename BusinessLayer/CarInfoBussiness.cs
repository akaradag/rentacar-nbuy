using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CarInfoBussiness : IBussiness<CarInfo>
    {
        UnitOfWork _uof;
        Customer _user;
        public CarInfoBussiness()
        {
            _uof = new UnitOfWork();
            _user = new Customer();
            _user.RoleID = 0;
        }
        public CarInfoBussiness(Customer user)
        {
            _uof = new UnitOfWork();
            _user = user;
        }

        public bool Add(CarInfo item)
        {
            if (_user.RoleID == 1)
            {
                if (item == null) { throw new Exception("Hatalı işlem"); }
                if (item.DateOfPurchase == null) { throw new Exception("Alım tarihi seçmediniz."); }
                try
                {
                    _uof.CarInfoRepository.Add(item);
                    return _uof.ApplyChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Bu işlem içn yetkiniz yok.");
            }
        }

        public CarInfo Get(int id)
        {
            if (id < 0) { throw new Exception("Hatalı işlem."); }
            try
            {
                return _uof.CarInfoRepository.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CarInfo> GetAll()
        {
            try
            {
                return _uof.CarInfoRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Remove(CarInfo item)
        {
            if (_user.RoleID == 1)
            {
                if (item == null) { throw new Exception("Hatalı işlem"); }
                try
                {
                    _uof.CarInfoRepository.Remove(item);
                    return _uof.ApplyChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Bu işlem için yetkiniz yok");
            }
        }

        public bool Update(CarInfo item)
        {
            if (_user.RoleID == 1)
            {
                if (item == null) { throw new Exception("Hatalı işlem"); }
                if (item.DateOfPurchase == null) { throw new Exception("Alım tarihi seçmediniz."); }
                try
                {
                    _uof.CarInfoRepository.Update(item);
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
