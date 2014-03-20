// Copyright © 2014 by Nuewave
// Use of this source code is governed by a GPL license that can be
// found in the LICENSE file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surf.app
{
    // This module checks all the directories defined in app/product.cs
    // If they don't exist, then it creates them.
    class app_directory_checker
    {

        public static void directoryCheck()
        {

            // Check for the publisher directory
            string dir1 = product.dirPublisher;
            if(!Directory.Exists(dir1))
            {
                // it doesn't exist, so create it.
                Directory.CreateDirectory(dir1);
            }

            // Check for the Surf Root directory
            string dir2 = product.dirSurfRoot;
            if (!Directory.Exists(dir2))
            {
                // it doesn't exist, so create it.
                Directory.CreateDirectory(dir2);
            }

            // Check for the Surf User Data directory
            string dir4 = product.dirUserData;
            if (!Directory.Exists(dir4))
            {
                // it doesn't exist, so create it.
                Directory.CreateDirectory(dir4);
            }

            // Check for the Surf Logs directory
            string dir5 = product.dirCache;
            if (!Directory.Exists(dir5))
            {
                // it doesn't exist, so create it.
                Directory.CreateDirectory(dir5);
            }

            // Check for the Surf Logs directory
            string dir6 = product.dirLogs;
            if (!Directory.Exists(dir6))
            {
                // it doesn't exist, so create it.
                Directory.CreateDirectory(dir6);
            }

        }

       

    } //class

} //namespace
