using System;
using System.Collections.Generic;
using SolidApi.Interfaces;

namespace SolidApi.Entities
{
    public sealed class Person : IPerson
    {
        public int? KeyId { get; init; }
        public INameDetails NameDetails { get; init; }
        public IGenderDetails Gender { get; init; }
        public DateTime DateOfBirth { get; init; }
        public IEnumerable<INationalityDetails> Nationality { get; init; } = new List<INationalityDetails>();
        public IEnumerable<IContactDetails> ContactDetails { get; init; } = new List<IContactDetails>();
    }
}