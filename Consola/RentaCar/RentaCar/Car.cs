using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar
{
    class Car
    {
        public int idCar { get; set; }
        public int Model { get; set; }
        public int DoorQuantity { get; set; }
        public enum Mark { Fiat, Ford, Chevrolet, Peugeot, Renault, Volkswagen }
        public Mark mark { get; set; }
        public enum Color {Red,Blue,Yellow,Black,White,Gray,Orange,LigthBlue,Pink,Violet,Green}
        public Color color { get; set; }
        public enum Box { Manual, Automatic }
        public Box box { get; set; }


        public string ToStringCar() 
        {
            return " Id car: " + idCar +
                "\n Model: " + Model +
                "\n Door quantity: " + DoorQuantity +
                "\n Mark: " + mark + 
                "\n Color: " + color +
                "\n Box: " + box +
                "\n";
        }
    }
}
