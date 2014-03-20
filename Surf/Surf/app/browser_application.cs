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
using CefSharp.WinForms;
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

            // enable Windows visual styles
            Application.EnableVisualStyles();

            // This is used for pre .Net 1.x controls, none of which we use.
            // If enabled, it forces the app to draw using GDI+.
            // GDI+ is the old way, GDI is the new way.
            // PERMANENT: False
            Application.SetCompatibleTextRenderingDefault(false);

            // prepare the new CefSharp settings
            var CefSettings = new CefSharp.Settings();
            CefSettings.UserAgent = app.product.userAgent;
            CefSettings.CachePath = app.product.dirCache;

            // set up the paths to each plugin we use.
            //////////////////////////////////////////
            // path to Flash Player DLL plugin
            CefSettings.AddPluginPath(Path.Combine(app.product.dirSurfApp, "NPSWF32.dll"));

            // initialize CEF
            CEF.Initialize(CefSettings);

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

            // TODO: use the size that was last set by the user.
            browserwindow.Size = new System.Drawing.Size(1060, 700);

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
