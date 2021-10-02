using System.Linq;
using NUnit.Framework;
using SolidApi.Dto;
using SolidApi.Interfaces;
using SolidApiTests.Helpers;

namespace SolidApiTests
{
    public class PersonDtoConversionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldConvertPersonToPersonDto()
        {
            IPerson person = PersonHelper.GetTestPerson();

            var personDto = person.ToPersonDto();
            var contactDto = person.ToContactDetailsDto();
            var genderDto = person.ToGenderDetailsDto();
            var nationalityDto = person.ToNationalityDetailsDto();
            
            Assert.IsNotNull(personDto);
            Assert.IsNotNull(contactDto);
            Assert.IsNotNull(genderDto);
            Assert.AreEqual(1, contactDto.Count());
            Assert.AreEqual(1, nationalityDto.Count());
        }
    }
}