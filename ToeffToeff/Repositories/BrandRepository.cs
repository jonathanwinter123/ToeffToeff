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

    public class BrandRepository : IBrandRepository
    {
        private readonly IMotorcycleContext motorcycleContext;
        private readonly IBrandFactory brandFactory;

        public BrandRepository(IMotorcycleContext motorcycleContext, IBrandFactory brandFactory)
        {
            this.motorcycleContext = motorcycleContext;
            this.brandFactory = brandFactory;
        }

        public async Task<List<IBrand>> GetAllAsync()
        {
            List<IPersistedBrand> brandList = await this.motorcycleContext.PersistedBrands
                                                        .Include(pb => pb.PersistedModels.AsEnumerable())
                                                        .Select(pb => (IPersistedBrand) pb)
                                                        .ToListAsync();

            return brandList.Select(bl => this.brandFactory.CreateBrandFromPersistedBrand(bl)).ToList();
        }

        public async Task<IBrand> GetSingleAsync(int id)
        {
            IPersistedBrand persistedBrand = await this.motorcycleContext.PersistedBrands
                                                       .Include(pb => pb.PersistedModels.AsEnumerable())
                                                       .FirstOrDefaultAsync(pb => pb.Id == id);
            return this.brandFactory.CreateBrandFromPersistedBrand(persistedBrand);
        }
    }
}