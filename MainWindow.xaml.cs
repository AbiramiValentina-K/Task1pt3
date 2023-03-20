using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Task1pt3
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += Timer_Tick;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Label.Content = e.Key;
            Label.Visibility = Visibility.Visible;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            Label.Visibility = Visibility.Collapsed;
            timer.Stop();
        }
    }
}