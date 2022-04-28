using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task.repositories
{
    public interface IRepository<T>
    {
        Task<int> add(T obj);
        Task Delete(int id);
        Task<IEnumerable<T>> GetAll();
  
        Task<T> GetById(int id);
    }
}