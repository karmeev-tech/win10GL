using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using win10GL.VM;

namespace win10GL.View
{
    /// <summary>
    /// Interaction logic for TabControlUI.xaml
    /// </summary>
    public partial class TabControlUI : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        public TabControlUI()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void TimerTick(object sender,EventArgs e)
        {
            DateTime date = DateTime.Now;
            TimeLabel.Content = date.ToLongTimeString();
        }
        
    }
}
