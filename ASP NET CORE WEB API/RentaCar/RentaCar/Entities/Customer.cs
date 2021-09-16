using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Entities
{
    public class Customer
    {
        [Key]
        public string Dni { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public DateTime LastModificationDate { get; set; }
    }
}
