using System;
using SolidApi.Interfaces;

namespace SolidApi.Dto
{
    public sealed class NationalityDetailsDto : INationalityDetails
    {
        public int? KeyId { get; init; }
        public string Country { get; init; }
        public DateTime? DateFrom { get; init; }
        public DateTime? DateTo { get; init; }
    }
}