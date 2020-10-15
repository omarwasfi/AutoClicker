using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ACLibrary.Enums;
using System.Drawing.Imaging;
using log4net;
using System.Threading;

namespace ACLibrary
{
    public class HandleOperation
    {
        private Operation operation;
        private IMGManager imgManager;
        private FindImgOnScreen findImgOnScreen;

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        private string ScreenPath;

        private Bitmap screenBmp { get; set; }

        public HandleOperation(Operation  operation, string screenPath)
        {
            this.operation = operation;
            this.ScreenPath = screenPath;
            this.imgManager = new IMGManager();
            this.findImgOnScreen = new FindImgOnScreen();

        }

        public void TryToHandle()
        {
            log.Info("Start handling " + operation.Name);
            try
            {
                findImage();
            }
            catch
            {
                operation.State = OperationState.Faild;
            }
        }

        private void findImage()
        {


            foreach(string imgToFindPath in operation.ImgsToFindPaths)
            {
                Bitmap ImgToFind = new Bitmap(imgToFindPath);
                getANewScreenCapture();
                Rectangle rect = findImgOnScreen.FindImageOnScreen(screenBmp,ImgToFind, false);
                if (rect != Rectangle.Empty)
                {
                    log.Info(imgToFindPath + " Found");

                    operation.SetPosstion(rect.X, rect.Y);
                    operation.DoCommand();
                    operation.State = OperationState.Successed;
                    
                    log.Info("Wating: " +operation.WaitAfterDoCommand.TotalSeconds+ " seconds");

                    Thread.Sleep(operation.WaitAfterDoCommand);
                    
                    log.Info("Operation " +operation.Name +" successed");
                    break;
                }
                else
                {
                    operation.State = OperationState.Faild;
                    log.Info(imgToFindPath + " Not found");
                }
            }


        }

        private void getANewScreenCapture()
        {
            imgManager.DeleteScreenIfExist(ScreenPath, screenBmp);

            var image = ScreenCapture.CaptureDesktop();
            image.Save(ScreenPath, ImageFormat.Png);

            screenBmp = new Bitmap(ScreenPath);
        }
    }
}
