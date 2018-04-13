namespace ToeffToeff.Interfaces.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;

    public interface IPersonRepository
    {
        Task<List<IPerson>> GetAllAsync();

        Task<IPerson> GetSingleAsync(int id);
    }
}