// Copyright © 2014 by Nuewave
// Use of this source code is governed by a GPL license that can be
// found in the LICENSE file.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surf.app
{
    class product
    {

        // returns the current version.
        // NOTE: this MUST be updated for each significant build
        // and update! YOU CANNOT FORGET!
        // we follow Semantic Versioning (MAJOR.MINOR.PATCH-TAG)
        //
        // MAJOR version when you make incompatible API changes,
        // MINOR version when you add functionality in a backwards-compatible manner, and
        // PATCH version when you make backwards-compatible bug fixes.
        // TAG can be added to the end as extentions.
        public static string version
        {
            get
            {
                //set up the string
                String ver = null;

                // we place this in a trycatch so we can write to the log if it fails.
                try
                {
                    // prepare the streamreader to read the version in surflock.
                    using (StreamReader sr = new StreamReader(Path.Combine(app.product.dirSurfApp,"surflock")))
                    {
                        // read the surflock versioning file
                        ver = sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    // TODO: write to the logs.
                }

                //return the version string
                string rtnstg = ver;
                return rtnstg;
            }
        }

        // returns the UserAgent string.
        public static string userAgent
        {
            get
            {
                string rtnstg = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.1496 Surf/" + version;
                return rtnstg;
            }
        }

        // returns the Publisher Name (like the developer)
        public static string publisherName
        {
            get
            {
                string rtnstg = "Nuewave";
                return rtnstg;
            }
        }

        // returns the product name (like Surf)
        public static string productName
        {
            get
            {
                string rtnstg = "Surf";
                return rtnstg;
            }
        }

        // returns the copyright string
        public static string productCopyright
        {
            get
            {
                string rtnstg = "Copyright 2014 Nuewave. Surf is an open source project built by the community.";
                return rtnstg;
            }
        }

        ///////////////////////////////////////////////////////////
        // This is where we can retrieve the different
        // directories we use for the browser. This includes
        // the user's profile directory, the temp directory, etc.
        //////////////////////////////////////////////////////////


        // returns the user's %appdata% directory
        public static string dirAppdata
        {
            get
            {
                var dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string rtnstg = dir;
                return rtnstg;
            }
        }

        // returns the ROOT Publisher folder (like Nuewave)
        public static string dirPublisher
        {
            get
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Nuewave");
                string rtnstg = dir;
                return rtnstg;
            }
        }


        // returns the ROOT SURF folder
        public static string dirSurfRoot
        {
            get
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Nuewave", "Surf");
                string rtnstg = dir;
                return rtnstg;
            }
        }

        // returns the Surf app folder containing SURF.EXE
        public static string dirSurfApp
        {
            get
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Nuewave", "Surf", "Application");
                string rtnstg = dir;
                return rtnstg;
            }
        }

        // returns the folder for Surf's USER DATA
        public static string dirUserData
        {
            get
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Nuewave", "Surf", "User Data");
                string rtnstg = dir;
                return rtnstg;
            }
        }

        // returns the folder for Surf's CACHE
        public static string dirCache
        {
            get
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Nuewave", "Surf", "User Data", "Cache");
                string rtnstg = dir;
                return rtnstg;
            }
        }

        // returns the folder for the Surf Logs.
        public static string dirLogs
        {
            get
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Nuewave", "Surf", "Logs");
                string rtnstg = dir;
                return rtnstg;
            }
        }


    } //class product

} // namespace
