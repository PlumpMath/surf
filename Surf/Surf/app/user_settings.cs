using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Surf.app
{
    class user_settings
    {

        // initialize our setting strings, to be defined later in code.
        public static String homePage;
        public static String searchProvider;
        public static String searchProviderQueryURL;
        public static String onStartup;
        public static Boolean showBookmarksBar;
        public static Boolean showHomeButton;
        public static String clearDataOnClose;
        public static Int32 windowBottom;
        public static Int32 windowLeft;
        public static Boolean windowMaximized;

        public static void loadUserSettings()
        {
            // prepare the Xml Writer if needed.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;

            // check if the user settings file exists.

            if (File.Exists(userSettingsFile))
            {
                // the file does exist, so we load all the settings into
                // the predefined NULL booleans and strings.

                XmlReader reader = XmlReader.Create(userSettingsFile);

                // Parse the file and display each of the nodes.
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                             
                            if (reader.Name == "homepage")
                            {
                                homePage = reader.ReadInnerXml();
                            }

                            if (reader.Name == "search_provider")
                            {
                                homePage = reader.ReadInnerXml();
                            }


                            break;

                            // These could be used in the future,
                            // so I'll just leave them here.
                        case XmlNodeType.Text:
                            break;
                        case XmlNodeType.XmlDeclaration:
                            break;
                        case XmlNodeType.ProcessingInstruction:
                            break;
                        case XmlNodeType.Comment:
                            break;
                        case XmlNodeType.EndElement:
                            break;
                    }
                }

            }


            else
            {
                // the xml file doesn't exist.
                // So we create a new one and add the default settings.
                using (XmlWriter writer = XmlWriter.Create(userSettingsFile, settings))
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("Preferences");

                        writer.WriteStartElement("personal");

		                    writer.WriteElementString("homepage", "http://duckduckgo.com");
		                    writer.WriteElementString("search_provider", "DuckDuckGo");
		                    writer.WriteElementString("search_provider_url", "http://duckduckgo.com/?q=");

                        writer.WriteEndElement(); //personal

                        writer.WriteStartElement("browser");

                            writer.WriteElementString("on_startup", "homepage");
                            writer.WriteElementString("show_bookmarks_bar", "false");
                            writer.WriteElementString("show_home_button", "true");
                            writer.WriteElementString("clear_data_on_close", "false");

                        writer.WriteEndElement(); //browser

                        writer.WriteStartElement("window_placement");

                        writer.WriteElementString("bottom", " ");
                        writer.WriteElementString("left", " ");
                        writer.WriteElementString("maximized", "false");

                        writer.WriteEndElement(); //window_placement

                    writer.WriteEndElement(); //Preferences

	                writer.WriteEndDocument(); //end of xml file

                }

            }
        }


        // returns the file location for the User Settings File.
        public static string userSettingsFile
        {
            get
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Nuewave", "Surf", "User Data", "Preferences");
                string rtnstg = dir;
                return rtnstg;
            }
        }

        public static void saveSetting(String settingName, String newvalue)
        {

            var xmlDocument = XDocument.Load(userSettingsFile);

            var element = xmlDocument.Descendants(settingName).FirstOrDefault();

            if (element != null) element.Value = newvalue;

            xmlDocument.Save(userSettingsFile);

        }


    }

}
