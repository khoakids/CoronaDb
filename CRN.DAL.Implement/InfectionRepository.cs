using CRN.DAL.Interface;
using CRN.Domain.Request.Infection;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CRN.DAL.Implement
{
    public class InfectionRepository : BaseRepository, IInfectionRepository
    {
        public async Task<IEnumerable<InfectionView>> Gets()
        {
            var result = await SqlMapper.QueryAsync<InfectionView>(cnn: connection
                                                                    , sql: "sp_GetInfections"
                                                                    , commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
