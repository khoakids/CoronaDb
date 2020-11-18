using CRN.Domain.Request.Status;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.DAL.Interface
{
    public interface IStatusRepository
    {
        Task<IEnumerable<StatusView>> Gets();
    }
}
