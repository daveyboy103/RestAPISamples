using SolidApi.Interfaces;

namespace SolidApi.Dto
{
    public sealed class NameDetailsDto : INameDetails
    {
        public int? KeyId { get; init; }
        public string Title { get; init; }
        public string Given { get; init; }
        public string Middle { get; init; }
        public string Family { get; init; }
        public string Prefix { get; init; }
        public string Suffix { get; init; }
        public string Other { get; init; }
    }
}