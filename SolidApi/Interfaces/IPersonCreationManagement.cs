using SolidApi.Dto;

namespace SolidApi.Interfaces
{
    public interface IPersonCreationManagement
    {
        PersonDto Create(PersonDto person);
    }
}