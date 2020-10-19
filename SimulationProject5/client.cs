using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimulationProject5
{
    public class client
    {
        public HttpClient CarDetails()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51533");
            return client;
        }

        public HttpClient AuthClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51536");
            return client;
        }
    }
}
