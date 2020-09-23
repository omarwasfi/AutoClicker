using System;
using System.Collections.Generic;

namespace ACLibrary
{
    public class MoveTheMouseClickTypeAndPressEnterOperation : Operation
    {
        private KeybordSimulator keybordSimulator;
        private MouseSimulator mouseSimulator;
        private string text;
        private int x;
        private int y;
        public MoveTheMouseClickTypeAndPressEnterOperation(string name, List<string> imgToFindPaths, string text , TimeSpan waitAfterDoCommand) : base(name, imgToFindPaths , waitAfterDoCommand)
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
            keybordSimulator.PressEnter();
        }
    }
}