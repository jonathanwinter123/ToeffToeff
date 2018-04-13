namespace ToeffToeff.Interfaces.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;

    public interface IBrandRepository
    {
        Task<List<IBrand>> GetAllAsync();

        Task<IBrand> GetSingleAsync(int id);
    }
}