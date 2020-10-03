using System;
using System.Collections.Generic;
using System.Text;

namespace ACLibrary
{
    public class AltTabOperation : Operation
    {
        private MouseSimulator mouseSimulator;
        private int x;
        private int y;

        public AltTabOperation(string name, List<string> imgToFindPaths, TimeSpan waitAfterDoCommand) : base(name, imgToFindPaths, waitAfterDoCommand)
        {
            mouseSimulator = new MouseSimulator();
        }



        public override void SetPosstion(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void DoCommand()
        {
           
            new KeybordSimulator().PressALTLWithTAb();
        }
    }
}
