using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ModelBussiness:IBussiness<Model>
    {
        UnitOfWork _uof;
        public ModelBussiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(Model item)
        {
            if (item!=null)
            {
                if (item.Name==null)
                {
                    throw new Exception("Model oluşturulurken mutlaka bir isim verilemlidir");
                }
                if (item.BrandID==0)
                {
                    throw new Exception("Model oluşturulurken mutlaka markası belirtilmelidir");
                }
                _uof.ModelRepository.Add(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }

        public Model Get(int id)

        {
            if (id <= 0)
            {
                throw new Exception("Veri bulunamadı.");
            }
            return _uof.ModelRepository.Get(id);
        }

        public List<Model> GetAll()
        {
            return _uof.ModelRepository.GetAll();
        }

        public bool Remove(Model item)
        {
            if (item != null)
            {
                _uof.ModelRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı.");
            }
        }

        public bool Update(Model item)
        {
            if (item != null)
            {
                if (item.Name == null)
                {
                    throw new Exception("Model oluşturulurken mutlaka bir isim verilemlidir");
                }
                if (item.BrandID == 0)
                {
                    throw new Exception("Model oluşturulurken mutlaka markası belirtilmelidir");
                }
                _uof.ModelRepository.Update(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }
    }
}
