using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Newtonsoft.Json;
using SimulationProject5.Carhelper;
using SimulationProject5.Models;

namespace SimulationProject5.Controllers
{
    public class AuthCheckController : Controller
    {
        client cs = new client();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Index(Authen auth)
        {
            HttpClient client12 = cs.AuthClient();
            var contentType = new MediaTypeWithQualityHeaderValue
       ("application/json");
            client12.DefaultRequestHeaders.Accept.Add(contentType);
            string Data = JsonConvert.SerializeObject(auth);
            var contentData = new StringContent(Data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = client12.PostAsync("api/AuthApi", contentData).Result;
            string jwtdata = response.Content.ReadAsStringAsync().Result;
            webtoken jwt = JsonConvert.DeserializeObject<webtoken>(jwtdata);
            if (jwt.Token == null)
                return RedirectToAction("Index");

            HttpContext.Session.SetString("token", jwt.Token);
            return RedirectToAction("Access");
        }
       
        public class webtoken
        {
            public string Token { get; set; }
        }
       
        [HttpGet]
        public async Task<IActionResult> Access()
        {
            List<Car> cars = new List<Car>();
            HttpClient client34 = cs.CarDetails();
            HttpResponseMessage res = await client34.GetAsync("api/CarsApi");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                cars = JsonConvert.DeserializeObject<List<Car>>(result);
            }
            return View(cars);
        }



    }
}