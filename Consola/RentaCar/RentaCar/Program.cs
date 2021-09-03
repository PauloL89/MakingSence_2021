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
                        Brand? brand = null;

                        switch (nBrand)
                        {
                            case 0:
                                brand = Brand.Fiat;
                                break;
                            case 1:
                                brand = Brand.Ford;
                                break;
                            case 2:
                                brand = Brand.Chevrolet;
                                break;
                            case 3:
                                brand = Brand.Peugeot;
                                break;
                            case 4:
                                brand = Brand.Renault;
                                break;
                            case 5:
                                brand = Brand.Volkswagen;
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
                        Color? color = null;

                        switch (nColor)
                        {
                            case 0:
                                color = Color.Red;
                                break;
                            case 1:
                                color = Color.Blue;
                                break;
                            case 2:
                                color = Color.Yellow;
                                break;
                            case 3:
                                color = Color.Black;
                                break;
                            case 4:
                                color = Color.White;
                                break;
                            case 5:
                                color = Color.Gray;
                                break;
                            case 6:
                                color = Color.Orange;
                                break;
                            case 7:
                                color = Color.LigthBlue;
                                break;
                            case 8:
                                color = Color.Pink;
                                break;
                            case 9:
                                color = Color.Violet;
                                break;
                            case 10:
                                color = Color.Green;
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("Enter Box to register: 0-MANUAL, 1-AUTOMATIC");
                        var nCaja = Convert.ToInt32(Console.ReadLine());
                        Box? caja = null;
                        switch (nCaja)
                        {
                            case 0:
                                caja = Box.Manual;
                                break;
                            case 1:
                                caja = Box.Automatic;
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
                        Brand? _brand = null;

                        switch (numBrand)
                        {
                            case 0:
                                _brand = Brand.Fiat;
                                break;
                            case 1:
                                _brand = Brand.Ford;
                                break;
                            case 2:
                               _brand = Brand.Chevrolet;
                                break;
                            case 3:
                                _brand = Brand.Peugeot;
                                break;
                            case 4:
                                _brand = Brand.Renault;
                                break;
                            case 5:
                                _brand = Brand.Volkswagen;
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
                        Color? col = null;

                        switch (nCol)
                        {
                            case 0:
                                col = Color.Red;
                                break;
                            case 1:
                                col = Color.Blue;
                                break;
                            case 2:
                                col = Color.Yellow;
                                break;
                            case 3:
                                col = Color.Black;
                                break;
                            case 4:
                                col = Color.White;
                                break;
                            case 5:
                                col = Color.Gray;
                                break;
                            case 6:
                                col = Color.Orange;
                                break;
                            case 7:
                                col = Color.LigthBlue;
                                break;
                            case 8:
                                col = Color.Pink;
                                break;
                            case 9:
                                col = Color.Violet;
                                break;
                            case 10:
                                col = Color.Green;
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("Enter Box to update: 0-MANUAL, 1-AUTOMATIC");
                        var nCaj = Convert.ToInt32(Console.ReadLine());
                        Box? caj = null;
                        switch (nCaj)
                        {
                            case 0:
                                caj = Box.Manual;
                                break;
                            case 1:
                                caj = Box.Automatic;
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
