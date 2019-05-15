using Cognizant.Domain.Entities.Partial;
using Cognizant.Domain.Interface.Repository;
using Cognizant.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Domain.Service
{
    public class SimulationService : ServiceBase<Simulation>, ISimulationService
    {
        private readonly ISimulationRepository _simulationRepository;
        public SimulationService(ISimulationRepository simulationRepository) : base(simulationRepository)
        {
            _simulationRepository = simulationRepository;
        }       
        Task<decimal> ISimulationService.GetDolarFromUOLAsync()
        {            
            return _simulationRepository.GetDolarFromUOLAsync();
        }
    }
}
