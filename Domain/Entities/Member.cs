using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Member : BaseEntity
{
    public Member(Guid id) : base(id)
    {
    }

    public FirstName FirstName { get; set; }
    public LastName LastName { get; set; }
    public Email Email { get; set; }
}
