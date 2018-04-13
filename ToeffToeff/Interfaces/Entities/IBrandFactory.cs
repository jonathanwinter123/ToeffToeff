namespace ToeffToeff.Interfaces.Entities
{
    using Persistence;
    using ToeffToeff.Persistence;

    public interface IBrandFactory
    {
        IBrand CreateBrandFromPersistedBrand(IPersistedBrand persistedBrand);
    }
}