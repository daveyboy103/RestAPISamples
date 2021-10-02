using System;
using System.Collections.Generic;

namespace SolidApi.Dto
{
    public sealed class PersonDto 
    {
        public int? KeyId { get; init; }
        public NameDetailsDto NameDetails { get; init; }
        public GenderDetailDto Gender { get; init; }
        public DateTime DateOfBirth { get; init; }
        public IEnumerable<NationalityDetailsDto> Nationality { get; init; } = new List<NationalityDetailsDto>();
        public IEnumerable<ContactDetailsDto> ContactDetails { get; init; } = new List<ContactDetailsDto>();

        public static PersonDto Empty()
        {
            return new PersonDto();
        }
    }
}