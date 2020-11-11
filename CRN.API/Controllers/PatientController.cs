using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRN.BAL.Interface;
using CRN.Domain.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CRN.API.Controllers
{
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService patientService;

        public PatientController(IPatientService patientService)
        {
            this.patientService = patientService;
        }
        [HttpPost]
        [Route("api/patient/save")]
        public async Task<OkObjectResult> Save(SavePatientReq req)
        {
            var result = await patientService.Save(req);
            return Ok(result);
        }
        [HttpPost]
        [Route("api/patient/getss")]
        public async Task<OkObjectResult> Gets([FromBody] LinkGetsPatient req)
        {
            var result = await patientService.Gets(req);
            return Ok(result);
        }
        [HttpGet]
        [Route("api/patient/gets")]
        public async Task<OkObjectResult> Gets()
        {
            var result = await patientService.Gets();
            return Ok(result);
        }
    }
}
    