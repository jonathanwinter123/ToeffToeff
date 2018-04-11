namespace ToeffToeff.Interfaces.Entities
{
    using System.Collections.Generic;
    using ToeffToeff.Entities;

    public interface IModel
    {
        int Id { get; set; }

        string Name { get; set; }

        string ModelSpecification { get; set; }

        decimal Price { get; set; }

        string Picture { get; set; }

        Brand Brand { get; set; }

        List<Person> People { get; set; }
    }
}