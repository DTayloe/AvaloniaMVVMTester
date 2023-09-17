using Avalonia.Interactivity;
using MVVMTester.Views;
using System.Collections.Generic;

namespace MVVMTester.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public static List<MainWindow> windows = new List<MainWindow>();

        public string Greeting => "Welcome to Avalonia!";

        public void CreateWindow_CommandBinding()
        {
            MainWindow nw = new MainWindow();
            windows.Add(nw);
            nw.Show();
        }

        public void CloseAllWindows_CommandBinding()
        {
            foreach (var item in windows)
            {
                item.Close();
            }
        }
    }
}