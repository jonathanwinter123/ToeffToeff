namespace ToeffToeff.Entities
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Entities;

    public class Person : IPerson
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public List<IModel> Models { get; set; }
    }
}