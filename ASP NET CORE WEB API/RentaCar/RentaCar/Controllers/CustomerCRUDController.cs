using Microsoft.AspNetCore.Mvc;
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
        private readonly IRepository<Customer> _Repository;
        public CustomerCRUDController(IRepository<Customer> repository)
        {
            _Repository = repository;
        }

        // LIST ALL
        [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
            
            return _Repository.GetAll("Json/Customers.json").ToList();
        }

        //Get Car By ID
        [HttpGet("{id}")]
        public Customer GetDetails(int dni)
        {
            return _Repository.GetCustomerDetails(dni,"Json/Customers.json");
        }

        // INSERT
        [HttpPost]
        public void Insert([FromBody] Customer customer)
        {
            _Repository.Insert(customer,"Json/Customers.json");
        }

        // UPDATE
        [HttpPut("{id}")]
        public void Update(int dni, [FromBody] Customer customer)
        {
            _Repository.Update(dni, customer,"Json/Customers.json");
        }

        //// DELETE
        [HttpDelete("{id}")]
        public void Delete(int dni)
        {
            _Repository.Delete(dni,"Json/Customers.json");
        }
    }
}
