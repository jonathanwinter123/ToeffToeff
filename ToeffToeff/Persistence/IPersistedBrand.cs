namespace ToeffToeff.Persistence
{
    using System.Collections.Generic;

    public interface IPersistedBrand
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        System.DateTime FoundingDate { get; set; }
        string StyleDescription { get; set; }
        string Picture { get; set; }
        ICollection<PersistedModels> PersistedModels { get; set; }
    }
}