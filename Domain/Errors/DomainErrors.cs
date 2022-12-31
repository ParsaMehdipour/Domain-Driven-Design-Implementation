using Domain.Shared;

namespace Domain.Errors;
public static class DomainErrors
{
    /*In C#, a user is allowed to define a class within another class.
    Such types of classes are known as nested class.
    This feature enables the user to logically group classes that are only used in one place,
    thus this increases the use of encapsulation,
    and create more readable and maintainable code*/
    public static class Email
    {
        public static readonly Error Empty = new(
            "Email.Empty",
            "Email is empty.");

        public static readonly Error InvalidFormat = new(
            "Email.InvalidFormat",
            "Email format is invalid");

    }

    public static class FirstName
    {
        public static readonly Error Empty = new(
            "FirstName.Empty",
            "First name is empty");

        public static readonly Error TooLong = new(
            "FirstName.TooLong",
            "First name is too long");
    }

    public static class LastName
    {
        public static readonly Error Empty = new(
            "LastName.Empty",
            "Last name is empty");

        public static readonly Error TooLong = new(
            "LastName.TooLong",
            "Last name is too long");
    }
}
