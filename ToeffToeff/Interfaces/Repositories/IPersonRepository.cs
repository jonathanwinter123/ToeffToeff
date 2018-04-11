namespace ToeffToeff.Interfaces.Repositories
{
    using System.Collections.Generic;
    using Entities;

    public interface IPersonRepository
    {
        List<IPerson> GetAllAsync();

        IPerson GetSingleAsync(int id);
    }
}