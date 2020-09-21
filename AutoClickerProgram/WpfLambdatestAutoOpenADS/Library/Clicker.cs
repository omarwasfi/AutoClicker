using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfLambdatestAutoOpenADS.Library
{
    public class Clicker
    {
        private string clickMSG = "Clicked";

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Click()
        {
            log.Info(clickMSG);
        }
    }
}
