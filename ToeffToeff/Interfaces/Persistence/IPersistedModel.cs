namespace ToeffToeff.Interfaces.Persistence
{
    using System.Collections.Generic;
    using ToeffToeff.Persistence;

    public interface IPersistedModel
    {
        int Id { get; set; }
        string Name { get; set; }
        string ModelSpecification { get; set; }
        decimal Price { get; set; }
        string Picture { get; set; }

        PersistedBrands PersistedBrands { get; set; }

        ICollection<PersistedPersons> PersistedPersons { get; set; }
    }
}