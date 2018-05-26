﻿using System;
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
            MainWindow wnd = new MainWindow();
            if (e.Args.Length >= 1)
            {
                bool openSucc = wnd.OpenFile(e.Args[0]);

            }
            if (e.Args.Length >= 3)
            {
                wnd.Width = Convert.ToDouble(e.Args[1]);
                wnd.Height = Convert.ToDouble(e.Args[2]);
            }

                // Show the window
            wnd.Show();

            HelloWorld wnd2 = new HelloWorld();
            wnd2.Show();
        }
    }
}
