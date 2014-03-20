using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Surf.Properties;

namespace Surf
{
    public partial class TabWindow : Form
    {
        public TabWindow()
        {
            InitializeComponent();
            webBrowser.Url = new Uri(urlTextBox.Text);
            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (urlTextBox.Text != "about:blank")
            {
                Text = webBrowser.DocumentTitle;
                urlTextBox.Text = webBrowser.Url.ToString();

                if (webBrowser.Url.Scheme == "http")
                {
                    try
                    {
                        WebRequest webRequest = WebRequest.Create("http://" + webBrowser.Url.Host + "/favicon.ico");
                        WebResponse response = webRequest.GetResponse();
                        Stream stream = response.GetResponseStream();

                        if (stream != null)
                        {
                            byte[] buffer = new byte[1024];

                            using (MemoryStream ms = new MemoryStream())
                            {
                                int read;

                                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                                    ms.Write(buffer, 0, read);

                                ms.Seek(0, SeekOrigin.Begin);

                                Icon = new Icon(ms);
                            }
                        }
                    }

                    catch
                    {
                        Icon = Resources.defaultIcon;
                    }
                }

                Parent.Refresh();
            }

            else
                Icon = Resources.defaultIcon;
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.BackgroundImage = Resources.buttonHoverBackground;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackgroundImage = null;
        }

        private void urlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string fullUrl = urlTextBox.Text;

                if (!Regex.IsMatch(fullUrl, "^[a-zA-Z0-9]+\\://"))
                    fullUrl = "http://" + fullUrl;

                Uri uri = new Uri(fullUrl);
                webBrowser.Navigate(uri);
            }
        }

        private void forwardButton_MouseEnter(object sender, EventArgs e)
        {
            forwardButton.BackgroundImage = Resources.buttonHoverBackground;
        }

        private void forwardButton_MouseLeave(object sender, EventArgs e)
        {
            forwardButton.BackgroundImage = null;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }
    }
}
