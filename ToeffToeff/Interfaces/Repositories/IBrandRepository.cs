namespace ToeffToeff.Interfaces.Repositories
{
    using System.Collections.Generic;
    using Entities;

    public interface IBrandRepository
    {
        List<IBrand> GetAllAsync();

        IBrand GetSingleAsync(int id);
    }
}