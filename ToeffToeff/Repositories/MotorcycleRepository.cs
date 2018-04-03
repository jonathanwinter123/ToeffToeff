using System.Data.Entity.Core.Mapping;
using System.Linq;
using ToeffToeff.Persistence;

namespace ToeffToeff.Repositories
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Entities;
    using Interfaces.Repositories;

    public class MotorcycleRepository : IMotorcycleRepository
    {
        public List<IMotorcycle> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IMotorcycle GetSingleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Brand> GetBrands()
        {
            var test = new List<Brand>
            {
                new Brand
                { 
                    Id = 1,
                    Description = "Triumph Motorcycles Ltd. ist der Name eines Motorradherstellers in Hinckley, Großbritannien. Die Triumph Motorcycles Ltd. stellen Motorräder her, vorwiegend unter dem Markennamen Triumph.",
                    FoundingDate = new DateTime(1884, 01, 01).Date,
                    Name = "Triumph",
                    StyleDescription = "Vintage",
                    Picture = "http://www.triumphconnection.com/TriumphLogos/New-Triumph-Triangle-Logo.png"          
                },
                new Brand
                {
                    Id = 2,
                    Description = "marke2",
                    FoundingDate = DateTime.Today,
                    Name = "marke2",
                    StyleDescription = string.Empty               
                }
            };
            return test;
        }
    }
}