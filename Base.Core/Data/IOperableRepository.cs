namespace Base.Core.Data
{
    public interface IOperableRepository
    {
        TEntity Save<TEntity>(TEntity entity) where TEntity : class;
        void Remove<TEntity>(TEntity entity) where TEntity : class;
    }
}
