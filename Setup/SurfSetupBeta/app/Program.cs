using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurfSetupBeta
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            // prepare our embedded SevenZipSharp.dll for unpacking
            // the Surf app when installing or updating.
            string resource1 = "SurfSetupBeta.SevenZipSharp.dll";
            EmbeddedAssembly.Load(resource1, "SevenZipSharp.dll");

            // call our custom AssemblyResolve function below to load
            // the SevenZipSharp wrapper into memory
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            foreach (string s in args)
            {
                if (s.Equals("-update"))
                {
                    // Launch the updater portion of the setup app.
                    Application.Run(new princeton_update());

                    // return control so we stop running this code here.
                    return;
                }
                else if (s.Equals("-uninstall"))
                {
                    // Launch the uninstaller portion of the setup app.
                    Application.Run(new uninstall());

                    // return control so we stop running this code here.
                    return;
                }
            }
            // Otherwise start the installation process.
            Application.Run(new setup_main());

        } // static void Main

        static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            // calls EmbeddedAssembly class Get function to get the
            // dll into memory! Yay.
            return EmbeddedAssembly.Get(args.Name);
        }

    } //static class Program

} //namespace
