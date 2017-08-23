using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Areas.Admin.Models.ViewModels
{
    public class CarVM
    {
        public List<Model> Models { get; set; }
        public List<Gear> Gears { get; set; }
        public List<Fuel> Fuels { get; set; }
        public List<Color> Colors { get; set; }
        public CarInfo CarInfos { get; set; }
    }
}