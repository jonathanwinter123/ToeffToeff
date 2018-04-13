namespace ToeffToeff.Interfaces.Entities
{
    using Persistence;

    public interface IModelFactory
    {
        IModel CreateModelFromPersistedModel(IPersistedModel persistedModels);
    }
}