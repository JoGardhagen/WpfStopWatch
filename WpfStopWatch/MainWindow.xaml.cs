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

namespace WpfStopWatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Time time = new Time ("0:0:0:0"); 
        private const string clocka = "00:00:00:00";
        bool running = false;

        public MainWindow()
        {
            InitializeComponent();
            clock.Content = clocka.ToString();

            Timer timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //DateTime myDate = DateTime.Now;
           Application.Current.Dispatcher.Invoke(() => {
                //time.oneSecondPassed();
                if (running == true) { time.oneSecondPassed(); }

                clock.Content = time.getCurrentTime();
            });
        }
        private void startStopClick(object sender, RoutedEventArgs e)
        {
            if (running == false) { running = true; }
            else running = false;
        }
        private void resetClick(object sender ,RoutedEventArgs e)
        {
            running = false;
            time.timeReset("0:0:0:0");
        }
    }
}
