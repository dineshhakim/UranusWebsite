namespace Uranus.Domain.Abstract
{
    public class Entity<T> : BaseEntity, IEntity<T>
    {
        public virtual T Id { get; set; }
    }


    public abstract class BaseEntity
    {

    }

}