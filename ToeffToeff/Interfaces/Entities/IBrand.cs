using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeffToeff.Interfaces.Entities
{
    interface IBrand
    {
        int Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        DateTime FoundingDate { get; set; }

        string StyleDescription { get; set; }
    }
}
