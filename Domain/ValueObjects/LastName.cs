using Domain.Primitives;

namespace Domain.ValueObjects;

public class LastName : ValueObject
{
    private LastName(string value)
    {
        Value = value;
    }

    public string Value { get; }


    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
