using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerBussiness:IBussiness<Customer>
    {
        UnitOfWork _uof;
        public CustomerBussiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(Customer item)
        {
            if (item!=null)
            {
                if (item.FirstName==null)
                {
                    throw new Exception("İsim kısmı boş geçilemez");
                }
                if (item.LastName==null)
                {
                    throw new Exception("Soyisim kısmı boş geçilemez");
                }
                if (item.Phone==null)
                {
                    throw new Exception("Telefon kısmı boş geçilemez");
                }
                if (item.RoleID==0)
                {
                    throw new Exception("Kullanıcı rolü belirlenmelidir");
                }
                if (item.DateOfBirth==null)
                {
                    throw new Exception("Doğum tarihi kısmı boş geçilemez");
                }
                if (item.Address==null)
                {
                    throw new Exception("Adres kısmı boş geçilemez");
                }
                _uof.CustomerRepository.Add(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }

        public Customer Get(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Veri bulunamadı.");
            }
            return _uof.CustomerRepository.Get(id);
        }

        public List<Customer> GetAll()
        {
            return _uof.CustomerRepository.GetAll();
        }

        public bool Remove(Customer item)
        {
            if (item != null)
            {
                _uof.CustomerRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı.");
            }
        }

        public bool Update(Customer item)
        {
            if (item != null)
            {
                if (item.FirstName == null)
                {
                    throw new Exception("İsim kısmı boş geçilemez");
                }
                if (item.LastName == null)
                {
                    throw new Exception("Soyisim kısmı boş geçilemez");
                }
                if (item.Phone == null)
                {
                    throw new Exception("Telefon kısmı boş geçilemez");
                }
                if (item.RoleID == 0)
                {
                    throw new Exception("Kullanıcı rolü belirlenmelidir");
                }
                if (item.DateOfBirth == null)
                {
                    throw new Exception("Doğum tarihi kısmı boş geçilemez");
                }
                if (item.Address == null)
                {
                    throw new Exception("Adres kısmı boş geçilemez");
                }
                _uof.CustomerRepository.Update(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }

        public int GetCustomerId(string firstname,string lastname)
        {
            List<Customer> customerList=GetAll();
            int myID = (from c in customerList
                        where c.FirstName == firstname && c.LastName == lastname
                        select c.ID).SingleOrDefault();
            return myID;
        }

    }
}
