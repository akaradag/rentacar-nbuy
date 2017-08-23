using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BrandBussiness : IBussiness<Brand>
    {
        UnitOfWork _uof;
        Customer _user;
        public BrandBussiness()
        {
            _uof = new UnitOfWork();
            
        }
      

        public bool Add(Brand item)
        {
          
                if(item == null) { throw new Exception("Hatalı işlem."); }
                if (item.Name == null) { throw new Exception("Markanın ismini giriniz."); }
                try
                {
                    _uof.BrandRepository.Add(item);
                    return _uof.ApplyChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            
          
        }

        public Brand Get(int id)
        {
            try
            {
                return _uof.BrandRepository.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Brand> GetAll()
        {
            try
            {
                return _uof.BrandRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Remove(Brand item)
        {
           
                try
                {
                    _uof.BrandRepository.Remove(item);
                    return _uof.ApplyChanges(); 
                }
                catch (Exception ex)
                {
                    throw ex;
                }
           
        }

        public bool Update(Brand item)
        {
           
                if (item == null) { throw new Exception("Hatalı işlem."); }
                if (item.Name == null) { throw new Exception("Markanın ismini giriniz."); }
                try
                {
                    _uof.BrandRepository.Update(item);
                    return _uof.ApplyChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
          
        }
    }
}
