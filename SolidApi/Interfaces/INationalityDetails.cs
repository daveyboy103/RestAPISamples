using System;

namespace SolidApi.Interfaces
{
    public interface INationalityDetails
    {
        string Country { get; init; }
        DateTime? DateFrom { get; init; }
        DateTime? DateTo { get; init; }
    }
}