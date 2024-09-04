using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayQuant.TuShare.Model.Daily
{
    internal class DailyInput
    {
        #region 字段

        #endregion

        #region 属性
        public string ts_code = "";
        public string trade_date = "";
        public string start_date = "";
        public string end_date = $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}";
        #endregion

        #region 方法
        public DailyInput()
        {

        }
        #endregion
    }
}
