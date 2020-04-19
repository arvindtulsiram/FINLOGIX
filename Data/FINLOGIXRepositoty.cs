using System.Collections.Generic;
using System.Threading.Tasks;
using FINLOGIX.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FINLOGIX.API.Data
{
    public class FINLOGIXRepositoty : IFINLOGIXRepository
    {
        private readonly DataContext _context;
        public FINLOGIXRepositoty(DataContext context)
        {
            this._context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            return await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.Include(p => p.Photos).ToListAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}