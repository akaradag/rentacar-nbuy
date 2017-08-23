using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CarStateBussiness : IBussiness<CarState>
    {
        UnitOfWork _uof;
        public CarStateBussiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(CarState item)
        {
            if (item != null)
            {
                if (item.Name == null)
                {
                    throw new Exception("Araba Durumu Oluşturulurken mutlaka isim girilmelidir");
                }
                _uof.CarStateRepository.Add(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }

        public CarState Get(int id)
        {
            if (id<=0)
            {
                throw new Exception("Durum bulunamadı.");
            }
            else
            {
                return _uof.CarStateRepository.Get(id);
            }
        }

        public List<CarState> GetAll()
        {
            return _uof.CarStateRepository.GetAll();
        }

        public bool Remove(CarState item)
        {
            if (item!=null)
            {
                _uof.CarStateRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Silincek veri bulunamadı");
            }
        }

        public bool Update(CarState item)
        {
            if (item != null)
            {
                if (item.Name == null)
                {
                    throw new Exception("Araba Durumu Oluşturulurken mutlaka isim girilmelidir");
                }
                _uof.CarStateRepository.Update(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }
    }
}
