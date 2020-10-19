using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace CarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsApiController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(CarsApiController));
        IRepository<Car> _car;

        public CarsApiController(IRepository<Car> carsrepo)
        {
            _car = carsrepo;

        }


        // GET: api/CarsApi
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            _log4net.Info("Get Api Initiated");
            return _car.GetAll();
        }

        // GET: api/CarsApi/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        // POST: api/CarsApi
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT: api/CarsApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
