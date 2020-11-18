using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRN.BAL.Implement;
using CRN.BAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRN.API.Controllers
{
    [ApiController]
    public class InfectionController : ControllerBase
    {
        private readonly IInfectionService infectionService;

        public InfectionController(IInfectionService infectionService)
        {
            this.infectionService = infectionService;
        }
        [HttpGet]
        [Route("api/infection/gets")]
        public async Task<OkObjectResult> Gets()
        {
            var result = await infectionService.Gets();
            return Ok(result);
        }
    }
}
