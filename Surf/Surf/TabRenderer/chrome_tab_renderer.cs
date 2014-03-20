using System.Drawing;
using Surf.Properties;

namespace Surf.TabRenderer
{
    /// <summary>Renderer that produces tabs that mimic the appearance of the Chrome browser.</summary>
    public class chrome_tab_renderer : base_tab_renderer
    {
        /// <summary>Constructor that initializes the various resources that we use in rendering.</summary>
        /// <param name="parentWindow">Parent window that this renderer belongs to.</param>
        public chrome_tab_renderer(TitleBarTabs parentWindow)
            : base(parentWindow)
        {
            // Initialize the various images to use during rendering
            _activeLeftSideImage = Resources.tabLeft;
            _activeRightSideImage = Resources.tabRight;
            _activeCenterImage = Resources.tabCenter;
            _inactiveLeftSideImage = Resources.tabInactiveLeft;
            _inactiveRightSideImage = Resources.tabInactiveRight;
            _inactiveCenterImage = Resources.tabInactiveCenter;
            _closeButtonImage = Resources.tabClose;
            _closeButtonHoverImage = Resources.tabCloseHover;
            _background = Resources.tabBackground;
            _addButtonImage = new Bitmap(Resources.tabAdd);
            _addButtonHoverImage = new Bitmap(Resources.tabAddHover);

            // Set the various positioning properties
            CloseButtonMarginTop = 6;
            CloseButtonMarginLeft = 2;
            AddButtonMarginTop = 5;
            AddButtonMarginLeft = -3;
            CaptionMarginTop = 5;
            IconMarginTop = 6;
            IconMarginRight = 5;
            AddButtonMarginRight = 5;
        }

        /// <summary>Since Chrome tabs overlap, we set this property to the amount that they overlap by.</summary>
        public override int OverlapWidth
        {
            get
            {
                return 16;
            }
        }
    }
}