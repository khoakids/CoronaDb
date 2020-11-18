using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRN.BAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRN.API.Controllers
{
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceService provinceService;

        public ProvinceController(IProvinceService provinceService)
        {
            this.provinceService = provinceService;
        }
        [HttpGet]
        [Route("api/province/gets")]
        public async Task<OkObjectResult> Gets()
        {
            var result = await provinceService.Gets();
            return Ok(result);
        }
    }
}
