using Surf;
using Surf.TabRenderer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Surf.browser
{
    public partial class browser_main : TitleBarTabs
    {
        // set up the upgrade timer.
        public static Timer tmrUpgrade;

        public browser_main()
        {
            InitializeComponent();

            AeroPeekEnabled = false;
            TabRenderer = new chrome_tab_renderer(this);

            // create the upgrade timer.
            tmrUpgrade = new System.Windows.Forms.Timer();
            tmrUpgrade.Interval = app.upgrade_detector.NotifyCycleTimeMs;
            tmrUpgrade.Start();
            
            tmrUpgrade.Tick += new EventHandler(tmrUpgrade_Tick);
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
                // check if we should increase the severity level.
                app.upgrade_detector.increaseSeverityLevel();

                // init list of open windows (each tab is considered an open window/form)
                List<Form> openForms = new List<Form>();

                    foreach(tab_frame tab in Application.OpenForms.OfType<tab_frame>() )
                    {
                        //*****************************
                        //*****************************
                        // for testing. remove later!
                        tab.label1.Text = app.upgrade_detector.severityTime.TotalSeconds.ToString();

                        // Make the upgrade badge visible.
                        tab.upgradeBadge.Visible = true;

                        // Check the severity level.
                        switch (app.upgrade_detector.upgradeSeverityLevel)
                        {
                            case 1:
                                // severity level is 1.
                                tab.upgradeBadge.Image = Properties.Resources.UpdateBadge1;
                                break;

                            case 2:
                                // severity level is 1.
                                tab.upgradeBadge.Image = Properties.Resources.UpdateBadge2;
                                break;

                            case 3:
                                // severity level is 1.
                                tab.upgradeBadge.Image = Properties.Resources.UpdateBadge3;
                                break;

                            case 4:
                                // severity level is 1.
                                tab.upgradeBadge.Image = Properties.Resources.UpdateBadge4;
                                break;

                            case 5:
                                // severity level is 1.
                                tab.upgradeBadge.Image = Properties.Resources.UpdateBadge5;
                                break;

                            case 6:
                                // severity level is 1.
                                tab.upgradeBadge.Image = Properties.Resources.UpdateBadge6;
                                break;

                            case 7:
                                // severity level is 1.
                                tab.upgradeBadge.Image = Properties.Resources.UpdateBadge7;
                                break;

                            case 8:
                                // severity level is 1.
                                tab.upgradeBadge.Image = Properties.Resources.UpdateBadge8;
                                break;

                        }
                    }
                    
            }
            else
            {
                // an upgrade is not yet available, so call to check for one.
                app.upgrade_detector.checkForUpgrade();
            }

        }

    }
}
