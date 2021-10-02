using SolidApi.Interfaces;

namespace SolidApi.Entities
{
    public sealed class GenderDetails : IGenderDetails
    {
        public string Gender { get; init; }
        public string Notes { get; init; }
    }
}