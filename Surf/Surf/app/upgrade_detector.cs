using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Surf.app
{
    class upgrade_detector
    {
        // initialize our settings.
        public static bool upgradeAvailable = false;
        public static int upgradeSeverityLevel = 0;

        // How long (in milliseconds) to wait (each cycle) before checking whether
        // Surf's been upgraded behind our back, or How long to wait (each cycle) 
        // checking which severity level we should be at. Once we reach the highest 
        // severity, the timer will stop.
        public const int NotifyCycleTimeMs = 10 * 60 * 1000;  // 10 minutes.

        public static DateTime startTime;
        public static DateTime endTime;
        public static TimeSpan severityTime;
        
        public static void checkForUpgrade()
        {
            // here, we check for the uplock file, placed in the App Dir
            // by Princeton Update when an upgrade is available and has been downloaded.

            if (File.Exists(Path.Combine(app.product.dirSurfApp, "uplock")))
            {
                startTime = DateTime.Now;
                endTime = DateTime.Now.AddDays(7); // add 7 days, but we check how much time is left in seconds later.
                severityTime = endTime.Subtract(DateTime.Now);

                upgradeAvailable = true;
            }

        }

        public static void increaseSeverityLevel()
        {
            severityTime = endTime.Subtract(DateTime.Now);

            // first hour of upgrade
            if (severityTime.TotalSeconds <= 604800)
            {
                upgradeSeverityLevel = 1;
            }

            // 1 day into pending upgrade
            if (severityTime.TotalSeconds <= 518400)
            {
                upgradeSeverityLevel = 2;
            }

            // 3 days into pending upgrade
            if (severityTime.TotalSeconds <= 345600)
            {
                upgradeSeverityLevel = 3;
            }

            // 3 days, 12 hours
            if (severityTime.TotalSeconds <= 302400)
            {
                upgradeSeverityLevel = 4;
            }

            // 4 days
            if (severityTime.TotalSeconds <= 259200)
            {
                upgradeSeverityLevel = 5;
            }

            // 5 days
            if (severityTime.TotalSeconds <= 172800)
            {
                upgradeSeverityLevel = 6;
            }

            // 6 days
            if (severityTime.TotalSeconds <= 86400)
            {
                upgradeSeverityLevel = 7;
            }

            // day 7 and later.
            if (severityTime.TotalSeconds <= 0)
            {
                upgradeSeverityLevel = 8;

                // now we can stop the timer.
                browser.browser_main.tmrUpgrade.Stop();
            }

        }

        

    }

}
