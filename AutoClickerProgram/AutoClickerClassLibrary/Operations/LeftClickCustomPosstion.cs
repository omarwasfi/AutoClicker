using System;
using System.Collections.Generic;
using System.Text;


namespace ACLibrary
{
    public class LeftClickCustomPosstion : Operation
    {
        private MouseSimulator mouseSimulator;
        private int x;
        private int y;

        public LeftClickCustomPosstion(string name, List<string> imgToFindPaths , int x , int y ,TimeSpan waitAfterDoCommand) : base(name, imgToFindPaths,waitAfterDoCommand)
        {
            mouseSimulator = new MouseSimulator();

            this.x = x;
            this.y = y;
        }

       

        public override void SetPosstion(int x, int y)
        {
            
        }
        
        public override void DoCommand()
        {
            mouseSimulator.MoveTheMouse(x, y);
            mouseSimulator.LeftClick(x,y);
        }
    }
}