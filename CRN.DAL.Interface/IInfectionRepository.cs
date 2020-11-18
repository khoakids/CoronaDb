using CRN.Domain.Request.Infection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.DAL.Interface
{
    public interface IInfectionRepository
    {
        Task<IEnumerable<InfectionView>> Gets();
    }
}
