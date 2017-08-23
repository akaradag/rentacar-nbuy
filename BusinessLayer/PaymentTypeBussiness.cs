using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PaymentTypeBussiness:IBussiness<PaymentType>
    {
        UnitOfWork _uof;
        public PaymentTypeBussiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(PaymentType item)
        {
            if (item != null)
            {
                
                if (item.Name == null)
                {
                    throw new Exception("Ödeme tipi oluşturulurken  adı  boş geçilemez.");
                }
                _uof.PaymentTypeRepository.Add(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }

        public PaymentType Get(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Veri bulunamadı.");
            }
            return _uof.PaymentTypeRepository.Get(id);
        }

        public List<PaymentType> GetAll()
        {
            return _uof.PaymentTypeRepository.GetAll();
        }

        public bool Remove(PaymentType item)
        {
            if (item != null)
            {
                _uof.PaymentTypeRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı.");
            }
        }

        public bool Update(PaymentType item)
        {
            if (item != null)
            {

                if (item.Name == null)
                {
                    throw new Exception("Ödeme tipi oluşturulurken  adı  boş geçilemez.");
                }
                _uof.PaymentTypeRepository.Update(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }
    }
}
