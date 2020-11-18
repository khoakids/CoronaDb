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
    public class StatusController : ControllerBase
    {
        private readonly IStatusService statusService;

        public StatusController(IStatusService statusService)
        {
            this.statusService = statusService;
        }
        [HttpGet]
        [Route("api/status/gets")]
        public async Task<OkObjectResult> Gets()
        {
            var result = await statusService.Gets();
            return Ok(result);
        }
    }
}
