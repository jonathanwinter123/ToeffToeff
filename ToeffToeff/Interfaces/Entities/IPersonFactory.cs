namespace ToeffToeff.Interfaces.Entities
{
    using Persistence;
    using ToeffToeff.Persistence;

    public interface IPersonFactory
    {
        IPerson CreatePersonFromPersistedPerson(IPersistedPerson persistedPerson);
    }
}