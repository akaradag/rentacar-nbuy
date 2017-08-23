using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class BillInfoVM
    {
        public string CustomerName { get; set; }
        public DateTime CustomerBirth { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerMail { get; set; }
        public int CustomerSocialNum { get; set; }
        public string CustomerAddress { get; set; }
        public string BillFirstName { get; set; }
        public string BillLastName { get; set; }
        public string BillAddress { get; set; }
        public string BillCountry { get; set; }
        public string BillCompanyName { get; set; }
        public string BillTaxOffice { get; set; }
        public int BillTaxNo { get; set; }
        public string BillCompanyCountry { get; set; }
        public string BillCompanyAddress { get; set; }
        public int PayCardNo { get; set; }
        public string PayCardName { get; set; }
        public string PayCardExpiry { get; set; }
        public int PayCardCVC { get; set; }
        public bool IsPersonalBill { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
    }
}