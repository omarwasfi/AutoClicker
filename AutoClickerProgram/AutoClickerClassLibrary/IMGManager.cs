using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace ACLibrary
{

    public class IMGManager
    {

        public void DeleteScreenIfExist(string ScreenPath, Bitmap Screen)
        {
            if (Screen != null)
            {
                Screen.Dispose();

                if (File.Exists(ScreenPath))
                {
                    File.Delete(ScreenPath);
                }
            }
            else
            {
                if (File.Exists(ScreenPath))
                {
                    File.Delete(ScreenPath);
                }
            }



        }

    }
}
