using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using WpfLambdatestAutoOpenADS.Library.Enums;

namespace WpfLambdatestAutoOpenADS.Library
{
    class Operation
    {
        #region  Main properties
        public int Order { get; set; }
        public string Name { get; set; }
        public List<string> ImgsToFind { get; set; }
        public OperationState State { get; set; }

        // click , write , move curser
        public List<string> Actions { get; set; }



        #endregion

        #region private Used in DoAction

       

        #endregion


        public void DoAction(int x, int y)
        {
            
            //SetCursorPos(x + 20, y + 20);
            //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);

        }

    }
}
