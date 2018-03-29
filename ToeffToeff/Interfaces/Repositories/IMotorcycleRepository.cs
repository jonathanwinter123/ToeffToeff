using System.Collections.Generic;
using ToeffToeff.Interfaces.Entities;

namespace ToeffToeff.Interfaces.Repositories
{
    interface IMotorcycleRepository
    {
        List<IMotorcycle> GetAllAsync();

        IMotorcycle GetSingleAsync(int id);
    }
}
