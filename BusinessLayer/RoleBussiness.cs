using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RoleBussiness:IBussiness<Role>
    {
        UnitOfWork _uof;
        public RoleBussiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(Role item)
        {
            if (item != null)
            {

                if (item.Name == null)
                {
                    throw new Exception("Rol oluşturulurken  adı  boş geçilemez.");
                }
                _uof.RoleRepository.Add(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }

        public Role Get(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Veri bulunamadı.");
            }
            return _uof.RoleRepository.Get(id);
        }

        public List<Role> GetAll()
        {
            return _uof.RoleRepository.GetAll();
        }

        public bool Remove(Role item)
        {
            if (item != null)
            {
                _uof.RoleRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı.");
            }
        }

        public bool Update(Role item)
        {
            if (item != null)
            {

                if (item.Name == null)
                {
                    throw new Exception("Rol oluşturulurken  adı  boş geçilemez.");
                }
                _uof.RoleRepository.Update(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }
    }
}
