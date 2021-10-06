using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.Interface;

namespace dapperTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly IGetInfoRepository _getInfoRepository;

        public WeatherForecastController(IGetInfoRepository getInfoRepository)
        {
            this._getInfoRepository = getInfoRepository;
        }

        [HttpGet]
        public async Task<float?>  Get(int Id)
        {

            var result = await _getInfoRepository.GetWeatherInfo(Id);
            return result.Temperature;

        }
    }
}
