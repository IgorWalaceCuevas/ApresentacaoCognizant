using Cognizant.Domain.Entities.Partial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Domain.Interface.Service
{
    public interface ISimulationService : IServiceBase<Simulation>
    {
        Task<decimal> GetDolarFromUOLAsync();
    }
}
