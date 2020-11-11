using CRN.DAL.Interface;
using CRN.Domain.Request;
using CRN.Domain.Response;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CRN.DAL.Implement
{
    public class PatientRepository :BaseRepository, IPatientRepository
    {
        public async Task<IEnumerable<PatientView>> Gets([FromBody] LinkGetsPatient req)
        {
            IEnumerable<PatientView> result = new List<PatientView>();
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Gender", (req.Gender == 0 || req.Gender == 1) ? req.Gender : null);
                parameters.Add("@InfectedPlaceId", req.InfectedPlaceId==0 ? null : req.InfectedPlaceId);
                parameters.Add("@StatusId", req.StatusId==0 ? null : req.StatusId);
                parameters.Add("@InfectionId", req.InfectionId==0 ? null : req.InfectionId);
                parameters.Add("@BackgroundPathology", (req.BackgroundPathology == 0 || req.BackgroundPathology == 1) ? req.BackgroundPathology : null);
                result = await SqlMapper.QueryAsync<PatientView>(cnn: connection,
                                                                     sql: "sp_GetPatients",
                                                                     param: parameters,
                                                                     commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
            
        }

        public async Task<IEnumerable<PatientView>> Gets()
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
