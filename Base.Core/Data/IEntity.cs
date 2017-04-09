namespace Base.Core.Data
{
    public interface IEntity<TKeyType> where TKeyType : struct
    {
        TKeyType Id { get; set; }
    }
}
