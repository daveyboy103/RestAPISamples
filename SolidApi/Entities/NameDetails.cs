using SolidApi.Interfaces;

namespace SolidApi.Entities
{
    public sealed class NameDetails : INameDetails
    {
        public string Title { get; init; }
        public string Given { get; init; }
        public string Middle { get; init; }
        public string Family { get; init; }
        public string Prefix { get; init; }
        public string Suffix { get; init; }
        public string Other { get; init; }
    }
}