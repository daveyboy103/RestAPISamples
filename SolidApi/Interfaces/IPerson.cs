using System;
using System.Collections;
using System.Collections.Generic;

namespace SolidApi.Interfaces
{
    public interface IPerson
    {
        int? KeyId { get; init; }
        INameDetails NameDetails { get; init; }
        IGenderDetails Gender { get; init; }
        DateTime DateOfBirth { get; init; }
        IEnumerable<INationalityDetails> Nationality { get; init; }
        IEnumerable<IContactDetails> ContactDetails { get; init; }
    }
}