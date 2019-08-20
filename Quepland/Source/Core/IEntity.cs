namespace Quepland
{
    public interface IEntity<T, IdT>
    {
        IdT Id { get; }
    }
}
