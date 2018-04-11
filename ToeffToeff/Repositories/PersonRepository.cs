namespace ToeffToeff.Repositories
{
    using System.Collections.Generic;
    using Interfaces.Entities;
    using Interfaces.Repositories;
    public class PersonRepository : IPersonRepository
    {
        public List<IPerson> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public IPerson GetSingleAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}