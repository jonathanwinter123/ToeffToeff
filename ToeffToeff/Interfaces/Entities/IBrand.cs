using System;

namespace ToeffToeff.Interfaces.Entities
{
    using System.Collections.Generic;

    public interface IBrand
    {
        int Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        DateTime FoundingDate { get; set; }

        string StyleDescription { get; set; }

        string Picture { get; set; }

        IEnumerable<IModel> Models { get; set; }
    }
}
