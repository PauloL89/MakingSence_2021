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
using RentaCar.Connection;

namespace RentaCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarCRUDController : ControllerBase
    {
        private readonly ContexDB _contex;
        public CarCRUDController(ContexDB contex)
        {
            _contex = contex;
        }

        // LIST ALL
        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            return _contex.cars.ToList();
        }

        //Get Car By ID
       [HttpGet("{id}")]
        public Car GetDetails(int id)
        {
           var car = _contex.cars.FirstOrDefault(p => p.IdCar == id);
            return car;
        }

        // INSERT
        [HttpPost]
        public Car Insert([FromBody] Car car)
        {
            try
            {
                _contex.cars.Add(car);
                _contex.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return car;
        }

        // UPDATE
        [HttpPut("{id}")]
        public Car Update(int id, [FromBody] Car car)
        {
            if (car.IdCar == id) 
            {
                _contex.Entry(car).State = EntityState.Modified;
                _contex.SaveChanges();
            }
            else 
            {
                BadRequest();
            }
            return car;
        }

        //// DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var car = _contex.cars.FirstOrDefault(p => p.IdCar == id);
            if(car != null) 
            {
                _contex.Remove(car);
                _contex.SaveChanges();
                return Ok();
            }
            else 
            {
                return BadRequest();
            }
        }


    }

    
}
