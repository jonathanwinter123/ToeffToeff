namespace ToeffToeff.Interfaces.Entities
{
    interface IModelPerson
    {
        int Id { get; }

        int PersonId { get; set; }

        int ModelId { get; set; }
    }
}
