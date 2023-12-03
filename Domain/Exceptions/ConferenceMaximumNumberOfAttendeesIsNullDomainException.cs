namespace Domain.Exceptions;

public class ConferenceMaximumNumberOfAttendeesIsNullDomainException : DomainException
{
    public ConferenceMaximumNumberOfAttendeesIsNullDomainException(string message) : base(message)
    {
    }
}
