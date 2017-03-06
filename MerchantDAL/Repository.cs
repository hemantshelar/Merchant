using DAL.DbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantDAL
{
    public class Repository<T> : IRepository<T> where T : DbEntity
    {
        private MerchantDbContext _context = null;
        private DbSet<T> _entities;

        public Repository(MerchantDbContext _context)
        {
            this._context = _context;
            _entities = _context.Set<T>();
        }

        public T Get(int id)
        {
            var result = _entities.Find(id);
            return result;
        }

        public void Update(T updatedT)
        {
            updatedT.date_modified = DateTime.Now;
            _entities.Attach(updatedT);
            _context.Entry(updatedT).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var entityToDelete = this.Get(id);
            _entities.Remove(entityToDelete);
        }

        public void Delete(T tToBeDeleted)
        {
            _entities.Remove(tToBeDeleted);
        }

        public void Add(T newEntity)
        {
            newEntity.date_modified = DateTime.Now;
            newEntity.date_created = DateTime.Now;
            _entities.Add(newEntity);
        }

        public List<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null, int pageNo = -1, int pageSize = 10)
        {
            if (predicate == null)
            {
                predicate = t => true;
            }
            var result = _entities.Where(predicate);

            if (pageNo != -1)
            {
                result = result.Skip((pageNo - 1) * pageSize).Take(pageSize);
            }

            List<T> dynamicResult = result.ToList();
            return dynamicResult;
        }

        public async void SaveChanges()
        {
            await _context.SaveChangesAsync();
        }


        public void Delete(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            var result = _entities.Where(predicate);
            if (result == null)
                throw new Exception("No result foud.");
            foreach (var item in result)
            {
                _entities.Remove(item);
            }
        }
    }
}
