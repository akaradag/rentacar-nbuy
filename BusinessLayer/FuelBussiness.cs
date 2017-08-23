using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FuelBussiness : IBussiness<Fuel>
    {
        UnitOfWork _uof;

        public FuelBussiness()
        {
            _uof = new UnitOfWork();
        }
        public bool Add(Fuel item)
        {
            if (item != null)
            {
                if (item.Name == null)
                {
                    throw new Exception("Yakıt tipi oluşturulurken mutlaka isim girilmelidir");
                }
                _uof.FuelRepository.Add(item);
                return _uof.ApplyChanges();

            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }

        public Fuel Get(int id)
        {
            if (id<=0)
            {
                throw new Exception("Veri bulunamadı.");
            }
            return _uof.FuelRepository.Get(id);
        }

        public List<Fuel> GetAll()
        {
            return _uof.FuelRepository.GetAll();
        }

        public bool Remove(Fuel item)
        {
            if (item!=null)
            {
                _uof.FuelRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı.");
            }
        }

        public bool Update(Fuel item)
        {
            if (item != null)
            {
                if (item.Name == null)
                {
                    throw new Exception("Renk Oluşturulurken mutlaka isim girilmelidir");
                }
                _uof.FuelRepository.Update(item);
                return _uof.ApplyChanges();

            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }
    }
}
