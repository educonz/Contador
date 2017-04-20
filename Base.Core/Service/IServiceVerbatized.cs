namespace Base.Core.Service
{
    public interface IServiceVerbatized<TEntity, TEntityDto>
        where TEntity : class, new()
        where TEntityDto : class, new()
    {
        TEntityDto Post(TEntityDto entityDto);
        TEntityDto Put(TEntityDto entityDto);
        TEntityDto Get<TProperty>(TProperty id) where TProperty : struct;
        void Delete<TProperty>(TProperty id) where TProperty : struct;
    }
}
