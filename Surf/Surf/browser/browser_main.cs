using Surf;
using Surf.TabRenderer;

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

    }
}
