using Domain.Primitives;

namespace Domain.ValueObjects;

public class Email : ValueObject
{
    private Email(string value)
    {
        Value = value;
    }

    public string Value { get; }


    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
