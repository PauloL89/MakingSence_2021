using Newtonsoft.Json.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarCrud carCrud = new CarCrud();
            int opt;
            Console.WriteLine("Choice option: 0-EXIT, 1-CREATE, 2-READ BY ID, 3-READ ALL, 4-UPDATE, 5-DELETE");

            var option = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter ID to register: ");
                        var idCar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter MODEL to register: ");
                        var modelo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Doors quantity to register: ");
                        var doors = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(@"Enter Brand of car to register: 
                                       0-FIAT, 1-FORD, 2-CHEVROLET, 
                                        3-PEUGEOT, 4-RENAUL, 5-VOLKSWANGEN");
                        var nBrand = Convert.ToInt32(Console.ReadLine());
                        Car.Brand? brand = null;

                        switch (nBrand)
                        {
                            case 0:
                                brand = Car.Brand.Fiat;
                                break;
                            case 1:
                                brand = Car.Brand.Ford;
                                break;
                            case 2:
                                brand = Car.Brand.Chevrolet;
                                break;
                            case 3:
                                brand = Car.Brand.Peugeot;
                                break;
                            case 4:
                                brand = Car.Brand.Renault;
                                break;
                            case 5:
                                brand = Car.Brand.Volkswagen;
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine(@"Enter COLOR to register: 
                                       0-RED, 1-BLUE, 2-YELLOW, 
                                        3-BLACK, 4-WHITE, 5-GRAY,
                                         6-ORANGE, 7-LIGH BLUE, 8-PINK, 
                                          9-VIOLET, 10-GREEN");
                        var nColor = Convert.ToInt32(Console.ReadLine());
                        Car.Color? color = null;

                        switch (nColor)
                        {
                            case 0:
                                color = Car.Color.Red;
                                break;
                            case 1:
                                color = Car.Color.Blue;
                                break;
                            case 2:
                                color = Car.Color.Yellow;
                                break;
                            case 3:
                                color = Car.Color.Black;
                                break;
                            case 4:
                                color = Car.Color.White;
                                break;
                            case 5:
                                color = Car.Color.Gray;
                                break;
                            case 6:
                                color = Car.Color.Orange;
                                break;
                            case 7:
                                color = Car.Color.LigthBlue;
                                break;
                            case 8:
                                color = Car.Color.Pink;
                                break;
                            case 9:
                                color = Car.Color.Violet;
                                break;
                            case 10:
                                color = Car.Color.Green;
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("Enter Box to register: 0-MANUAL, 1-AUTOMATIC");
                        var nCaja = Convert.ToInt32(Console.ReadLine());
                        Car.Box? caja = null;
                        switch (nCaja)
                        {
                            case 0:
                                caja = Car.Box.Manual;
                                break;
                            case 1:
                                caja = Car.Box.Automatic;
                                break;
                            default:
                                break;
                        }

                        Car car = new Car
                        {
                            idCar = idCar,
                            Model = modelo,
                            Doors = doors,
                            brand = brand.Value,
                            color = color.Value,
                            box = caja.Value
                        };

                        carCrud.Create(car);
                        break;
                    case 2:
                        Console.WriteLine("Enter ID to show: ");
                        var id = Convert.ToInt32(Console.ReadLine());
                        carCrud.Get(id);
                        break;
                    case 3:
                        carCrud.GetAll();
                        break;
                    case 4:
                        Console.WriteLine("Enter ID to update: ");
                        var idUpdate = Convert.ToInt32(Console.ReadLine());

                        carCrud.Get(idUpdate);

                        Console.WriteLine("Enter MODEL to update: ");
                        var model = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Doors quantity to update: ");
                        var _doors = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(@"Enter Brand to update: 
                                       0-FIAT, 1-FORD, 2-CHEVROLET, 
                                        3-PEUGEOT, 4-RENAUL, 5-VOLKSWANGEN");
                        var numBrand = Convert.ToInt32(Console.ReadLine());
                        Car.Brand? _brand = null;

                        switch (numBrand)
                        {
                            case 0:
                                _brand = Car.Brand.Fiat;
                                break;
                            case 1:
                                _brand = Car.Brand.Ford;
                                break;
                            case 2:
                               _brand = Car.Brand.Chevrolet;
                                break;
                            case 3:
                                _brand = Car.Brand.Peugeot;
                                break;
                            case 4:
                                _brand = Car.Brand.Renault;
                                break;
                            case 5:
                                _brand = Car.Brand.Volkswagen;
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine(@"Enter COLOR to update: 
                                       0-RED, 1-BLUE, 2-YELLOW, 
                                        3-BLACK, 4-WHITE, 5-GRAY,
                                         6-ORANGE, 7-LIGTH BLUE, 8-PINK, 
                                          9-VIOLET, 10-GREEN");
                        var nCol = Convert.ToInt32(Console.ReadLine());
                        Car.Color? col = null;

                        switch (nCol)
                        {
                            case 0:
                                col = Car.Color.Red;
                                break;
                            case 1:
                                col = Car.Color.Blue;
                                break;
                            case 2:
                                col = Car.Color.Yellow;
                                break;
                            case 3:
                                col = Car.Color.Black;
                                break;
                            case 4:
                                col = Car.Color.White;
                                break;
                            case 5:
                                col = Car.Color.Gray;
                                break;
                            case 6:
                                col = Car.Color.Orange;
                                break;
                            case 7:
                                col = Car.Color.LigthBlue;
                                break;
                            case 8:
                                col = Car.Color.Pink;
                                break;
                            case 9:
                                col = Car.Color.Violet;
                                break;
                            case 10:
                                col = Car.Color.Green;
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("Enter Box to update: 0-MANUAL, 1-AUTOMATIC");
                        var nCaj = Convert.ToInt32(Console.ReadLine());
                        Car.Box? caj = null;
                        switch (nCaj)
                        {
                            case 0:
                                caj = Car.Box.Manual;
                                break;
                            case 1:
                                caj = Car.Box.Automatic;
                                break;
                            default:
                                break;
                        }


                        Car carUpdate = new Car
                        {
                            idCar = idUpdate,
                            Model = model,
                            Doors = _doors,
                            brand = _brand.Value,
                            color = col.Value,
                            box = caj.Value
                        };
                       
                        carCrud.Update(idUpdate, carUpdate);

                        break;
                    case 5:
                        Console.WriteLine("Enter ID to delete: ");
                        var id_delete = Convert.ToInt32(Console.ReadLine());
                        carCrud.Delete(x => x.idCar == id_delete);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        Main(null);
                        break;
                }

                Console.WriteLine("Choice option: 0-EXIT, 1-CREATE, 2-READ BY ID, 3-READ ALL, 4-UPDATE, 5-DELETE");

                opt = Convert.ToInt32(Console.ReadLine());
                option = opt;
            } while (opt > 0);
        }
            
    }
}
