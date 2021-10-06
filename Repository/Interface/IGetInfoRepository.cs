using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Model;

namespace Repository.Interface
{
    public interface IGetInfoRepository
    {
        /// <summary>
        /// 取得天氣資訊
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<WeatherTestDataModel> GetWeatherInfo(int Id);
    }
}
