using Domain.Enums;
using Domain.Primitives;

namespace Domain.Entities;

public class Conference : AggregateRoot
{
    private readonly List<Invitation> _invitations = new();
    private readonly List<Attendee> _attendees = new();

    public Conference(
        Guid id,
        Member creator,
        ConferenceType type,
        DateTime scheduledAtUtc,
        string name,
        string location)
        : base(id)
    {
        Creator = creator;
        Type = type;
        ScheduledAtUtc = scheduledAtUtc;
        Name = name;
        Location = location;
    }

    public Member Creator { get; private set; }

    public ConferenceType Type { get; private set; }

    public string Name { get; private set; }

    public DateTime ScheduledAtUtc { get; private set; }

    public string Location { get; private set; }

    public int? MaximumNumberOfAttendees { get; private set; }

    public DateTime? InvitationsExpireAtUtc { get; private set; }

    public int NumberOfAttendees { get; private set; }

    public IReadOnlyCollection<Attendee> Attendees => _attendees;

    public IReadOnlyCollection<Invitation> Invitations => _invitations;
}
