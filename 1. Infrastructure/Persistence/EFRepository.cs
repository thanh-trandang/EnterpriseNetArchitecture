using LogiGear.Domain.Repositories.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiGear.Infrastructure.Persistence
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private IEFUnitOfWork _efUnitOfWork;


        public TEntity Save(TEntity entity)
        {
            if (entity != (TEntity)null)
            {
                this._efUnitOfWork.CreateSet<TEntity>().Add(entity);
            }

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            if (entity != (TEntity)null)
            {
                _efUnitOfWork.SetModified(entity);
            }

            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            if (entity != (TEntity)null)
            {
                _efUnitOfWork.Attach(entity);
                _efUnitOfWork.CreateSet<TEntity>().Remove(entity);
            }

            return entity;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _efUnitOfWork.CreateSet<TEntity>();
        }

        public IEnumerable<TEntity> FindBy(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return _efUnitOfWork.CreateSet<TEntity>().Where(filter);
        }

        public void Dispose()
        {
            if (_efUnitOfWork != null)
                _efUnitOfWork.Dispose();
        }
    }
}
