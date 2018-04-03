using System;

namespace ToeffToeff.Interfaces.Entities
{
    public interface IBrand
    {
        int Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        DateTime FoundingDate { get; set; }

        string StyleDescription { get; set; }
    }
}
