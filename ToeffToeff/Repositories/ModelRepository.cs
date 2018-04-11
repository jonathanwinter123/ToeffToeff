namespace ToeffToeff.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Interfaces.Entities;
    using Interfaces.Persistence;
    using Interfaces.Repositories;
    using Persistence;

    public class ModelRepository : IModelRepository
    {
        public async Task<List<IModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IModel> GetSingleAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}