using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayQuant.TuShare.Model
{
    internal class RESTfulModel
    {
        #region 字段

        #endregion

        #region 属性
        public string API_Name { get; set; } = "daily";
        public string Token { get; set; } = "";
        public string Params { get; set; }
        public string Fields { get; set; }
        #endregion

        #region 方法
        public RESTfulModel()
        {

        }
        #endregion

    }
}
