using CRN.BAL.Interface;
using CRN.DAL.Interface;
using CRN.Domain.Request.Status;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.BAL.Implement
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository statusRepository;

        public StatusService(IStatusRepository statusRepository)
        {
            this.statusRepository = statusRepository;
        }

        public async Task<IEnumerable<StatusView>> Gets()
        {
            return await statusRepository.Gets();
        }
    }
}
