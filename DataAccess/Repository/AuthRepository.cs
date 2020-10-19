using Microsoft.EntityFrameworkCore;
using Models;
using SimulationProject5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repository
{
    public class AuthRepository : IRepository<Authen>
    {
        private readonly ApplicationDbContext _context;
        public AuthRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Authen item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Authen Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Authen> GetAll()
        {
           // throw new NotImplementedException();
            return _context.Authens.ToList();
        }

        public void Update(Authen item)
        {
            throw new NotImplementedException();
        }
    }
}
