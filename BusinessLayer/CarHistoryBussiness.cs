using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CarHistoryBussiness : IBussiness<CarHistory>
    {
        UnitOfWork _uof;
        Customer _user;
        public CarHistoryBussiness()
        {
            _uof = new UnitOfWork();
            _user = new Customer();
            _user.RoleID = 0;
        }
        public CarHistoryBussiness(Customer user)
        {
            _uof = new UnitOfWork();
            _user = user;
        }

        public bool Add(CarHistory item)
        {
            if (item == null) { throw new Exception("Hatalı işlem"); }
            if (item.CarID < 0) { throw new Exception("Hatalı işlem"); }
            if (item.TransactionDate == null) { throw new Exception("İşlem tarihi seçilmedi."); }
            if (item.StartingDate == null) { throw new Exception("Başlangıç tarihi seçilmedi."); }
            if (item.CarStateID < 0) { throw new Exception("Araba durumu seçilmedi"); }
            try
            {
                _uof.CarHistoryRepository.Add(item);
                return _uof.ApplyChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CarHistory Get(int id)
        {
            if (id < 0)
            {
                try
                {
                    return _uof.CarHistoryRepository.Get(id);
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

        public List<CarHistory> GetAll()
        {
            if (_user.RoleID == 1) //Admin
            {
                try
                {
                    return _uof.CarHistoryRepository.GetAll();
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

        public bool Remove(CarHistory item)
        {
            if (_user.RoleID == 1)
            {
                if (item == null) { throw new Exception("Hatalı işlem."); }
                try
                {
                    _uof.CarHistoryRepository.Remove(item);
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

        public bool Update(CarHistory item)
        {
            if (_user.RoleID == 1)
            {
                if (item == null) { throw new Exception("Hatalı işlem"); }
                if (item.CarID < 0) { throw new Exception("Hatalı işlem"); }
                if (item.TransactionDate == null) { throw new Exception("İşlem tarihi seçilmedi."); }
                if (item.StartingDate == null) { throw new Exception("Başlangıç tarihi seçilmedi."); }
                if (item.CarStateID < 0) { throw new Exception("Araba durumu seçilmedi"); }
                try
                {
                    _uof.CarHistoryRepository.Update(item);
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
