using CRN.Domain.Request;
using CRN.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.BAL.Interface
{
    public interface IPatientService
    {
        Task<SavePatientRes> Save(SavePatientReq req);
        Task<IEnumerable<PatientView>> Gets(int? Gender, int? InfectedPlaceId, int? StatusId, int? InfectionId, int? BackgroundPathology);
    }
}
