namespace ToeffToeff.Entities
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Entities;

    public class Brand : IBrand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime FoundingDate { get; set; }

        public string StyleDescription { get; set; }

        public string Picture { get; set; }

        public IEnumerable<IModel> Models { get; set; }
    }
}