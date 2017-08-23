using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class CarWithInfoVM
    {
        public int ID { get; set; }
        public decimal RentPrice { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Capacity { get; set; }
        public string Color { get; set; }
        public string Gear { get; set; }
        public string Fuel { get; set; }
        public decimal EnginePower { get; set; }
        public decimal EngineSize { get; set; }
        public string  Picture { get; set; }
    }
}