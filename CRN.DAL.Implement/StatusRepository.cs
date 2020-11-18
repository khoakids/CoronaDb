using CRN.DAL.Interface;
using CRN.Domain.Request.Status;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CRN.DAL.Implement
{
    public class StatusRepository : BaseRepository, IStatusRepository
    {
        public async Task<IEnumerable<StatusView>> Gets()
        {
            var result = await SqlMapper.QueryAsync<StatusView>(cnn: connection,
                                                                 sql: "sp_GetStatuses",
                                                                 commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
