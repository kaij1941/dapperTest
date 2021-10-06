using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Model
{
    public class WeatherTestDataModel
    {
        /// <summary>
        /// 代碼
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 天氣名稱
        /// </summary>
        public string WeatherName { get; set; }

        /// <summary>
        /// 標準溫度
        /// </summary>
        public float Temperature { get; set; }

    }
}
