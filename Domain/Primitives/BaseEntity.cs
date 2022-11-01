namespace Domain.Primitives;
public abstract class BaseEntity<TKey> : IEquatable<BaseEntity<TKey>>
{
    public TKey Id { get; private init; }

    protected BaseEntity(TKey id)
    {
        Id = id;
    }

#nullable enable
    public static bool operator ==(BaseEntity<TKey>? first, BaseEntity<TKey>? second)
    {
        return first is not null && second is not null && first.Equals(second);
    }
    public static bool operator !=(BaseEntity<TKey>? first, BaseEntity<TKey>? second)
    {
        return !(first == second);
    }
    public bool Equals(BaseEntity<TKey>? other)
    {
        if (other is null)
        {
            return false;
        }

        if (other.GetType() != GetType())
        {
            return false;
        }

        return other.Id.Equals(Id);
    }
    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        if (obj is not BaseEntity<TKey> entity)
        {
            return false;
        }

        return entity.Id.Equals(Id);
    }
    public override int GetHashCode()
    {
        return Id.GetHashCode() * 41;
    }
#nullable disable
}

public abstract class BaseEntity : BaseEntity<Guid>
{
    protected BaseEntity(Guid id) : base(id)
    {
    }
}