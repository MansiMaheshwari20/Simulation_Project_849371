using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace CarRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsRentalController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(CarsRentalController));
        IRepository<RentalCar> _carrent;
        public CarsRentalController(IRepository<RentalCar> carsreporent)
        {
            _carrent = carsreporent;
        }
        // GET: api/CarsRental
        [HttpGet]
        public IEnumerable<RentalCar> Get()
        {
            _log4net.Info("Get Api Initiated");
            return _carrent.GetAll();
        }

        // GET: api/CarsRental/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CarsRental
        [HttpPost]
        public IActionResult Post(RentalCar rentcar)
        {
            _log4net.Info("Post Api Initiated");
            using (var scope = new TransactionScope())
            {
                _carrent.Add(rentcar);
                scope.Complete();
                return Ok();
            }
        }

        // PUT: api/CarsRental/5
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
