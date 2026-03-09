using PersonalInfoManagement.Models.DbModels;

namespace PersonalInfoManagement.Services.Interfaces
{
    public interface IPersonalInfoService
    {
        List<PersonalInfo> GetAll();
        PersonalInfo GetById(int id);
        void Add(PersonalInfo model);
        void Update(PersonalInfo model);
        void Delete(int id);
    }
}
