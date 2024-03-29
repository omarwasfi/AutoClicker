﻿using System;
using System.Collections.Generic;
using System.Text;
using WindowsInput.Native;
using WindowsInput;

namespace ACLibrary
{
    public class KeybordSimulator
    {
        private InputSimulator sim;

        public KeybordSimulator()
        {
            sim = new InputSimulator();
        }

        public void Type(string text)
        {
            sim.Keyboard.TextEntry(text);
        }

        public void PressCTRLWithV()
        {
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
        }
        public void PressCTRLWithC()
        {
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_C);
        }

        public void PressEnter()
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }
        public void PressTab()
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
        }

        public void PressALTLWithTAb()
        {
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LMENU, VirtualKeyCode.TAB);
        }
    }
}
