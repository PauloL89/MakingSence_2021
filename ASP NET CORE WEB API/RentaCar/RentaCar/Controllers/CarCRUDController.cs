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
        //private readonly ICarRepository _carRepository;
        private readonly IRepository<Car> _repository;
        public CarCRUDController(IRepository<Car> repository)
        {
            _repository = repository;
        }

        // LIST ALL
        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
           return _repository.GetAll("Json/Cars.json").ToList();
        }

        //Get Car By ID
       [HttpGet("{id}")]
        public Car GetDetails(int id)
        {
           return _repository.GetCarDetails(id,"Json/Cars.json");
        }

        // INSERT
        [HttpPost]
        public void Insert([FromBody] Car car)
        {
            _repository.Insert(car,"Json/Cars.json");
        }

        // UPDATE
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] Car car)
        {
            _repository.Update(id,car,"Json/Cars.json");
        }

        //// DELETE
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id,"Json/Cars.json");
        }


    }

    
}
