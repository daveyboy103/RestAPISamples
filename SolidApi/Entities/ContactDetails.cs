using SolidApi.Interfaces;

namespace SolidApi.Entities
{
    public sealed class ContactDetails : IContactDetails
    {
        public ContactType Type { get; init; }
        public string Details { get; init; }
    }
}