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
    public class Repository<T>: IRepository<T>
    {
        private JsonConnection _connection;
        List<T> entities = new();
        public Repository(JsonConnection connection)
        {
            _connection = connection;
        }

        public void Delete(int id, string path)
        {
            Load(path);
            entities.RemoveAt(id);
            Save(path);
        }

        public IEnumerable<T> GetAll(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<T> entities = JsonConvert.DeserializeObject<List<T>>(json);

                return entities.ToList();
            }
        }
        //GET CAR BY ID
        public Car GetCarDetails(int id, string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                Car car = new Car();
                List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
                foreach (var item in cars)
                {
                    if (item.idCar == id)
                    {
                        car = item;
                    }
                }
                return car;
            }
        }

        //GET CUSTOMER BY ID
        public Customer GetCustomerDetails(int dni, string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                Customer customer = new Customer();
                List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(json);
                foreach (var item in customers)
                {
                    if (item.Dni == dni)
                    {
                        customer = item;
                    }
                }
                return customer;
            }
        }

        public void Insert(T entity, string path)
        {
            Load(path);
            entities.Add(entity);
            Save(path);
        }
        //Update Car
        public void Update(int id, Car entity, string path)
        {
            List<Car> cars = new();

            Load(path);

            foreach (var item in cars)
            {
                if (item.idCar == id)
                {
                    item.idCar = entity.idCar;
                    item.model = entity.model;
                    item.door = entity.door;
                    item.brand = entity.brand;
                    item.color = entity.color;
                    item.box = entity.box;
                }
            }

            Save(path);
        }
        //Update Customer
        public void Update(int id, Customer entity, string path)
        {
            List<Customer> customers = new();
            Load(path);

            foreach (var item in customers)
            {
                if (item.Dni == id)
                {
                    item.Dni = entity.Dni;
                    item.Name = entity.Name;
                    item.LastName = entity.LastName;
                    item.Address = entity.Address;
                    item.Telephone = entity.Telephone;
                    item.PostalCode = entity.PostalCode;
                    item.Town = entity.Town;
                    item.Province = entity.Province;
                    item.LastModificationDate = entity.LastModificationDate;
                }
            }
            Save(path);
        }

        public void Save(string path)
        {
            string json = JsonConvert.SerializeObject(entities);
            File.WriteAllText(path, json);
        }

        public void Load(string path)
        {
            
            string json = File.ReadAllText(path);
            entities = JsonConvert.DeserializeObject<List<T>>(json);
        }

        
    }
}
