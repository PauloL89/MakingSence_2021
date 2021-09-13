using RentaCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Repositories
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll(string path);
        public Car GetCarDetails(int id,string path);
        public Customer GetCustomerDetails(int dni,string path);
        public void Insert(T entity, string path);
        public void Update(int id, Car entity,string path);
        public void Update(int id, Customer entity,string path);
        public void Delete(int id,string path);
    }
}
