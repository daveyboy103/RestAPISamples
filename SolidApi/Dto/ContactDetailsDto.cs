using SolidApi.Interfaces;

namespace SolidApi.Dto
{
    public sealed class ContactDetailsDto : IContactDetails
    {
        public int? KeyId { get; init; }
        public ContactType Type { get; init; }
        public string Details { get; init; }
    }
}