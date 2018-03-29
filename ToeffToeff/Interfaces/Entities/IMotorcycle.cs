namespace ToeffToeff.Interfaces.Entities
{
    interface IMotorcycle
    {
        int Id { get; }

        string Name { get; set; }

        string ModelSpecification { get; set; }

        decimal Price { get; set; }

        string Picture { get; set; }

        int BrandId { get; set; }
    }
}
