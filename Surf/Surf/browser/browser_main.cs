using Surf;
using Surf.TabRenderer;
using System.Windows.Forms;

namespace Surf.browser
{
    public partial class browser_main : TitleBarTabs
    {
        public browser_main()
        {
            InitializeComponent();

            AeroPeekEnabled = false;
            TabRenderer = new chrome_tab_renderer(this);
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

    }
}
