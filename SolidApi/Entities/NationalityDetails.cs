using System;
using SolidApi.Interfaces;

namespace SolidApi.Entities
{
    public sealed class  NationalityDetails : INationalityDetails
    {
        public string Country { get; init; }
        public DateTime? DateFrom { get; init; }
        public DateTime? DateTo { get; init; }
    }
}