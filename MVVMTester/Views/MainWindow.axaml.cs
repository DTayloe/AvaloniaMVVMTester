using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using System.Collections.Generic;

namespace MVVMTester.Views
{
    public partial class MainWindow : Window
    {
        public static List<MainWindow> windows = new List<MainWindow>();

        public MainWindow()
        {
            InitializeComponent();
            

            testListBox.Items.Add("Four");
            testListBox.Items.Add("Five");
            testListBox.Items.Add("Six");
        }

        

        private void CreateWindow_ClickEvent(object sender, RoutedEventArgs e)
        {
            MainWindow nw = new MainWindow();
            windows.Add(nw);
            nw.Show();
        }

        public void CloseAllWindows_ClickEvent(object sender, RoutedEventArgs e)
        {
            foreach (var item in windows)
            {
                item.Close();
            }
        }
    }
}