using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class SturbucksCustomer
    {
        [Key]
        public int SturbucksCustomerId { get; set; }

        public long SturbucksCustomerIdentityNumber { get; set; }

        public string SturbucksCustomerName { get; set; }

        public string SturbucksCustomerSurname { get; set; }

        public DateTime SturbucksCustomerBirtdate { get; set; }
    }
}
