using ACLibrary;
using ACLibrary.Enums;
using log4net;
using System;
using System.Collections.Generic;

namespace LambdatestConsole
{
    class Program
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


            List<Operation> operations = new List<Operation>();

            operations.Add(new LeftClickOperation
                (
                name: "Click on stack overflow Home",
                imgToFindPaths: new List<string>()
                                {
                    @"C:\WpfLambdatesAutoOpenADS\StackOverflowHomeButton\1.PNG" , @"C:\WpfLambdatesAutoOpenADS\StackOverflowHomeButton\2.PNG"
                                }

                )
            );

            operations.Add(new MoveTheMouseClickAndTypeOperation
               (
               name: "Search from hello world",
               imgToFindPaths: new List<string>()
                               {
                    @"C:\WpfLambdatesAutoOpenADS\StackOverflowSearchTextbox\1.PNG"
                               },
               "Hello world"

               )
           );


            foreach (Operation operation in operations)
            {
                if (operation.State == OperationState.Faild)
                {
                    HandleOperation handleOperation = new HandleOperation(operation);
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
