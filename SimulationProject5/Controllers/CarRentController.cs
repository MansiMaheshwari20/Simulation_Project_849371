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

namespace SimulationProject5.Controllers
{
    public class CarRentController : Controller
    {

        private readonly ILogger<CarRentController> _logger;

        public CarRentController(ILogger<CarRentController> logger)
        {
            _logger = logger;
        }
        CarRentAPI obj = new CarRentAPI();
        public IActionResult Welcome()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            List<RentalCar> rent = new List<RentalCar>();
            HttpClient client = obj.Initial();
            HttpResponseMessage res = await client.GetAsync("api/CarsRental");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                rent = JsonConvert.DeserializeObject<List<RentalCar>>(result);
            }
            return View(rent);

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
