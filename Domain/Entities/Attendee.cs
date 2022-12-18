using Domain.Primitives;

namespace Domain.Entities;

public class Attendee : BaseEntity
{

    public Attendee(Guid id) : base(id)
    {
        CreatedOnUtc = DateTime.UtcNow;
    }

    public Guid ConferenceId { get; private set; }

    public Guid MemberId { get; private set; }

    public DateTime CreatedOnUtc { get; private set; }
}
