namespace ToeffToeff.Repositories
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using Interfaces.Entities;
    using Interfaces.Persistence;
    using Interfaces.Repositories;
    using Persistence;

    public class PersonRepository : IPersonRepository
    {
        private readonly IMotorcycleContext motorcycleContext;
        private readonly IPersonFactory personFactory;

        public PersonRepository(IMotorcycleContext motorcycleContext, IPersonFactory personFactory)
        {
            this.motorcycleContext = motorcycleContext;
            this.personFactory = personFactory;
        }

        public async Task<List<IPerson>> GetAllAsync()
        {
            List<IPersistedPerson> persistedPersons = await this.motorcycleContext.PersistedPersons
                                                                .Include(pp => pp.PersistedModels.AsEnumerable())
                                                                .Select(pp => (IPersistedPerson)pp).ToListAsync();
            return persistedPersons.Select(pp => this.personFactory.CreatePersonFromPersistedPerson(pp)).ToList();
        }

        public async Task<IPerson> GetSingleAsync(int id)
        {
            PersistedPersons persistedPerson = await this.motorcycleContext.PersistedPersons.Include(pp => pp.PersistedModels.AsEnumerable()).FirstOrDefaultAsync(pp => pp.Id == id);
            return this.personFactory.CreatePersonFromPersistedPerson(persistedPerson);
        }
    }
}