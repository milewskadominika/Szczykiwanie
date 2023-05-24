using Szczykiwanie.Data;
using Szczykiwanie.Interfaces;
using Szczykiwanie.Models;

namespace Szczykiwanie.Services
{
    public class PersonService: IPersonService
    {
        private readonly PeopleContext _context;
     
        public PersonService(PeopleContext context)
        {
            _context = context;
        }
        public IQueryable<Person> GetActivePeople()
        {
            return
            _context.Person.Where(p => p.IsActive);
        }


    }
}
