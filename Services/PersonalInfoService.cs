using PersonalInfoManagement.Models.dbContextClass;
using PersonalInfoManagement.Models.DbModels;
using PersonalInfoManagement.Services.Interfaces;

namespace PersonalInfoManagement.Services
{
    public class PersonalInfoService : IPersonalInfoService
    {
        private readonly ApplicationDbContext _context;

        public PersonalInfoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<PersonalInfo> GetAll()
        {
            return _context.PersonalInfos.ToList();
        }

        public PersonalInfo GetById(int id)
        {
            return _context.PersonalInfos.Find(id);
        }

        public void Add(PersonalInfo model)
        {
            _context.PersonalInfos.Add(model);
            _context.SaveChanges();
        }

        public void Update(PersonalInfo model)
        {
            _context.PersonalInfos.Update(model);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.PersonalInfos.Find(id);
            _context.PersonalInfos.Remove(data);
            _context.SaveChanges();
        }
    }
}
