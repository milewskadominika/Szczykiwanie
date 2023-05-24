using Szczykiwanie.Models;

namespace Szczykiwanie.Interfaces
{
    public interface IPersonService
    {
        public IQueryable<Person> GetActivePeople();
    }
}
