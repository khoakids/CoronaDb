using CRN.Domain.Request;
using CRN.Domain.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.BAL.Interface
{
    public interface IPatientService
    {
        Task<SavePatientRes> Save(SavePatientReq req);
        Task<IEnumerable<PatientView>> Gets([FromBody] LinkGetsPatient req);
        Task<IEnumerable<PatientView>> Gets();
        Task<PatientView> Get(int patientId);
    }
}
