using Microsoft.EntityFrameworkCore;
using Models;
using SimulationProject5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repository
{
    public class CarRepository : IRepository<Car>

    {
        private readonly ApplicationDbContext _context;
        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Car item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAll()
        {
            return _context.Cars.Include(c => c.CarType).ToList();
        }

        public void Update(Car item)
        {
            throw new NotImplementedException();
        }
    }
}
