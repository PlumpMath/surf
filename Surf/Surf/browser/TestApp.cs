using Surf;
using Surf.Properties;
using Surf.TabRenderer;

namespace Surf
{
    public partial class TestApp : TitleBarTabs
    {
        public TestApp()
        {
            InitializeComponent();

			AeroPeekEnabled = false;
            TabRenderer = new chrome_tab_renderer(this);
            Icon = Resources.defaultIcon;
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new TabWindow
                {
                    Text = "New Tab"
                }
            };
        }
    }
}
