using SolidApi.Interfaces;

namespace SolidApi.Dto
{
    public sealed class GenderDetailDto : IGenderDetails
    {
        public int? KeyId { get; init; }
        public string Gender { get; init; }
        public string Notes { get; init; }
    }
}