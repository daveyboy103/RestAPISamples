namespace SolidApi.Interfaces
{
    public interface IContactDetails
    {
        ContactType Type { get; init; }
        string Details { get; init; }
    }
}