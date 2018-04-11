namespace ToeffToeff.Interfaces.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;

    interface IModelRepository
    {
        Task<List<IModel>> GetAllAsync();

        Task<IModel> GetSingleAsync(int id);
    }
}
