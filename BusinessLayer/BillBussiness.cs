using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BillBussiness : IBussiness<Bill>
    {
        UnitOfWork _uof;
        Customer _user;
        public BillBussiness()
        {
            _uof = new UnitOfWork();
            _user = new Customer();
            _user.RoleID = 0;
        }
        public BillBussiness(Customer user)
        {
            _uof = new UnitOfWork();
            _user = user;
        }

        public bool Add(Bill item)
        {
            bool result = false;
            if (item != null)
            {
                if(item == null) { throw new Exception("Hatalı işlem."); }
                if (item.CarHistoryID < 0) { throw new Exception("Hatalı işlem."); }
                if (item.Date == null) { throw new Exception("Tarih bilgisi giriniz."); }
                if (item.PaymentTypeID < 0) { throw new Exception("Ödeme bilgisi giriniz."); }
                if (item.Price < 0) { throw new Exception("Fatura tutarı giriniz."); }
                try
                {
                    _uof.BillRepository.Add(item);
                    result = _uof.ApplyChanges();
                    return result;
                }
                catch (Exception)
                {
                    return result;
                }
            }
            return result;
        }

        public Bill Get(int id)
        {
            if (id >= 0)
            {
                try
                {
                    return _uof.BillRepository.Get(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Hatalı id");
            }
        }
        public List<Bill> GetByCustomerId(int customerId)
        {
            if (customerId >= 0)
            {
                try
                {
                    return _uof.BillRepository.GetByCustomerId(customerId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Hatalı id");
            }
        }
        public List<Bill> GetAll()
        {
            if (_user.RoleID == 1) //Admin
            {
                try
                {
                    return _uof.BillRepository.GetAll();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Bu işlem için izniniz yok");
            }
        }

        public bool Remove(Bill item)
        {
            if (_user.RoleID == 1)
            {

                if (item != null)
                {
                    try
                    {
                        _uof.BillRepository.Remove(item);
                        return _uof.ApplyChanges();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw new Exception("Hatalı işlem");
                }
            }
            else
            {
                throw new Exception("Bu işlem için yetkiniz yok.");
            }
        }
        public bool Update(Bill item)
        {
            if (_user.RoleID == 1)
            {
                if (item == null) { throw new Exception("Hatalı işlem."); }
                if (item.CarHistoryID < 0) { throw new Exception("Hatalı işlem."); }
                if (item.Date == null) { throw new Exception("Tarih bilgisi giriniz."); }
                if (item.PaymentTypeID < 0) { throw new Exception("Ödeme bilgisi giriniz."); }
                if (item.Price < 0) { throw new Exception("Fatura tutarı giriniz."); }
                try
                {
                    _uof.BillRepository.Update(item);
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
