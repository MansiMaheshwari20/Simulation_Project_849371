using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimulationProject5.Carhelper
{
    public class CarRentAPI
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51534");
            return client;
        }
    }
}
