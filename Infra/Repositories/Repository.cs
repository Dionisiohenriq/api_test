using api_test.Domain.Entities;
using api_test.Domain.Interfaces.Repositories;
using api_test.Infra.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace api_test.Infra.CrossCutting.Identity.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected readonly ApplicationDbContext Db;

        protected readonly IHttpContextAccessor _accessor;

        protected readonly DbSet<TEntity> DbSet;
        public Repository(ApplicationDbContext context, IHttpContextAccessor accessor)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
            _accessor = accessor;
        }

        /// <summary>
        /// Function Add run sql command "INSERT INTO TABLE"
        /// </summary>
        /// <param name="obj">Entity from this table</param>
        /// <param name="bCommit">True = Save Changes, False = Does not save on database </param>
        /// <returns></returns>
        public bool Add(TEntity obj, bool bCommit = true)
        {
            DbSet.Add(obj);
            return !bCommit || SaveChanges() > 0;
        }

        public bool Any(Func<TEntity, bool> exp) => GetAll().Any(exp);

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool ForceDelete(Guid id, bool bCommit = true)
        {
            DbSet.Remove(DbSet.Find(id));
            return !bCommit || SaveChanges() > 0;
        }

        public IQueryable<TEntity> GetAll() => GetAll().AsQueryable().AsNoTracking();

        public IQueryable<TEntity> GetAllBy(Func<TEntity, bool> exp) => GetAll().Where(exp).AsQueryable().AsNoTracking();

        public TEntity GetBy(Func<TEntity, bool> exp) => DbSet.AsNoTracking().FirstOrDefault(exp);
        public TEntity GetById(Guid id) => DbSet.Find(id);
        public bool Save(TEntity obj, bool bCommit = true)
        {
            var entity = obj as Entity;

            if(Guid.Empty == entity.Id)            
                Add(obj, false);
            else
                Update(obj, false);

            return !bCommit || SaveChanges() > 0;
            
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public bool SoftDelete(TEntity obj)
        {
            var entity = obj as Entity;
            if (entity == null) return false;

            return ForceDelete(entity.Id, true);
        }

        public bool Update(TEntity obj, bool bCommit = true)
        {
            var entity = obj as Entity;
            if (entity == null) return false;
            entity.Update();
            DbSet.Update(obj);
            return !bCommit || SaveChanges() > 0;
        }

        /// <summary>
        /// Function Upsert run sql command "MERGE INTO TABLE"
        /// </summary>
        /// <param name="obj">Entity from this table</param>
        /// <param name="exp">Database Clause in Lambda expression</param>
        /// <param name="bCommit">True = Save Changes, False = Does not save on database</param>
        /// <returns></returns>
        public bool Upsert(TEntity obj, Func<TEntity, bool> exp, bool bCommit = true)
        {
            if (None(exp))
                return Add(obj, bCommit);
            else
                return Update(obj, bCommit);
        }

        public bool None(Func<TEntity, bool> exp) => !GetAll().Any(exp);
    }
}
