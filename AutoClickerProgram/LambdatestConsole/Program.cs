using ACLibrary;
using ACLibrary.Enums;
using log4net;
using MailService;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Threading;

namespace LambdatestConsole
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [STAThreadAttribute]
        static void Main(string[] args)
        {
            // ILog log = log4net.LogManager.GetLogger(typeof(Program));

            log4net.Config.XmlConfigurator.Configure();
            log.Info("        =============  Started Logging  =============        ");
            Console.WriteLine("Enter 1 to start");
            if (Console.ReadLine() == "1")
            {

                run();
            }
        }

        [STAThread]
        private static void run()
        {

            string fullName = "poiqyufgasd";
            List<string> emails = File.ReadAllLines(@"c:\LambdatestConsole\Emails.txt").ToList();

            log.Info("Number of Emails: " + emails.Count);

            string password = "oiuy213ws";
            string companyName = "asdfqw";
            string phoneNumber = "7898652145";

            int doneEmails = 0;

            int ndAllowXPOS = 335;
            int ndAllowYPOS = 255;


            Email reportEmail = new Email();
            string body = "Number of emails: " + emails.Count().ToString() + " \n" + "First Email: " + emails[0];
            reportEmail.Send(to: "alprincewasfi@gmail.com", subject: "Lambdatest console report", body);


            foreach (var email in emails)
            {
                log.Info("===================================================");
                log.Info("Start " + email);
                log.Info("Email Number : " + emails.IndexOf(email).ToString());
                List<Operation> operations = new List<Operation>
                {
                    new MoveTheMouseClickAndTypeOperation
                    (
                        name: "Write Full Name",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\RegisterPage\1-FullName\1.PNG",
                        },
                        text: fullName,
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new MoveTheMouseClickAndTypeOperation
                    (
                        name: "Write Email",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\RegisterPage\2-Email\1.PNG",
                        },
                        text: email,
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new MoveTheMouseClickAndTypeOperation
                    (
                        name: "Write Password",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\RegisterPage\3-DesiredPassword\1.PNG",
                        },
                        text: password,
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new MoveTheMouseClickAndTypeOperation
                    (
                        name: "Write Company Name",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\RegisterPage\4-CompanyName\1.PNG",
                        },
                        text: companyName,
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new MoveTheMouseClickAndTypeOperation
                    (
                        name: "Write PhoneNumber",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\RegisterPage\5-PhoneNumber\1.PNG",
                        },
                        text: phoneNumber,
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new LeftClickOperation
                    (
                        name: "Click on agree",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\RegisterPage\6-Agree\1.PNG"
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new LeftClickOperation
                    (
                        name: "Click on Free Sign up",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\RegisterPage\7-SignUp\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new LeftClickOperation
                    (
                        name: "Go To Gmail tab",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\Gmail\1-1-Tab\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,10)
                    ),
                    new LeftClickOperation
                    (
                        name: "Refresh Gmail",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\Gmail\1-2-RefreshGmail\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,10)
                    ),
                    new LeftClickOperation
                    (
                        name: "Open mail",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\Gmail\2-ClickOnTheEmail\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickOperation
                    (
                        name: "Click on  verfication Link",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\Gmail\3-ClickOnVerificationLink\2.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickOperation
                    (
                        name: "Click on Real time testing",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\1-ClickRealTimeTesting\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    
                    #region 1st

                    new LeftClickOperation
                    (
                        name: "Choose 1024x768 ",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\1.PNG",
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\2.PNG"
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new LeftClickOperation
                    (
                        name: "Click start",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-ClickStart\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    new MoveTheMouseClickTabTabCopyToClipboardPasteAndPressEnterOperation
                    (
                        name: "Type The Ad Url",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\3-TypeTheAdUrl\1.PNG",
                        },
                        text: "298917.click-allow.top",
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press first allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\4-PressFirstAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickCustomPosstion
                    (
                        name: "click second allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\5-PressSecondAllow\1.PNG",
                        },
                        x: ndAllowXPOS,
                        y:ndAllowYPOS,
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press Third allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\6-PressThirdAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    /*new LeftClickOperation
                    (
                        name: "Click Exit",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-PressExit\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickOperation
                    (
                        name: "Yes, End session",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\8-YesEndSession\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,10)
                    ),*/
                    new MoveTheMouseClickTypeAndPressEnterOperation
                    (
                        name: "Write URL to go the realtime",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-1-GoToTheRealTime\1.PNG",
                        },
                        text: "https://app.lambdatest.com/console/realtime",
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "click leave",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-2-PressLeave\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    
                    #endregion 
                    #region 1st

                    new LeftClickOperation
                    (
                        name: "Choose 1024x768 ",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\1.PNG",
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\2.PNG"
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new LeftClickOperation
                    (
                        name: "Click start",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-ClickStart\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    new MoveTheMouseClickTabTabCopyToClipboardPasteAndPressEnterOperation
                    (
                        name: "Type The Ad Url",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\3-TypeTheAdUrl\1.PNG",
                        },
                        text: "298917.click-allow.top",
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press first allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\4-PressFirstAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickCustomPosstion
                    (
                        name: "click second allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\5-PressSecondAllow\1.PNG",
                        },
                        x: ndAllowXPOS,
                        y:ndAllowYPOS,
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press Third allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\6-PressThirdAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    /*new LeftClickOperation
                    (
                        name: "Click Exit",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-PressExit\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickOperation
                    (
                        name: "Yes, End session",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\8-YesEndSession\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,10)
                    ),*/
                    new MoveTheMouseClickTypeAndPressEnterOperation
                    (
                        name: "Write URL to go the realtime",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-1-GoToTheRealTime\1.PNG",
                        },
                        text: "https://app.lambdatest.com/console/realtime",
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "click leave",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-2-PressLeave\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    
                    #endregion 
                    #region 1st

                    new LeftClickOperation
                    (
                        name: "Choose 1024x768 ",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\1.PNG",
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\2.PNG"
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new LeftClickOperation
                    (
                        name: "Click start",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-ClickStart\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    new MoveTheMouseClickTabTabCopyToClipboardPasteAndPressEnterOperation
                    (
                        name: "Type The Ad Url",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\3-TypeTheAdUrl\1.PNG",
                        },
                        text: "298917.click-allow.top",
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press first allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\4-PressFirstAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickCustomPosstion
                    (
                        name: "click second allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\5-PressSecondAllow\1.PNG",
                        },
                        x: ndAllowXPOS,
                        y:ndAllowYPOS,
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press Third allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\6-PressThirdAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    /*new LeftClickOperation
                    (
                        name: "Click Exit",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-PressExit\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickOperation
                    (
                        name: "Yes, End session",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\8-YesEndSession\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,10)
                    ),*/
                    new MoveTheMouseClickTypeAndPressEnterOperation
                    (
                        name: "Write URL to go the realtime",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-1-GoToTheRealTime\1.PNG",
                        },
                        text: "https://app.lambdatest.com/console/realtime",
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "click leave",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-2-PressLeave\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    
                    #endregion 
                    #region 1st

                    new LeftClickOperation
                    (
                        name: "Choose 1024x768 ",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\1.PNG",
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\2.PNG"
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new LeftClickOperation
                    (
                        name: "Click start",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-ClickStart\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    new MoveTheMouseClickTabTabCopyToClipboardPasteAndPressEnterOperation
                    (
                        name: "Type The Ad Url",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\3-TypeTheAdUrl\1.PNG",
                        },
                        text: "298917.click-allow.top",
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press first allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\4-PressFirstAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickCustomPosstion
                    (
                        name: "click second allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\5-PressSecondAllow\1.PNG",
                        },
                        x: ndAllowXPOS,
                        y:ndAllowYPOS,
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press Third allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\6-PressThirdAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    /*new LeftClickOperation
                    (
                        name: "Click Exit",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-PressExit\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickOperation
                    (
                        name: "Yes, End session",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\8-YesEndSession\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,10)
                    ),*/
                    new MoveTheMouseClickTypeAndPressEnterOperation
                    (
                        name: "Write URL to go the realtime",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-1-GoToTheRealTime\1.PNG",
                        },
                        text: "https://app.lambdatest.com/console/realtime",
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "click leave",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-2-PressLeave\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    
                    #endregion 
                    #region 1st

                    new LeftClickOperation
                    (
                        name: "Choose 1024x768 ",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\1.PNG",
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\2.PNG"
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new LeftClickOperation
                    (
                        name: "Click start",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-ClickStart\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    new MoveTheMouseClickTabTabCopyToClipboardPasteAndPressEnterOperation
                    (
                        name: "Type The Ad Url",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\3-TypeTheAdUrl\1.PNG",
                        },
                        text: "298917.click-allow.top",
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press first allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\4-PressFirstAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickCustomPosstion
                    (
                        name: "click second allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\5-PressSecondAllow\1.PNG",
                        },
                        x: ndAllowXPOS,
                        y:ndAllowYPOS,
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press Third allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\6-PressThirdAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    /*new LeftClickOperation
                    (
                        name: "Click Exit",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-PressExit\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickOperation
                    (
                        name: "Yes, End session",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\8-YesEndSession\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,10)
                    ),*/
                    new MoveTheMouseClickTypeAndPressEnterOperation
                    (
                        name: "Write URL to go the realtime",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-1-GoToTheRealTime\1.PNG",
                        },
                        text: "https://app.lambdatest.com/console/realtime",
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "click leave",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-2-PressLeave\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    
                    #endregion 
                    #region 1st

                    new LeftClickOperation
                    (
                        name: "Choose 1024x768 ",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\1.PNG",
                            @"C:\LambdatestConsole\LambdaTest\2-1-Choose1024x768\2.PNG"
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new LeftClickOperation
                    (
                        name: "Click start",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-ClickStart\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    new MoveTheMouseClickTabTabCopyToClipboardPasteAndPressEnterOperation
                    (
                        name: "Type The Ad Url",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\3-TypeTheAdUrl\1.PNG",
                        },
                        text: "298917.click-allow.top",
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press first allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\4-PressFirstAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickCustomPosstion
                    (
                        name: "click second allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\5-PressSecondAllow\1.PNG",
                        },
                        x: ndAllowXPOS,
                        y:ndAllowYPOS,
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new MoveTheMouseClickTabAndPressEnterOperation
                    (
                        name: "Press Third allow",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\6-PressThirdAllow\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,1,0)
                    ),
                    /*new LeftClickOperation
                    (
                        name: "Click Exit",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-PressExit\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    new LeftClickOperation
                    (
                        name: "Yes, End session",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\8-YesEndSession\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,10)
                    ),*/
                    new MoveTheMouseClickTypeAndPressEnterOperation
                    (
                        name: "Write URL to go the realtime",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-1-GoToTheRealTime\1.PNG",
                        },
                        text: "https://app.lambdatest.com/console/realtime",
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "click leave",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\7-2-PressLeave\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,5)
                    ),
                    
                    #endregion 
                    
                    
                    
                    
                   
                    
                    
                    // All Sessions Done
                    
                    new LeftClickOperation
                    (
                        name: "Profile Icon",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\9-ProfileIcon\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,3)
                    ),
                    new LeftClickOperation
                    (
                        name: "Logout",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\10-Logout\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,3)
                    ),
                    new LeftClickOperation
                    (
                        name: "SignUp",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\11-SignUp\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "OpenLastVerification",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\4-CleanUp\1-OpenLastVerification\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "CloseLastVerfication",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\4-CleanUp\2-CloseLastVerfication\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "OpenLastVerficationGmail",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\4-CleanUp\3-OpenLastVerficationGmail\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    /*new LeftClickOperation
                    (
                        name: "BackToMailList",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\4-CleanUp\4-BackToMailList\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "SelectLambdaTest",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\4-CleanUp\5-SelectLambdaTest\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "DeleteEmail",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\4-CleanUp\6-DeleteEmail\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),*/
                    new LeftClickOperation
                    (
                        name: "Delete the Email",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\4-CleanUp\3-2-DeleteLastVerfication\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    ),
                    new LeftClickOperation
                    (
                        name: "BackToSignUpForFree",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\4-CleanUp\7-BackToSignUpForFree\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,1)
                    )



                };

                runOperations(doneEmails, reportEmail, email, operations);

                doneEmails += 1;

                if (doneEmails % 50 == 0)
                {
                    reportEmail.Send(to: "alprincewasfi@gmail.com", subject: "Lambdatest console report 50 email DONE",
                        "Done Emails: " + doneEmails.ToString() + " \n" +
                        "From Total: " + emails.Count.ToString() + " \n" + "Current Email: " + email);
                }

                // Chanage the IP 
                if (doneEmails % 2 == 0)
                {
                    List<Operation> ipOperations = new List<Operation>
                    {
                        new AltTabOperation
                        (
                            name: "Open the vpn Program",
                            imgToFindPaths: new List<string>()
                            {
                                @"C:\LambdatestConsole\VPN\1-OpenTheProgram\1.PNG",
                            },
                            waitAfterDoCommand: new TimeSpan(0,0,1)
                        ),
                         new LeftClickOperation
                        (
                            name: "Change Ip",
                            imgToFindPaths: new List<string>()
                            {
                                @"C:\LambdatestConsole\VPN\2-Change\1.PNG",
                            },
                            waitAfterDoCommand: new TimeSpan(0,0,1)
                        ),
                          new AltTabOperation
                        (
                            name: "Back To The Browser",
                            imgToFindPaths: new List<string>()
                            {
                                @"C:\LambdatestConsole\VPN\3-BackToTheBrowser\1.PNG",
                            },
                            waitAfterDoCommand: new TimeSpan(0,0,2)
                        )

                    };

                    runOperations(doneEmails, reportEmail, email, ipOperations);


                }







            }

        }

        private static void runOperations(int doneEmails, Email reportEmail, string email, List<Operation> operations)
        {
            foreach (Operation operation in operations)
            {
                int tries = 0;
                while (operation.State == OperationState.Faild)
                {
                    HandleOperation handleOperation =
                       new HandleOperation(operation, @"c:\LambdatestConsole\screen.png");
                    handleOperation.TryToHandle();

                    if (operation.State != OperationState.Successed)
                    {
                        log.Info("Operation: " + operation.Name + "=> Faild");
                        Thread.Sleep(1000);
                        if (tries == 300)
                        {
                            reportEmail.Send(to: "alprincewasfi@gmail.com", subject: "Lambdatest console report Stuck",
                                "Operation name: " + operation.Name + " \n Number of done emails: " + doneEmails.ToString() + " \n Current email: " + email);
                        }

                    }
                    else
                    {
                        log.Info("Operation: " + operation.Name + "=> Succsseed");
                    }

                    tries++;
                }

            }
        }
    }
} 
