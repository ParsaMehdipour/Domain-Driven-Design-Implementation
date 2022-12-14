using Domain.Primitives;

namespace Domain.Entities;

public class Conference : AggregateRoot
{
    public Conference(Guid id) : base(id)
    {
    }

#nullable enable
    public Member Creator { get; private set; }

    public string Name { get; private set; }

    public DateTime ScheduledAtUtc { get; private set; }

    public string? Location { get; private set; }

    public int? MaximumNumberOfAttendees { get; private set; }

    public DateTime? InvitationsExpireAtUtc { get; private set; }

    public int NumberOfAttendees { get; private set; }
#nullable disable
}
