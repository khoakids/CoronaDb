using CRN.BAL.Interface;
using CRN.DAL.Interface;
using CRN.Domain.Request;
using CRN.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRN.BAL.Implement
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        public async Task<IEnumerable<PatientView>> Gets(int? Gender, int? InfectedPlaceId, int? StatusId, int? InfectionId, int? BackgroundPathology)
        {
            return await patientRepository.Gets(Gender, InfectedPlaceId, StatusId, InfectionId, BackgroundPathology);
        }

        public async Task<SavePatientRes> Save(SavePatientReq req)
        {
            return await patientRepository.Save(req);
        }
    }
}
