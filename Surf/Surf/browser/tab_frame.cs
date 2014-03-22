// Copyright © 2014 by Nuewave
// Use of this source code is governed by a GPL license that can be
// found in the LICENSE file.
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Windows.Forms;
using CefSharp.WinForm;
using CefSharp;
using System.Security.Permissions;

namespace Surf.browser
{
    public partial class tab_frame : Form
    {
        // set up the new WebView control
        WebView webView;

        public tab_frame()
        {
            CheckForIllegalCrossThreadCalls = false;

            // init
            InitializeComponent();

            // prepare the BrowserSettings
            var BSettings = new BrowserSettings();
            //BSettings.WebSecurityDisabled = true;
            //BSettings.PluginsDisabled = false;
            //BSettings.FileAccessFromFileUrlsAllowed = true;
            //BSettings.JavaScriptDisabled = false;
            //BSettings.XssAuditorEnabled = false;
            //BSettings.AcceleratedPluginsDisabled = false;
            //BSettings.DeveloperToolsDisabled = false;
            //BSettings.RemoteFontsDisabled = false;

            // initialize the webview
            webView = new WebView("http://www.google.com", new BrowserSettings());

            // prepare and add the webview to the window.
            webView.Dock = DockStyle.Fill;
            webView.BringToFront();
            this.maincontainer.Controls.Add(webView);

            // prepare the eventhandlers
            webView.PropertyChanged += new PropertyChangedEventHandler(webView_PropertyChanged);
            webView.LoadCompleted += new LoadCompletedEventHandler(webview_LoadCompleted);

        }

        private void webview_LoadCompleted(object sender, LoadCompletedEventArgs url)
        {
            // we are not loading. Show the favicon.
            OneBoxFavIcon.Image = Properties.Resources.favicondefault;
            OneBoxFavIcon.Image = favIconImage(webView.Address.ToString());

            this.Icon = Properties.Resources.favicondefaultico;
            this.Icon = favIcon(webView.Address.ToString());

            if (webView.IsLoading)
            {
                // we are loading. Show the spinner.
                OneBoxFavIcon.Image = Properties.Resources.spinnerLoading;
            }
            else
            {

            }

        }

        // Get all properties from https://github.com/chillitom/CefSharp/blob/master/CefSharp/BrowserCore.h
        void webView_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // TODO: since CefSharp3 upgrade, doesn't seem to be working,
            // except for the Address property. There are some other
            // new EventArgs, look into those.

            //BrowserCore core = (BrowserCore)sender;
            switch (e.PropertyName)
            {
                case "IsBrowserInitialized":
                    //core.IsBrowserInitialized
                    break;

                case "Title":
                    //core.Title
                    this.Text = webView.Title;
                    break;

                case "Address":
                    //core.Address
                    OneBox.Text = webView.Address;
                    break;

                case "CanGoBack":
                    //core.CanGoBack
                    break;

                case "CanGoForward":
                    //core.CanGoForward;
                    break;

                case "IsLoading":
                    if (webView.IsLoading)
                    {
                        // we are loading. Show the spinner.
                        OneBoxFavIcon.Image = Properties.Resources.spinnerLoading;
                    }
                    else
                    {
                        // we are not loading. Show the favicon.
                        OneBoxFavIcon.Image = Properties.Resources.favicondefault;
                        OneBoxFavIcon.Image = favIconImage(webView.Address.ToString());

                        this.Icon = Properties.Resources.favicondefaultico;
                        this.Icon = favIcon(webView.Address.ToString());

                    }

                    break; 

            }
        }

        public static Image favIconImage(String url)
        {
            try
            {
                Uri websiteuri = new Uri(url);

                string faviconurl = "http://" + websiteuri.Host + "/favicon.ico";

                WebRequest req = WebRequest.Create(faviconurl);

                WebResponse res = req.GetResponse();

                Stream ico = res.GetResponseStream();

                return Image.FromStream(ico);
            }
            catch (Exception ex)
            {
                return Properties.Resources.favicondefault;
            }
        }

        public static Icon favIcon(String url)

        {
            try
            {
                Uri websiteuri = new Uri(url);

                string faviconurl = "http://" + websiteuri.Host + "/favicon.ico";

                WebRequest req = WebRequest.Create(faviconurl);

                WebResponse res = req.GetResponse();

                Stream ico = res.GetResponseStream();

                Image img = Image.FromStream(ico);
                Bitmap bm = new Bitmap(img);
                IntPtr hIcon = bm.GetHicon();
                Icon TheIcon = Icon.FromHandle(hIcon);

                return TheIcon;

                TheIcon.Dispose();
            }
            catch (Exception ex)
            {
                return Properties.Resources.favicondefaultico;
            }
        }

        private void OneBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // indicate we handled the event, we won't hear a DING! sound.
                e.Handled = true;
                // navigate the webView to the specified address.

                // TODO: diff between searching or web address.
                webView.Load(OneBox.Text);
            }
        }


    } // public browser_frame

} //namespace Surf.browser
