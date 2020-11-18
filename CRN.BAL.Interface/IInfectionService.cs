using CRN.Domain.Request.Infection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.BAL.Interface
{
    public interface IInfectionService 
    {
        Task<IEnumerable<InfectionView>> Gets();
    }
}
