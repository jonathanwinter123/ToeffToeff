using System;

namespace ToeffToeff.Interfaces.Entities
{
    interface IPerson
    {
        int Id { get; }

        string FirstName { get; set; }

        string LastName { get; set; }

        DateTime Birthdate { get; set; }

    }
}
