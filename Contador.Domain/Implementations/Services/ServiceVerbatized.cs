using Base.Core.Adaptes;
using Base.Core.Data;
using Base.Core.Service;

namespace Contador.Domain.Implementations.Services
{
    public abstract class ServiceVerbatized<TEntity, TEntityDto> : IServiceVerbatized<TEntity, TEntityDto>
        where TEntity : class, new()
        where TEntityDto : class, new()
    {
        protected readonly IModelAdapter<TEntity, TEntityDto> Adapter;
        protected readonly IRepository Repository;

        public ServiceVerbatized(IRepository repository, IModelAdapter<TEntity, TEntityDto> adapter)
        {
            Repository = repository;
            Adapter = adapter;
        }

        public void Delete<TProperty>(TProperty id) where TProperty : struct
        {
            Repository.Remove(Repository.Find<TEntity, TProperty>(id));
        }

        public TEntityDto Get<TProperty>(TProperty id) where TProperty : struct
        {
            return Adapter.ToDto(Repository.Find<TEntity, TProperty>(id));
        }

        public virtual TEntityDto Post(TEntityDto entityDto)
        {
            return Adapter.ToDto(Repository.Save(Adapter.ToEntity(entityDto)));
        }

        public virtual TEntityDto Put(TEntityDto entityDto)
        {
            return Adapter.ToDto(Repository.Save(Adapter.ToEntity(entityDto)));
        }
    }
}
