using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Entities
{
    public class Car
    {
        public int idCar { get; set; }
        public int model { get; set; }
        public int door { get; set; }
        public Brand brand { get; set; }
        public Color color { get; set; }
        public Box box { get; set; }

    }
}
