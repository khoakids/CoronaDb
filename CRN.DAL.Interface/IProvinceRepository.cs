using CRN.Domain.Request.Province;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.DAL.Interface
{
    public interface IProvinceRepository
    {
        Task<IEnumerable<ProvinceView>> Gets();
    }
}
