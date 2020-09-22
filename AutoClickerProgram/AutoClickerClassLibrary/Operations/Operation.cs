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
        public string Name { get; set; }
        public List<string> ImgsToFindPaths { get; set; }
        public OperationState State { get; set; }

        #endregion
        public Operation(string name , List<string> imgsToFindPaths)
        {
            this.Name = name;
            this.ImgsToFindPaths = imgsToFindPaths;
            this.State = OperationState.Faild;
        }
        public abstract void SetPosstion(int x, int y);
        public abstract void DoCommand();
      

    }
}
