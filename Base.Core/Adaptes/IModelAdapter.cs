using Base.Core.Data;

namespace Base.Core.Adaptes
{
    public interface IModelAdapter<TEntity, TDto>
        where TEntity : class, new()
        where TDto : class
    {
        TDto ToDto(TEntity entity);
        TEntity ToEntity(TDto dto);
    }
}
