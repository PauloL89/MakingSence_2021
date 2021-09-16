using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentaCar.Connection;
using RentaCar.Entities;
using RentaCar.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RentaCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerCRUDController : ControllerBase
    {
        private readonly ContexDB _contex;
        public CustomerCRUDController(ContexDB contex)
        {
            _contex = contex;
        }

        // LIST ALL
        [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
            
            return _contex.customers.ToList();
        }

        //Get Car By ID
        [HttpGet("{id}")]
        public Customer GetDetails(string dni)
        {
            var customer = _contex.customers.FirstOrDefault(p => p.Dni == dni);
            return customer;
        }

        // INSERT
        [HttpPost]
        public Customer Insert([FromBody] Customer customer)
        {
            try
            {
                _contex.customers.Add(customer);
                _contex.SaveChanges();
            }
            catch (Exception)
            {
                BadRequest();
                throw;
            }
            return customer;
        }

        // UPDATE
        [HttpPut("{id}")]
        public Customer Update(string dni, [FromBody] Customer customer)
        {
            if(customer.Dni == dni) 
            {
                _contex.Entry(customer).State = EntityState.Modified;
                _contex.SaveChanges();
            }
            else 
            {
                BadRequest();
            }
            return customer;
        }

        //// DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(string dni)
        {
            var customer = _contex.customers.FirstOrDefault(p => p.Dni == dni);
            if(customer.Dni != null) 
            {
                _contex.Remove(customer);
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
