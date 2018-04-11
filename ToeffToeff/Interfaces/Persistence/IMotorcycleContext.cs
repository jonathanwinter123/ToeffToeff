namespace ToeffToeff.Interfaces.Persistence
{
    using System.Data.Entity;
    using System.Threading.Tasks;
    using ToeffToeff.Persistence;

    public interface IMotorcycleContext
    {
        DbSet<PersistedBrands> PersistedBrands { get; set; }

        DbSet<PersistedModels> PersistedModels { get; set; }

        DbSet<PersistedPersons> PersistedPersons { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}