namespace ToeffToeff.Interfaces.Persistence
{
    using System.Collections.Generic;
    using ToeffToeff.Persistence;

    public interface IPersistedPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        System.DateTime Birthdate { get; set; }
        ICollection<PersistedModels> PersistedModels { get; set; }
    }
}