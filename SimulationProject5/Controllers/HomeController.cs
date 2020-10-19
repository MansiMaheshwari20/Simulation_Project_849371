using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Newtonsoft.Json;
using SimulationProject5.Carhelper;
using SimulationProject5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace SimulationProject3.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        CarAPI obj = new CarAPI();
        public IActionResult Welcome()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            List<Car> cars = new List<Car>();
            HttpClient client = obj.Initial();
            HttpResponseMessage res = await client.GetAsync("api/CarsApi");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                cars = JsonConvert.DeserializeObject<List<Car>>(result);
            }
            return View(cars);

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
