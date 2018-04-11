using System;

namespace ToeffToeff.Interfaces.Entities
{
    using System.Collections.Generic;
    using ToeffToeff.Entities;

    public interface IPerson
    {
        int Id { get; }

        string FirstName { get; set; }

        string LastName { get; set; }

        DateTime Birthdate { get; set; }

        List<IModel> Models { get; set; }
    }
}
