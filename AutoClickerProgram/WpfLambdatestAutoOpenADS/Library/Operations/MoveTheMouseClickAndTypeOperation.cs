using System;
using System.Collections.Generic;
using System.Text;

namespace WpfLambdatestAutoOpenADS.Library
{
    class MoveTheMouseClickAndTypeOperation : Operation
    {
        private KeybordSimulator keybordSimulator;
        private MouseSimulator mouseSimulator;
        private string text;
        private int x;
        private int y;
        public MoveTheMouseClickAndTypeOperation(string name, List<string> imgToFindPaths, string text) : base(name, imgToFindPaths)
        {
            keybordSimulator = new KeybordSimulator();
            mouseSimulator = new MouseSimulator();
            this.text = text;

        }
        
        public override void SetPosstion(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void DoCommand()
        {
            mouseSimulator.MoveTheMouse(x, y);
            mouseSimulator.LeftClick(x, y);
            keybordSimulator.Type(text);
        }
    }
}
