using CRN.DAL.Interface;
using CRN.Domain.Request;
using CRN.Domain.Response;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CRN.DAL.Implement
{
    public class PatientRepository :BaseRepository, IPatientRepository
    {
        public async Task<IEnumerable<PatientView>> Gets(int? Gender, int? InfectedPlaceId, int? StatusId, int? InfectionId, int? BackgroundPathology)
        {
            var result = await SqlMapper.QueryAsync<PatientView>(cnn: connection,
                                                                 sql: "sp_GetPatients",
                                                                 commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<SavePatientRes> Save(SavePatientReq req)
        {
            SavePatientRes result = new SavePatientRes();
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PatientId", req.PatientId);
                parameters.Add("@Fullname", req.Fullname);
                parameters.Add("@Birthday", req.Birthday);
                parameters.Add("@Gender", req.Gender);
                parameters.Add("@Hometown", req.Hometown);
                parameters.Add("@Residence", req.Residence);
                parameters.Add("@InfectedPlaceId", req.InfectedPlaceId);
                parameters.Add("@Job", req.Job);
                parameters.Add("@DetectionDate", req.DetectionDate);
                parameters.Add("@InfectionId", req.InfectionId);
                parameters.Add("@StatusId", req.StatusId);
                parameters.Add("@BackgroundPathology", req.BackgroundPathology);
                parameters.Add("@PathologicalName", req.PathologicalName);
                parameters.Add("@IdentityCard", req.IdentityCard);
                result = await SqlMapper.QueryFirstOrDefaultAsync<SavePatientRes>(cnn: connection,
                                                                                  sql: "sp_SavePatient",
                                                                                  param: parameters,
                                                                                  commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }
    }
}
