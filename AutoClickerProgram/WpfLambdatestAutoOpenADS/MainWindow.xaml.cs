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
using WpfLambdatestAutoOpenADS.Library;

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
            
            aTimer.Enabled = true;

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
            // each operation 
                // delete the last screen
                // take a screenShot
                //  test all the FindIMGs
                    // if successed 
                    // mark as successed
                    // DoTheAction
                    // if not
                    // try the others & mark as faild
                    // if all faild = Try again 3 times then stop the program if it always fails
                    
        }
    }
}
