using System.Threading.Tasks;
using Repository.Interface;
using Repository.Model;
using System.Data.SqlClient;
using Dapper;

namespace Repository.Implement
{

    public class GetInfoRepository:IGetInfoRepository
    {
        /// <summary>
        /// 連線字串
        /// </summary>
        private readonly string _connectString =
            @"Persist Security Info=False;Integrated Security=true;  Initial Catalog=Northwind;Server=DESKTOP-U1DLIJ1";

        public async Task<WeatherTestDataModel> GetWeatherInfo(int Id)
        {
            var sql = @" select * from WeatherTest  Where Id =@Id";

            var parameters = new DynamicParameters();
            parameters.Add("Id", Id);
            using (var conn = new SqlConnection(_connectString))
            {
                var result = await conn.QueryFirstOrDefaultAsync<WeatherTestDataModel>(sql, parameters);
                return result;
            }
        }
    }
}
