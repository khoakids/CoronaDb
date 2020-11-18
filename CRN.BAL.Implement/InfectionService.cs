using CRN.BAL.Interface;
using CRN.DAL.Interface;
using CRN.Domain.Request.Infection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.BAL.Implement
{
    public class InfectionService : IInfectionService
    {
        private readonly IInfectionRepository infectionRepository;

        public InfectionService(IInfectionRepository infectionRepository)
        {
            this.infectionRepository = infectionRepository;
        }

        public async Task<IEnumerable<InfectionView>> Gets()
        {
            return await infectionRepository.Gets();
        }
    }
}
