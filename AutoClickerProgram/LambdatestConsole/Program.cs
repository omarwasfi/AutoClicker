using ACLibrary;
using ACLibrary.Enums;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LambdatestConsole
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
           // ILog log = log4net.LogManager.GetLogger(typeof(Program));

            log4net.Config.XmlConfigurator.Configure();
            log.Info("        =============  Started Logging  =============        ");
            Console.WriteLine("Enter 1 to start");
            if(Console.ReadLine() == "1")
            {
                /*Operation o = new LeftClickOperation
                (
                    name: "Type The Ad Url",
                    imgToFindPaths: new List<string>()
                    {
                        @"C:\LambdatestConsole\LambdaTest\3-TypeTheAdUrl\1.PNG",
                    },
                    
                    waitAfterDoCommand: new TimeSpan(0, 0, 30)
                );*/
               /* Operation o = new MoveTheMouseClickAndTypeOperation
                (
                    name: "Type The Ad Url",
                    imgToFindPaths: new List<string>()
                    {
                        @"C:\LambdatestConsole\LambdaTest\3-TypeTheAdUrl\1.PNG",
                    },
                    text: "298917.click-allow.top",
                    waitAfterDoCommand: new TimeSpan(0, 0, 30)
                );*/
                /*HandleOperation h = new HandleOperation(o,@"c:\LambdatestConsole\screen.png");
                h.TryToHandle();*/
                run();
            }
        }


        private static void run()
        {

            string fullName = "poiqyufgasd";
            List<string> emails = File.ReadAllLines(@"c:\LambdatestConsole\Emails.txt").ToList();
            string password = "oiuy213ws";
            string companyName = "asdfqw";
            string phoneNumber = "7898652145";
            
            foreach (var email in emails)
            {
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
                        name: "Write Email",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\RegisterPage\3-DesiredPassword\1.PNG",
                        },
                        text: password,
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new MoveTheMouseClickAndTypeOperation
                    (
                        name: "Write Email",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\RegisterPage\4-CompanyName\1.PNG",
                        },
                        text: password,
                        waitAfterDoCommand: new TimeSpan(0,0,0)
                    ),
                    new MoveTheMouseClickAndTypeOperation
                    (
                        name: "Write Email",
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
                            @"C:\LambdatestConsole\RegisterPage\6-Agree\1.PNG",
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
                            @"C:\LambdatestConsole\Gmail\1-Tab\1.PNG",
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
                    new LeftClickOperation
                    (
                        name: "Click start",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\2-ClickStart\1.PNG",
                        },
                        waitAfterDoCommand: new TimeSpan(0,0,30)
                    ),
                    new MoveTheMouseClickTypeAndPressEnterOperation
                    (
                        name: "Type The Ad Url",
                        imgToFindPaths: new List<string>()
                        {
                            @"C:\LambdatestConsole\LambdaTest\3-TypeTheAdUrl\1.PNG",
                        },
                        text: "298917.click-allow.top",
                        waitAfterDoCommand: new TimeSpan(0,0,30)
                    )
                };
                
                
                foreach (Operation operation in operations)
                {
                    if (operation.State == OperationState.Faild)
                    {
                        HandleOperation handleOperation =
                            new HandleOperation(operation, @"c:\LambdatestConsole\screen.png");
                        handleOperation.TryToHandle();

                        if (operation.State != OperationState.Successed)
                        {
                            // stop or try again
                        }
                    }
                }
                
            }
            
           
            

            


        }

    }
}
