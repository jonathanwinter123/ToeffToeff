namespace ToeffToeff.Entities
{
    using System.Collections.Generic;
    using Interfaces.Entities;

    public class Model : IModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ModelSpecification { get; set; }

        public decimal Price { get; set; }

        public string Picture { get; set; }

        public Brand Brand { get; set; }

        public List<Person> People { get; set; }
    }
}