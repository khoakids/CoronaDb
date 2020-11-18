using CRN.BAL.Interface;
using CRN.DAL.Interface;
using CRN.Domain.Request.Province;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.BAL.Implement
{
    public class ProvinceService : IProvinceService
    {
        private readonly IProvinceRepository provinceRepository;

        public ProvinceService(IProvinceRepository provinceRepository)
        {
            this.provinceRepository = provinceRepository;
        }

        public async Task<IEnumerable<ProvinceView>> Gets()
        {
            return await provinceRepository.Gets();
        }
    }
}
