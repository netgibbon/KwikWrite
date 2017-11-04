using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KwikWrite
{
    /// <summary>
    /// Interaction logic for HelpScreen.xaml
    /// </summary>
    public partial class HelpScreen : Window
    {
        public HelpScreen()
        {
            InitializeComponent();
            //Set the help screen to be 25% the size of the main monitor
            this.Height = SystemParameters.FullPrimaryScreenHeight * 0.75;
            this.Width = SystemParameters.FullPrimaryScreenWidth * 0.75;
        }
    }
}
