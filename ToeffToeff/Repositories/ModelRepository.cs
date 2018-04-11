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
                                                                .Include(pm => pm.PersistedPersons)
                                                                .Include(pm => pm.PersistedBrands)
                                                                .Select(pm => (IPersistedModel) pm)
                                                                .ToListAsync();
            return persistedModels.Select(pm => this.modelFactory.CreateModelWithPersistedModel(pm)).ToList();
        }

        public async Task<IModel> GetSingleAsync(int id)
        {
            IPersistedModel persistedModel = await this.motorcycleContext.PersistedModels
                                                       .Include(pm => pm.PersistedPersons)
                                                       .Include(pm => pm.PersistedBrands)
                                                       .FirstOrDefaultAsync(pm => pm.Id == id);
            return this.modelFactory.CreateModelWithPersistedModel(persistedModel);
        }
        /*
        public IEnumerable<Brand> GetBrands()
        {
            var test = new List<Brand>
            {
                new Brand
                { 
                    Id = 1,
                    Description = "Triumph Motorcycles Ltd. ist der Name eines Motorradherstellers in Hinckley, Großbritannien. Die Triumph Motorcycles Ltd. stellen Motorräder her, vorwiegend unter dem Markennamen Triumph.",
                    FoundingDate = new DateTime(1884, 01, 01).Date,
                    Name = "Triumph",
                    StyleDescription = "Vintage",
                    Picture = "http://www.triumphconnection.com/TriumphLogos/New-Triumph-Triangle-Logo.png"          
                },
                new Brand
                {
                    Id = 2,
                    Description = "Die Ducati Motor Holding S.p.A. ist ein italienischer Motorradhersteller mit Sitz in Bologna (Stadtteil Borgo Panigale) und Unternehmenstochter der Audi AG und gehört damit zum Volkswagen-Konzern.",
                    FoundingDate = new DateTime(1926, 01, 01).Date,
                    Name = "Ducati",
                    StyleDescription = "Racing",
                    Picture = "https://seeklogo.com/images/D/ducati-logo-4A395CFB95-seeklogo.com.png"
                }
            };
            return test;
        }*/
    }
}