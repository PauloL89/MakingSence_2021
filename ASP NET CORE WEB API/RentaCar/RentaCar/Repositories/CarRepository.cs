using Newtonsoft.Json;
using RentaCar.Connection;
using RentaCar.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Repositories
{
    public class CarRepository: ICarRepository
    {
        private JsonConnection _connection;
        List<Car> cars = new List<Car>();
        public CarRepository(JsonConnection connection)
        {
            _connection = connection;
        }

        public void DeleteCar(int id)
        {
            Load();
            cars.RemoveAt(id);
            Save();
        }

        public IEnumerable<Car> GetAllCars()
        {
            using (StreamReader r = new StreamReader(_connection.ConnectionString))
            {
                string json = r.ReadToEnd();       
                List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
                
                return cars.ToList();
            }
        }

        public Car GetCarDetails(int id)
        {
            using (StreamReader r = new StreamReader(_connection.ConnectionString))
            {
                string json = r.ReadToEnd();
                Car car = new Car();
                List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
                foreach (var item in cars)
                {
                    if(item.idCar == id) 
                    {
                        car = item;
                    }
                }
                return car;
            }
        }

        public void InsertCar(Car car)
        {
            Load();
            cars.Add(car);
            Save();
        }

        public void UpdateCar(int id, Car car)
        {
            Load();
            foreach (var item in cars)
            {
                if (item.idCar == id) 
                {
                    item.idCar = car.idCar;
                    item.model = car.model;
                    item.door = car.door;
                    item.brand = car.brand;
                    item.color = car.color;
                    item.box = car.box;
                }
            }
            Save();
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(cars);
            File.WriteAllText(_connection.ConnectionString, json);
        }

        public void Load()
        {
            string json = File.ReadAllText(_connection.ConnectionString);
            cars = JsonConvert.DeserializeObject<List<Car>>(json);
        }
    }
}
