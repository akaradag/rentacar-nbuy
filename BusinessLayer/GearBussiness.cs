using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GearBussiness:IBussiness<Gear>
    {
        UnitOfWork _uof;
        public GearBussiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(Gear item)
        {
            if (item != null)
            {
                if (item.Name == null)
                {
                    throw new Exception("Vites tipi oluşturulurken mutlaka isim girilmelidir");
                }
                _uof.GearRepository.Add(item);
                return _uof.ApplyChanges();

            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }

        public Gear Get(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Veri bulunamadı.");
            }
            return _uof.GearRepository.Get(id);
        }

        public List<Gear> GetAll()
        {
            return _uof.GearRepository.GetAll();
        }

        public bool Remove(Gear item)
        {
            if (item != null)
            {
                _uof.GearRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı.");
            }
        }

        public bool Update(Gear item)
        {
            if (item != null)
            {
                if (item.Name == null)
                {
                    throw new Exception("Vites tipi oluşturulurken mutlaka isim girilmelidir");
                }
                _uof.GearRepository.Update(item);
                return _uof.ApplyChanges();

            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }
    }
}
