using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Entities
{
    public class Car
    {
        [Key]
        public int IdCar { get; set; }
        public int Model { get; set; }
        public int Doors { get; set; }
        public int IdBrand { get; set; }
        public int IdColor { get; set; }
        public int IdBox { get; set; }

    }
}
