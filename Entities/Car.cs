using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Car
    {
        public Car()
        {
            CarHistories = new HashSet<CarHistory>();
        }
        public int ID { get; set; }

        public decimal  RentPrice { get; set; }
        public int ModelID { get; set; }
        public virtual Model Model { get; set; }

        public int Capacity { get; set; }


        public int ColorID { get; set; }
        public virtual Color Color { get; set; }

        public int GearID { get; set; }
        public virtual Gear Gear { get; set; }

        public int FuelID { get; set; }
        public virtual Fuel Fuel { get; set; }

        public decimal EnginePower { get; set; }
        public decimal EngineSize { get; set; }

        public string  PictureURL { get; set; }

  
        public virtual CarInfo CarInfo { get; set; }

        public virtual ICollection<CarHistory> CarHistories { get; set; }

    }
}
