using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class CustomerLoginViewModel
    {
        public Customer Customer { get; set; }
        public Login Login { get; set; }
        public string RepeatPassword
        {
            get { return Login.Password; }
        }

    }
}