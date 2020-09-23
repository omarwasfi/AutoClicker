using ACLibrary;
using ACLibrary.Enums;
using log4net;
using System;
using System.Collections.Generic;

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
                run();
            }
        }


        private static void run()
        {


            List<Operation> operations = new List<Operation>
            {
                new LeftClickOperation
                (
                    name: "Click on stack overflow Home",
                    imgToFindPaths: new List<string>()
                    {
                        @"C:\WpfLambdatesAutoOpenADS\StackOverflowHomeButton\1.PNG",
                        @"C:\WpfLambdatesAutoOpenADS\StackOverflowHomeButton\2.PNG"
                    },
                    waitAfterDoCommand: new TimeSpan(0,0,0)
                ),
                new MoveTheMouseClickAndTypeOperation
                (
                    name: "Search from hello world",
                    imgToFindPaths: new List<string>() {@"C:\WpfLambdatesAutoOpenADS\StackOverflowSearchTextbox\1.PNG"},
                    "Hello world",
                    waitAfterDoCommand:new TimeSpan(0,0,10)
                    
                ),
                new LeftClickOperation
                (
                    name: "Click on stack overflow Home",
                    imgToFindPaths: new List<string>()
                    {
                        @"C:\WpfLambdatesAutoOpenADS\StackOverflowHomeButton\1.PNG",
                        @"C:\WpfLambdatesAutoOpenADS\StackOverflowHomeButton\2.PNG"
                    },
                    waitAfterDoCommand: new TimeSpan(0,0,0)
                )
            };

            


            foreach (Operation operation in operations)
            {
                if (operation.State == OperationState.Faild)
                {
                    HandleOperation handleOperation =
                        new HandleOperation(operation, @"c:\WpfLambdatesAutoOpenADS\screen.png");
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
