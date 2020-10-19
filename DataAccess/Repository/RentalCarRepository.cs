using Microsoft.EntityFrameworkCore;
using Models;
using SimulationProject5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repository
{
    public class RentalCarRepository : IRepository<RentalCar>
    {
        private readonly ApplicationDbContext _context;
        public RentalCarRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(RentalCar item)
        {
            _context.RentalCars.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public RentalCar Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RentalCar> GetAll()
        {
            return _context.RentalCars.Include(c => c.Car).ToList();
        }

        public void Update(RentalCar item)
        {
            throw new NotImplementedException();
        }
    }
}
