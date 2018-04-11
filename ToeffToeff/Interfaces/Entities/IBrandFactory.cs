namespace ToeffToeff.Interfaces.Entities
{
    using ToeffToeff.Persistence;

    public interface IBrandFactory
    {
        IBrand CreateBrandFromPersistedBrand(IPersistedBrand persistedBrand);
    }
}