using System.Collections.Generic;
using System.Threading.Tasks;
using FINLOGIX.API.Models;

namespace FINLOGIX.API.Data
{
    public interface IFINLOGIXRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}