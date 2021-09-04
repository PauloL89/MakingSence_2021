using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RentaCar.Entities;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaCar.Repositories;

namespace RentaCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarCRUDController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        public CarCRUDController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        // LIST ALL
        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
           return _carRepository.GetAllCars().ToList();
        }

        //Get Car By ID
       [HttpGet("{id}")]
        public Car GetDetails(int id)
        {
           return _carRepository.GetCarDetails(id);
        }

        // INSERT
        [HttpPost]
        public void Insert([FromBody] Car car)
        {

            _carRepository.InsertCar(car);
        }

        // UPDATE
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] Car car)
        {
            _carRepository.UpdateCar(id,car);
        }

        //// DELETE
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _carRepository.DeleteCar(id);
        }


    }

    
}
