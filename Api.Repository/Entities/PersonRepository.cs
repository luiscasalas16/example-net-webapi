using Api.Contracts;
using Api.Entities;

namespace Api.Repository
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return FindAll()
                .OrderBy(o => o.FullName)
                .ToList();
        }

        public Person GetPersonById(int personId)
        {
            return FindByCondition(o => o.Id.Equals(personId))
                    .FirstOrDefault();
        }

        public void CreatePerson(Person person)
        {
            Create(person);
        }

        public void UpdatePerson(Person person)
        {
            Update(person);
        }

        public void DeletePerson(Person person)
        {
            Delete(person);
        }
    }
}
