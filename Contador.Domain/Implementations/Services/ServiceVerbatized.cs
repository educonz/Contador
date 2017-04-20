using Base.Core.Adaptes;
using Base.Core.Data;
using Base.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador.Domain.Implementations.Services
{
    public abstract class ServiceVerbatized<TEntity, TEntityDto> : IServiceVerbatized<TEntity, TEntityDto>
        where TEntity : class, new()
        where TEntityDto : class, new()
    {
        private readonly IModelAdapter<TEntity, TEntityDto> _adapter;
        private readonly IRepository _repository;

        public ServiceVerbatized(IRepository repository, IModelAdapter<TEntity, TEntityDto> adapter)
        {
            _repository = repository;
            _adapter = adapter;
        }

        public void Delete<TProperty>(TProperty id) where TProperty : struct
        {
            _repository.Remove(_repository.Find<TEntity, TProperty>(id));
        }

        public TEntityDto Get<TProperty>(TProperty id) where TProperty : struct
        {
            return _adapter.ToDto(_repository.Find<TEntity, TProperty>(id));
        }

        public virtual TEntityDto Post(TEntityDto entityDto)
        {
            return _adapter.ToDto(_repository.Save(_adapter.ToEntity(entityDto)));
        }

        public virtual TEntityDto Put(TEntityDto entityDto)
        {
            return _adapter.ToDto(_repository.Save(_adapter.ToEntity(entityDto)));
        }
    }
}
