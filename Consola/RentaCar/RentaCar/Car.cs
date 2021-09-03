
namespace RentaCar
{
    class Car
    {
        public int idCar { get; set; }
        public int Model { get; set; }
        public int Doors { get; set; }
        public Brand brand { get; set; }
        public Color color { get; set; }
        public Box box { get; set; }


        public string ToStringCar()
        {
            return $" Id car: {idCar}\n Model: { Model}\n Doors: { Doors}\n Brand: { brand}\n Color: { color}\n Box:  {box}\n";
        }
    }
}
