using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ColorBussiness : IBussiness<Color>
    {
        UnitOfWork _uof;
        public ColorBussiness()
        {
            _uof = new UnitOfWork();
        }
        public bool Add(Color item)
        {
            if (item != null)
            {
                if (item.Name == null)
                {
                    throw new Exception("Renk Oluşturulurken mutlaka isim girilmelidir");
                }
                _uof.ColorRepository.Add(item);
                return _uof.ApplyChanges();
               
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }

        public Color Get(int id)
        {
            if (id<=0)
            {
                throw new Exception("Renk Bulunamadı.");
            }
            return _uof.ColorRepository.Get(id);
            
        }

        public List<Color> GetAll()
        {
            return _uof.ColorRepository.GetAll();
        }

        public bool Remove(Color item)
        {
            if (item!=null)
            {
                _uof.ColorRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Silinecek veri bulunamadı.");
            }
        }

        public bool Update(Color item)
        {
            if (item != null)
            {
                if (item.Name == null)
                {
                    throw new Exception("Renk Oluşturulurken mutlaka isim girilmelidir");
                }
                _uof.ColorRepository.Update(item);
                return _uof.ApplyChanges();

            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }
    }
}
