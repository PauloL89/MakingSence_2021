using RentaCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Repositories
{
    public interface ICarRepository
    {

        public IEnumerable<Car> GetAllCars();
        public Car GetCarDetails(int id);
        public void InsertCar(Car car);
        public void UpdateCar(int id,Car car);
        public void DeleteCar(int id);
    }
}
