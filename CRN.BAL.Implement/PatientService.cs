using CRN.BAL.Interface;
using CRN.DAL.Interface;
using CRN.Domain.Request;
using CRN.Domain.Response;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<PatientView> Get(int patientId)
        {
            return await patientRepository.Get(patientId);
        }

        public async Task<IEnumerable<PatientView>> Gets([FromBody] LinkGetsPatient req)
        {
            return await patientRepository.Gets(req);
        }

        public async Task<IEnumerable<PatientView>> Gets()
        {
            return await patientRepository.Gets();
        }

        public async Task<SavePatientRes> Save(SavePatientReq req)
        {
            return await patientRepository.Save(req);
        }
    }
}
