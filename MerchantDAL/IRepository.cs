using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.DbEntities;
using System.Linq.Expressions;

namespace MerchantDAL
{
    public interface IRepository<T> where T : DbEntity
    {
        void Add(T newEntity);
        T Get(int id);
        List<T> Get(Expression<Func<T, bool>> predicate = null, int pageNo = -1, int pageSize = 10);
        void Update(T updatedT);
        void Delete(int id);
        void Delete(T tToBeDeleted);
        void Delete(Expression<Func<T, bool>> predicate);

        void SaveChanges();
    }
}
