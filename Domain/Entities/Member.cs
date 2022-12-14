using Domain.Primitives;

namespace Domain.Entities;

public class Member : BaseEntity
{
    public Member(Guid id) : base(id)
    {
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
