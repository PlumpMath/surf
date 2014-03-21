// Copyright © 2014 by Nuewave
// Use of this source code is governed by a GPL license that can be
// found in the LICENSE file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Surf;
using Surf.TabRenderer;
using Surf.app;
using CefSharp.WinForm;
using CefSharp;

namespace Surf
{
    static class browser_application
    {
        // the main entry point for the browser
        [STAThread]
        static void Main(string[] args)
        {
            // subscribe to our wonderful exception handler
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
            
            // perform the directory check
            Surf.app.app_directory_checker.directoryCheck();

            // load the user settings
            app.user_settings.loadUserSettings();

            // enable Windows visual styles
            Application.EnableVisualStyles();

            // This is used for pre .Net 1.x controls, none of which we use.
            // If enabled, it forces the app to draw using GDI+.
            // GDI+ is the old way, GDI is the new way.
            // PERMANENT: False
            Application.SetCompatibleTextRenderingDefault(false);

            // prepare the new CefSharp settings

            var settings = new CefSettings
            {
                UserAgent = app.product.userAgent,
                CachePath = app.product.dirCache,
                BrowserSubprocessPath = "surf.exe",
            };

            // Not really sure if we need this, it seems
            // that CefSettings.CachePath also sets for
            // the cookies path.
            Cef.SetCookiePath(app.product.dirCache, true);

            // initialize CEF
            Cef.Initialize(settings);

            // prepare the new browser window
            Surf.browser.browser_main browserwindow = new Surf.browser.browser_main();

            // add a new tab to the browser window
            browserwindow.Tabs.Add(
                new TitleBarTab(browserwindow)
                {
                    Content = new Surf.browser.tab_frame
                    {
                        Text = "New Tab"
                    }
                });
            browserwindow.SelectedTabIndex = 0;

            // temporary size
            browserwindow.Size = new System.Drawing.Size(900, 700);

            browserwindow.Size = new System.Drawing.Size(app.user_settings.window_width, app.user_settings.window_height);
            browserwindow.Location = new System.Drawing.Point(user_settings.window_left, user_settings.window_top);


            if (app.user_settings.window_maximized == true)
            {
                browserwindow.WindowState = FormWindowState.Maximized;
            }
            else
            {
                browserwindow.WindowState = FormWindowState.Normal;
            }

            // prepare the TabRenderer
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(browserwindow);

            // start the browser!
            Application.Run(applicationContext);

        } //void Main

        // here we handle any exceptions that occur in the application.
        // TODO: add something better...
        public static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            MessageBox.Show("meow");
        } //myhandler

    } //class browser_startup

} //namespace Surf
