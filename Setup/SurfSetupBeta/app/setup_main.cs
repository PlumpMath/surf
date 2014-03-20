using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SurfSetupBeta
{
    public partial class setup_main : Form
    {
        public setup_main()
        {
            // init.
            InitializeComponent();

            // Ignore illegal cross thread calls
            CheckForIllegalCrossThreadCalls = false;

            Process[] p;

            p = Process.GetProcessesByName("surf");
            
            if ((p.Length > 0))
            {
                //  Process is running
                this.Close();

                // Show the user a message that Surf is already running.
                DialogResult openask = MessageBox.Show("Surf is already on your computer and is running. Surf automatically updates, so there's" +
                    " no need to do it yourself.", "Surf is already installed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // We need to just simply close.
                if ((openask == DialogResult.OK))
                {
                    Application.Exit();
                }

            }
            else
            {
                // Process is not running
                // We run the entire installation in the background so that we
                // can show the user progress at the same time. Otherwise we freeze.
                bkgInstall.RunWorkerAsync();
            }

        }

    } // class

} //namespace
