using System.Linq;

namespace Base.Core.Data
{
    public interface IReadeableRepository
    {
        IQueryable<TEntity> Query<TEntity>() where TEntity : class;
        TEntity Find<TEntity, TPropertyType>(TPropertyType id)
            where TEntity : class
            where TPropertyType : struct;
    }
}
