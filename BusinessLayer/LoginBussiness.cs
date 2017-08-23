using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoginBussiness:IBussiness<Login>
    {
        UnitOfWork _uof;
        public LoginBussiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(Login item)
        {
            if (item!=null)
            {
                if (item.UserName==null)
                {
                    throw new Exception("Kullanıcı oluşturulurken kullanıcı adı kısmı boş geçilemez.");
                }
                if (item.Password==null)
                {
                    throw new Exception("Kullanıcı oluşturulurken parola kısmı boş geçilemez");
                }
                _uof.LoginRepository.Add(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }

        public Login Get(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Veri bulunamadı.");
            }
            return _uof.LoginRepository.Get(id);
        }

        public List<Login> GetAll()
        {
            return _uof.LoginRepository.GetAll();
        }

        public bool Remove(Login item)
        {
            if (item != null)
            {
                _uof.LoginRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı.");
            }
        }

        public bool Update(Login item)
        {
            if (item != null)
            {
                if (item.UserName == null)
                {
                    throw new Exception("Kullanıcı oluşturulurken kullanıcı adı kısmı boş geçilemez.");
                }
                if (item.Password == null)
                {
                    throw new Exception("Kullanıcı oluşturulurken parola kısmı boş geçilemez");
                }
                _uof.LoginRepository.Update(item);
                return _uof.ApplyChanges();
            }
            else
            {
                throw new Exception("Veri bulunamadı");
            }
        }
        public Login GetLogin(string username,string password)
        {
            List<Login> loginList = new List<Login>();
            loginList = GetAll();

            Login login = (from l in loginList
                                 where l.UserName == username && l.Password == password
                                 select l).SingleOrDefault();

            return login;
            
        }
    }
}
