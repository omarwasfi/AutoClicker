using System;
using System.Collections.Generic;
using System.Text;

namespace ACLibrary
{
    public class LeftClickOperation : Operation
    {
        private MouseSimulator mouseSimulator;
        private int x;
        private int y;

        public LeftClickOperation(string name, List<string> imgToFindPaths ,TimeSpan waitAfterDoCommand) : base(name, imgToFindPaths,waitAfterDoCommand)
        {
            mouseSimulator = new MouseSimulator();
        }

        public override void DoCommand()
        {
            mouseSimulator.MoveTheMouse(x, y);
            mouseSimulator.LeftClick(x,y);
        }

        public override void SetPosstion(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
