using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using log4net;
using ACLibrary;
using ACLibrary.Enums;

namespace WpfLambdatestAutoOpenADS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        Timer aTimer;



        public MainWindow()
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();
            
            aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            log.Info("Starting");
            run();
            //aTimer.Enabled = true;

        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            log.Info("Stopping");
            aTimer.Enabled = false;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            run();
        }

        private void run()
        {


            List<Operation> operations = new List<Operation>();

            operations.Add(new LeftClickOperation
                (
                name: "Click on stack overflow Home",
                imgToFindPaths:new List<string>()
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
                if(operation.State == OperationState.Faild)
                {
                    HandleOperation handleOperation = new HandleOperation(operation , @"c:\WpfLambdatesAutoOpenADS\screen.png");
                    handleOperation.TryToHandle();

                    if(operation.State != OperationState.Successed)
                    {
                        // stop or try again
                    }
                }
            }

                    
        }
    }
}
