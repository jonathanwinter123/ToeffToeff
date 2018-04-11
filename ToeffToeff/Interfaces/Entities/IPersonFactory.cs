namespace ToeffToeff.Interfaces.Entities
{
    using ToeffToeff.Persistence;

    public interface IPersonFactory
    {
        IPerson CreatePersonFromPersistedPerson(IPersistedPerson persistedPerson);
    }
}