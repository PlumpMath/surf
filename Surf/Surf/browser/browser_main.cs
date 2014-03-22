using Surf;
using Surf.TabRenderer;
using System;
using System.Windows.Forms;

namespace Surf.browser
{
    public partial class browser_main : TitleBarTabs
    {
        // set up the upgrade timer.
        Timer tmrUpgrade;

        public browser_main()
        {
            InitializeComponent();

            AeroPeekEnabled = false;
            TabRenderer = new chrome_tab_renderer(this);

            // create the upgrade timer.
            tmrUpgrade = new System.Windows.Forms.Timer();
            tmrUpgrade.Interval = 3000;

            this.tmrUpgrade.Tick += new EventHandler(tmrUpgrade_Tick); 
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new tab_frame
                {
                    Text = "New Tab"
                }
            };
        }

        private void browser_main_FormClosing(object sender, FormClosingEventArgs e)
        {

            // maximized or naw
            if (WindowState == FormWindowState.Maximized)
            {
                app.user_settings.saveSetting("window_maximized", true);
                // positions
                app.user_settings.saveSetting("window_top", RestoreBounds.Top);
                app.user_settings.saveSetting("window_bottom", RestoreBounds.Bottom);
                app.user_settings.saveSetting("window_left", RestoreBounds.Left);
                app.user_settings.saveSetting("window_right", RestoreBounds.Right);

                // width and height
                app.user_settings.saveSetting("window_width", RestoreBounds.Size.Width);
                app.user_settings.saveSetting("window_height", RestoreBounds.Size.Height);
            }
            else
            {
                app.user_settings.saveSetting("window_maximized", false);
                // positions
                app.user_settings.saveSetting("window_top", this.Top);
                app.user_settings.saveSetting("window_bottom", this.Bottom);
                app.user_settings.saveSetting("window_left", this.Left);
                app.user_settings.saveSetting("window_right", this.Right);

                // width and height
                app.user_settings.saveSetting("window_width", this.Size.Width);
                app.user_settings.saveSetting("window_height", this.Size.Height);
            }

        }

        private void tmrUpgrade_Tick(object sender, EventArgs e)
        {
            // call to check if an upgrade is available.
            if (app.upgrade_detector.upgradeAvailable)
            {
                // an upgrade is available! So now let's call the
                // 
            }
            else
            {
                // an upgrade is not yet available, so call to check for one.
            }

        }

    }
}
