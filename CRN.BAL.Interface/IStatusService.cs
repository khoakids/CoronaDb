using CRN.Domain.Request.Status;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.BAL.Interface
{
    public interface IStatusService
    {
        Task<IEnumerable<StatusView>> Gets();
    }
}
