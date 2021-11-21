using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class PortalkahveCustomer
    {

        [Key]
        public int PortalkahveCustomerId { get; set; }

        public long PortalkahveCustomerIdentityNumber { get; set; }

        public string PortalkahveCustomerName { get; set; }

        public string PortalkahveCustomerSurname { get; set; }

        public DateTime PortalkahveCustomerBirtdate { get; set; }
    }
}
