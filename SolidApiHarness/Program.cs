using System;
using Autofac;
using SolidApi;
using SolidApi.Dto;
using SolidApi.Interfaces;
using SolidApiTests.Helpers;

namespace SolidApiHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var scope = Initialisation.Container.BeginLifetimeScope())
            {
                IPersonUpdateManagement personManagementService = scope.Resolve<IPersonUpdateManagement>();

                var person = PersonHelper.GetTestPerson();
                
                personManagementService.UpdateContactDetails(person.ToContactDetailsDto());
                personManagementService.UpdateGenderDetails(person.ToGenderDetailsDto());
                personManagementService.UpdateNameDetails(person.ToNameDetailsDto());
                personManagementService.UpdateNationalityDetails(person.ToNationalityDetailsDto());

                Console.ReadKey();
            }
        }
    }
}