namespace ToeffToeff.Interfaces.Entities
{
    using Persistence;

    public interface IModelFactory
    {
        IModel CreateModelWithPersistedModel(IPersistedModel persistedModels);
    }
}