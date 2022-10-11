using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_test.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        bool Add(TEntity obj, bool bCommit = true);
        bool Save(TEntity obj, bool bCommit = true);
        bool Upsert(TEntity obj, Func<TEntity, bool> exp, bool bCommit = true);
        bool Update(TEntity obj, bool bCommit = true);
        bool ForceDelete(Guid id, bool bCommit = true);
        bool SoftDelete(TEntity obj);
        TEntity GetById(Guid id);
        TEntity GetBy(Func<TEntity, bool> exp);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllBy(Func<TEntity, bool> exp);
        bool Any(Func<TEntity, bool> exp);
        public bool None(Func<TEntity, bool> exp);
        int SaveChanges();

    }
}
