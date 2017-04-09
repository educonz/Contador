using Base.Core.Data;
using System.Data.Entity;
using System;
using System.Linq;
using System.Data.Entity.Migrations;

namespace Base.Core.EntityFramework
{
    public abstract class ContextoBase : DbContext, IDataContext
    {
        protected ContextoBase(string nameConnection)
            : base(nameConnection)
        {
        }

        public TEntity Save<TEntity>(TEntity entity) where TEntity : class
        {
            Set<TEntity>().AddOrUpdate(entity);
            return entity;
        }

        public TEntity Find<TEntity, TPropertyType>(TPropertyType id)
            where TEntity : class
            where TPropertyType : struct
        {
            return Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> Query<TEntity>() where TEntity : class
        {
            return Set<TEntity>().AsQueryable();
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : class
        {
            Set<TEntity>().Remove(entity);
        }
    }
}
