namespace Domain.Exceptions;
public class ConferenceInvitationsValidBeforeInHoursIsNullDomainException : DomainException
{
    public ConferenceInvitationsValidBeforeInHoursIsNullDomainException(string message) : base(message)
    {
    }
}
