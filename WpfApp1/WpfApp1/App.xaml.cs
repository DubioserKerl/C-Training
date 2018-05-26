using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private string[] startupArgs;
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            startupArgs = e.Args;
            // Create the startup window
            MainWindow mainWnd = new MainWindow();
            if (e.Args.Length >= 1)
            {
                bool openSucc = mainWnd.OpenFile(e.Args[0]);

            }
            if (e.Args.Length >= 3)
            {
                mainWnd.Width = Convert.ToDouble(e.Args[1]);
                mainWnd.Height = Convert.ToDouble(e.Args[2]);
            }

                // Show the window
            mainWnd.Show();

            HelloWorld hwWnd = new HelloWorld();
            hwWnd.Show();

            ButtonClick btnClickWnd = new ButtonClick();
            btnClickWnd.Show();
        }
    }
}
