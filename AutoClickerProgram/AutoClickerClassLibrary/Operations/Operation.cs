using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using ACLibrary.Enums;

namespace ACLibrary
{
     public abstract class Operation
    {
        #region  Main properties
        public string Name { get; private set; }
        public List<string> ImgsToFindPaths { get; private set; }
        public TimeSpan WaitAfterDoCommand { get; private set; }
        public OperationState State { get; set; }

        #endregion

        protected Operation(string name , List<string> imgsToFindPaths , TimeSpan waitAfterDoCommand )
        {
            this.Name = name;
            this.ImgsToFindPaths = imgsToFindPaths;
            this.WaitAfterDoCommand = waitAfterDoCommand;
            this.State = OperationState.Faild;
        }
        public abstract void SetPosstion(int x, int y);
        public abstract void DoCommand();
      

    }
}
