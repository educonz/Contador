using Base.Core.Data;
using System.Linq;

namespace Base.Core.EntityFramework
{
    internal class Repository : IRepository
    {
        private readonly IDataContext _dataContext;

        public Repository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public TEntity Find<TEntity, TPropertyType>(TPropertyType id)
            where TEntity : class
            where TPropertyType : struct
        {
            return _dataContext.Find<TEntity, TPropertyType>(id);
        }

        public IQueryable<TEntity> Query<TEntity>() where TEntity : class
        {
            return _dataContext.Query<TEntity>();
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : class
        {
            _dataContext.Remove(entity);
        }

        public TEntity Save<TEntity>(TEntity entity) where TEntity : class
        {
            return _dataContext.Save(entity);
        }
    }
}
