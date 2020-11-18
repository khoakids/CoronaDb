using CRN.DAL.Interface;
using CRN.Domain.Request.Province;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CRN.DAL.Implement
{
    public class ProvinceRepository : BaseRepository, IProvinceRepository
    {
        public async Task<IEnumerable<ProvinceView>> Gets()
        {
            var result = await SqlMapper.QueryAsync<ProvinceView>(cnn: connection
                                                                    , sql: "sp_GetProvinces"
                                                                    , commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
