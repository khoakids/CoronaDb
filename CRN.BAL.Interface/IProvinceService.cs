using CRN.Domain.Request.Province;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.BAL.Interface
{
    public interface IProvinceService
    {
        Task<IEnumerable<ProvinceView>> Gets();
    }
}
