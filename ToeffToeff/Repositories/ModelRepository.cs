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

        private readonly IMotorcycleContext motorcycleContext;
        private readonly IModelFactory modelFactory;

        public ModelRepository(IMotorcycleContext motorcycleContext, IModelFactory modelFactory)
        {
            this.motorcycleContext = motorcycleContext;
            this.modelFactory = modelFactory;
        }

        public async Task<List<IModel>> GetAllAsync()
        {
            List<IPersistedModel> persistedModels = await this.motorcycleContext.PersistedModels
                                                                .Include(pm => pm.PersistedPersons.AsEnumerable())
                                                                .Include(pm => pm.PersistedBrands)
                                                                .Select(pm => (IPersistedModel) pm)
                                                                .ToListAsync();
            return persistedModels.Select(pm => this.modelFactory.CreateModelFromPersistedModel(pm)).ToList();
        }

        public async Task<IModel> GetSingleAsync(int id)
        {
            IPersistedModel persistedModel = await this.motorcycleContext.PersistedModels
                                                       .Include(pm => pm.PersistedPersons.AsEnumerable())
                                                       .Include(pm => pm.PersistedBrands)
                                                       .FirstOrDefaultAsync(pm => pm.Id == id);
            return this.modelFactory.CreateModelFromPersistedModel(persistedModel);
        }
    }
}