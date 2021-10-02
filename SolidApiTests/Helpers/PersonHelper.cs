using System;
using System.Collections.Generic;
using SolidApi.Entities;
using SolidApi.Interfaces;

namespace SolidApiTests.Helpers
{
    public static class PersonHelper
    {
        public static IPerson GetTestPerson()
        {
            var ret = new Person
            {
                NameDetails = new NameDetails
                {
                    Family = "Harrington",
                    Given = "David",
                    Middle = "George"
                },
                Gender = new GenderDetails
                {
                    Gender = "Male",
                    Notes = string.Empty
                },
                ContactDetails = new List<IContactDetails>
                {
                    new ContactDetails
                    {
                        Details = "07703498745",
                        Type = ContactType.Mobile
                    }
                },
                DateOfBirth = new DateTime(1963, 11, 2),
                Nationality = new List<INationalityDetails>
                {
                    new NationalityDetails { Country = "Ireland" }
                },
                KeyId = 12345
            };

            return ret;
        }
    }
}