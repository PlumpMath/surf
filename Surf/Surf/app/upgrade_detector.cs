using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Surf.app
{
    class upgrade_detector
    {
        // initialize our settings.
        public static Boolean upgradeAvailable = false;

        // How long (in milliseconds) to wait (each cycle) before checking whether
        // Surf's been upgraded behind our back.
        const int CheckForUpgradeMs = 1 * 60 * 60 * 1000;  // 1 hour.

        // How long to wait (each cycle) before checking which severity level we should
        // be at. Once we reach the highest severity, the timer will stop.
        const int NotifyCycleTimeMs = 20 * 60 * 1000;  // 20 minutes.

        public static void checkForUpgrade()
        {
            // here, we check for the uplock file, placed in the App Dir
            // by Princeton Update when an upgrade is available and
            // has been downloaded. If it's there, we call the
            // upgradeCheck timer.

            if (File.Exists(app.product.dirSurfApp + "uplock"))
            {
                upgradeAvailable = true;
                Surf.browser.tab_frame.bad
            }

        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds( 75 );

        TimeSpan span = endTime.Subtract ( startTime );
        if (span.Seconds == 200)

    }

}
