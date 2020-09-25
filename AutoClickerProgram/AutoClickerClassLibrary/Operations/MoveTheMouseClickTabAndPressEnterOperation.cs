using System;
using System.Collections.Generic;

namespace ACLibrary
{
    public class MoveTheMouseClickTabAndPressEnterOperation : Operation
    {
        private MouseSimulator mouseSimulator;
        private int x;
        private int y;

        public MoveTheMouseClickTabAndPressEnterOperation(string name, List<string> imgToFindPaths ,TimeSpan waitAfterDoCommand) : base(name, imgToFindPaths,waitAfterDoCommand)
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
            mouseSimulator.MoveTheMouse(x, y);
            mouseSimulator.LeftClick(x,y);
            new KeybordSimulator().PressTab();
            new KeybordSimulator().PressEnter();
        }
    }
}