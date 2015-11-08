namespace Uranus.Domain.Abstract
{
    public interface IEntity<T>
    {

        T Id { get; set; }

    }
}