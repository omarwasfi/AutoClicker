using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using WpfLambdatestAutoOpenADS.Library.Enums;
using System.Drawing.Imaging;
using log4net;

namespace WpfLambdatestAutoOpenADS.Library
{
    class HandleOperation
    {
        private Operation operation;
        private IMGManager imgManager;
        private FindImgOnScreen findImgOnScreen;

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        private const string ScreenPath = @"c:\WpfLambdatesAutoOpenADS\screen.png";

        private Bitmap screenBmp { get; set; }

        public HandleOperation(Operation  operation)
        {
            this.operation = operation;
            this.imgManager = new IMGManager();
            this.findImgOnScreen = new FindImgOnScreen();

        }

        public void TryToHandle()
        {
            log.Info("Start handling " + operation.Name);
            findImage();
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
                    operation.SetPosstion(rect.X, rect.Y);
                    operation.DoCommand();
                    operation.State = OperationState.Successed;
                    
                    log.Info(imgToFindPath + " Found");
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
