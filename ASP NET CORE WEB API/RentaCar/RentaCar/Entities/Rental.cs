using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Entities
{
    public class Rental
    {
        [Key]
        public int IdRental { get; set; }
        public int RentalDuration { get; set; }
        public string DNICustomer { get; set; }
        public int IdCar { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
