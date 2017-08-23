using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UnitOfWork
    {
        RentACarContext _context;
        DbContextTransaction _transaction;
        public UnitOfWork()
        {
            _context = new RentACarContext();
        }

        private BillRepository _billRepository;

        public BillRepository BillRepository
        {
            get
            {
                if (_billRepository == null)
                {
                    _billRepository = new BillRepository(_context);
                }
                return _billRepository;
            }

        }
        private BillInfoRepository _billInfoRepository;

        public BillInfoRepository BillInfoRepository
        {
            get {
                if (_billInfoRepository==null)
                {
                    _billInfoRepository = new BillInfoRepository(_context);
                }
                return _billInfoRepository;
            }
        }

        private BrandRepository _brandRepository;

        public BrandRepository BrandRepository
        {
            get
            {
                if (_brandRepository == null)
                {
                    _brandRepository = new BrandRepository(_context);
                }

                return _brandRepository;
            }

        }

        private CarHistoryRepository _carhistoryRepository;

        public CarHistoryRepository CarHistoryRepository
        {
            get
            {
                if (_carhistoryRepository == null)
                {
                    _carhistoryRepository = new CarHistoryRepository(_context);
                }
                return _carhistoryRepository;
            }

        }

        private CarInfoRepository _carinfoRepository;

        public CarInfoRepository CarInfoRepository
        {
            get
            {
                if (_carinfoRepository == null)
                {
                    _carinfoRepository = new CarInfoRepository(_context);
                }
                return _carinfoRepository;
            }

        }

        private CarRepository _carRepository;

        public CarRepository CarRepository
        {
            get
            {
                if (_carRepository == null)
                {
                    _carRepository = new CarRepository(_context);
                }
                return _carRepository;
            }

        }

        private CarStateRepository _carStateRepository;

        public CarStateRepository CarStateRepository
        {
            get
            {
                if (_carStateRepository == null)
                {
                    _carStateRepository = new CarStateRepository(_context);
                }
                return _carStateRepository;
            }

        }

        private ColorRepository _colorRepository;

        public ColorRepository ColorRepository
        {
            get
            {
                if (_colorRepository == null)
                {
                    _colorRepository = new ColorRepository(_context);
                }
                return _colorRepository;
            }

        }

        private CustomerRepository _customerRepository;

        public CustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_context);
                }
                return _customerRepository;
            }

        }

        private FuelRepository _fuelRepository;

        public FuelRepository FuelRepository
        {
            get
            {
                if (_fuelRepository == null)
                {
                    _fuelRepository = new FuelRepository(_context);
                }
                return _fuelRepository;
            }

        }

        private GearRepository _gearRepository;

        public GearRepository GearRepository
        {
            get
            {
                if (_gearRepository == null)
                {
                    _gearRepository = new GearRepository(_context);
                }
                return _gearRepository;
            }

        }

        private LoginRepository _loginRepository;

        public LoginRepository LoginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new LoginRepository(_context);
                }
                return _loginRepository;
            }

        }

        private ModelRepository _modelRepository;

        public ModelRepository ModelRepository
        {
            get
            {
                if (_modelRepository == null)
                {
                    _modelRepository = new ModelRepository(_context);
                }
                return _modelRepository;
            }

        }

        private PaymentTypeRepository _paymenttypeRepository;

        public PaymentTypeRepository PaymentTypeRepository
        {
            get
            {
                if (_paymenttypeRepository == null)
                {
                    _paymenttypeRepository = new PaymentTypeRepository(_context);
                }
                return _paymenttypeRepository;
            }

        }

        private RoleRepository _roleRepository;

        public RoleRepository RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                {
                    _roleRepository = new RoleRepository(_context);
                }
                return _roleRepository;
            }

        }


        public bool ApplyChanges()
        {
            bool isSuccess = false;
            _transaction = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            try
            {
                _context.SaveChanges();
                _transaction.Commit();
                isSuccess = true;
            }
            catch (Exception)
            {
                _transaction.Rollback();
                isSuccess = false;

            }
            finally
            {
                _transaction.Dispose();
            }
            return isSuccess;
        }









    }
}
