using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Connection
{
    public class JsonConnection
    {
        public JsonConnection(string connectionString) => ConnectionString = connectionString;

        public string ConnectionString { get; set; }

    }
}
