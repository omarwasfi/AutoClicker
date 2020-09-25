using System;
using System.Collections.Generic;
using System.Threading;

namespace ACLibrary
{
    public class MoveTheMouseClickTabTabCopyToClipboardPasteAndPressEnterOperation : Operation
    {
        private KeybordSimulator keybordSimulator;
        private MouseSimulator mouseSimulator;
        private string text;
        private int x;
        private int y;
        
        public MoveTheMouseClickTabTabCopyToClipboardPasteAndPressEnterOperation(string name, List<string> imgToFindPaths, string text , TimeSpan waitAfterDoCommand) : base(name, imgToFindPaths , waitAfterDoCommand)
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
            Thread.Sleep(1000);
            keybordSimulator.PressTab();
            Thread.Sleep(1000);

            keybordSimulator.PressTab();
            Thread.Sleep(1000);

            TextCopy.ClipboardService.SetText(text);
            Thread.Sleep(1000);

            keybordSimulator.PressCTRLWithV();
            Thread.Sleep(1000);

            keybordSimulator.PressEnter();
        }
    }
}