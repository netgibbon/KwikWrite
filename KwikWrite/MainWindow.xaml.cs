/*
    KwikWriter  Copyright (C) 2017  Michael Laws
    This program comes with ABSOLUTELY NO WARRANTY; for details type `show w'.
    This is free software, and you are welcome to redistribute it
 */

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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace KwikWrite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {    
  
        public MainWindow()
        {
            InitializeComponent();
            //Initialise a timer to do a task every 10 milliseconds
            DispatcherTimer millisecondUpdator = new DispatcherTimer();
            millisecondUpdator.Interval = TimeSpan.FromMilliseconds(10);
            millisecondUpdator.Tick += timer_Tick;
            millisecondUpdator.Start();
          
            
            void timer_Tick(object sender, EventArgs e)
            {
                //Update the clock
                timeLabel.Content = DateTime.Now.ToShortTimeString();

                //see if the caps lock, num lock and scroll lock keys are pressed
                if (Console.CapsLock)
                {
                    capsNotifier.Foreground = Brushes.White;
                }
                else
                {
                    capsNotifier.Foreground = Brushes.DarkSlateGray;
                }

                if (Console.NumberLock)
                {
                    numLockNotifier.Foreground = Brushes.White;
                }
                else
                {
                    numLockNotifier.Foreground = Brushes.DarkSlateGray;
                }
            }

            
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            //"Create" the help window
            HelpScreen helpScreen = new HelpScreen();
            helpScreen.Show();
        }
    }
}
