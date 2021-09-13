using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Entities
{
    public class Customer
    {
        public int Dni { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Telephone { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Province { get; set; }
        public int PostalCode { get; set; }
        public DateTime LastModificationDate { get; set; }
    }
}
