
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task.Models;

namespace task.repositories
{
    public class Repository<T> : IRepository<T> where T :class
    {
         static Model1 _applicationDbContext =new Model1();
        private static  readonly DbSet<T> entities= _applicationDbContext.Set<T>();


        #region Add
        public async Task< int> add(T obj)
        {
            entities.Add(obj);
            return await _applicationDbContext.SaveChangesAsync();
        }
        #endregion

        #region Get All
        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }
        #endregion

        #region Get By Id
        public async Task< T> GetById(int id)
        {
            return await entities.FindAsync(id);

        }
        #endregion

        #region Delete
        public async Task Delete(int id)
        {

            T x =await entities.FindAsync(id);
             entities.Remove(x);
            _applicationDbContext.SaveChanges();
        }
        #endregion
        public  void Update(T obj)
        {
            _applicationDbContext.Entry<T>(obj).State = EntityState.Modified;
            _applicationDbContext.SaveChanges();
        }
    }
}
