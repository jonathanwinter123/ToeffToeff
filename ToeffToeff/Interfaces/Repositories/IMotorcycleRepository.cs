namespace ToeffToeff.Interfaces.Repositories
{
    using System.Collections.Generic;
    using Entities;

    interface IMotorcycleRepository
    {
        List<IMotorcycle> GetAllAsync();

        IMotorcycle GetSingleAsync(int id);
    }
}
