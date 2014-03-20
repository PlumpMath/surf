using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SurfSetupBeta.app
{
    // defines the info needed to download and install the application.
    // This includes the app name, download url where we can get the .zip or .7z file, etc.
    class installer_info
    {

        // returns the app name.
        public static string appName
        {
            get
            {
                string rtnstg = "Surf";
                return rtnstg;
            }
        }

        // returns the publisher name.
        public static string publisherName
        {
            get
            {
                string rtnstg = "Nuewave";
                return rtnstg;
            }
        }

        // returns the downloadurl of Surf.
        public static string downloadUrlSurf
        {
            get
            {
                string rtnstg = "http://dl.nuewave.com/surf/beta/update/surfbeta-nightly.zip";
                return rtnstg;
            }
        }

        // returns the downloadurl of this installer app.
        public static string downloadUrlInstaller
        {
            get
            {
                string rtnstg = "http://dl.nuewave.com/surf/beta/setup/SurfSetupBeta.exe";
                return rtnstg;
            }
        }


        // returns the location to store the downloaded zip file, and where we'll
        // put a copy of this installer app for uninstalling & updating..
        public static string downloadLocation
        {
            get
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Nuewave", "Surf", "Update");
                string rtnstg = dir;
                return rtnstg;

            }
        }

        // returns the Surf app folder where SURF.EXE will go
        public static string dirSurfApp
        {
            get
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Nuewave", "Surf", "Application");
                string rtnstg = dir;
                return rtnstg;
            }
        }

    }

}
