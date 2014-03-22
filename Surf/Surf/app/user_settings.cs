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
        public static String homepage;
        public static String search_provider;
        public static String search_provider_url;
        public static String on_startup;
        public static Boolean show_bookmarks_bar;
        public static Boolean show_home_button;
        public static Boolean clear_data_on_close;
        public static Int32 window_top;
        public static Int32 window_bottom;
        public static Int32 window_left;
        public static Int32 window_right;
        public static Int32 window_width;
        public static Int32 window_height;
        public static Boolean window_maximized;

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
                                homepage = reader.ReadInnerXml();
                            }

                            if (reader.Name == "search_provider")
                            {
                                search_provider = reader.ReadInnerXml();
                            }

                            if (reader.Name == "search_provider_url")
                            {
                                search_provider_url = reader.ReadInnerXml();
                            }

                            if (reader.Name == "on_startup")
                            {
                                on_startup = reader.ReadInnerXml();
                            }

                            if (reader.Name == "show_bookmarks_bar")
                            {
                                show_bookmarks_bar = Convert.ToBoolean(reader.ReadInnerXml());
                            }

                            if (reader.Name == "show_home_button")
                            {
                                show_home_button = Convert.ToBoolean(reader.ReadInnerXml());
                            }

                            if (reader.Name == "clear_data_on_close")
                            {
                                clear_data_on_close = Convert.ToBoolean(reader.ReadInnerXml());
                            }

                            if (reader.Name == "window_top")
                            {
                                window_top = Convert.ToInt32(reader.ReadInnerXml());
                            }

                            if (reader.Name == "window_bottom")
                            {
                                window_bottom = Convert.ToInt32(reader.ReadInnerXml());
                            }

                            if (reader.Name == "window_left")
                            {
                                window_left = Convert.ToInt32(reader.ReadInnerXml());
                            }

                            if (reader.Name == "window_right")
                            {
                                window_bottom = Convert.ToInt32(reader.ReadInnerXml());
                            }

                            if (reader.Name == "window_width")
                            {
                                window_width = Convert.ToInt32(reader.ReadInnerXml());
                            }

                            if (reader.Name == "window_height")
                            {
                                window_height = Convert.ToInt32(reader.ReadInnerXml());
                            }

                            if (reader.Name == "window_maximized")
                            {
                                window_maximized = Convert.ToBoolean(reader.ReadInnerXml());
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

                // frees up the file.
                reader.Close();

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
                            homepage = "http://duckduckgo.com";

                            writer.WriteElementString("search_provider", "DuckDuckGo");
                            search_provider = "DuckDuckGo";

                            writer.WriteElementString("search_provider_url", "http://duckduckgo.com/?q=");
                            search_provider_url = "http://duckduckgo.com/?q=";

                        writer.WriteEndElement(); //personal

                        writer.WriteStartElement("browser");

                            writer.WriteElementString("on_startup", "homepage");
                            on_startup = "homepage";

                            writer.WriteElementString("show_bookmarks_bar", "false");
                            show_bookmarks_bar = false;

                            writer.WriteElementString("show_home_button", "true");
                            show_home_button = true;

                            writer.WriteElementString("clear_data_on_close", "false");
                            clear_data_on_close = false;

                        writer.WriteEndElement(); //browser

                        writer.WriteStartElement("window_placement");
                        
                        // centers vertically (height)
                        writer.WriteElementString("window_top", Convert.ToString((Screen.PrimaryScreen.WorkingArea.Height / 2) - (700 / 2)));
                        window_top = ((Screen.PrimaryScreen.WorkingArea.Height / 2) - (700 / 2));

                        // not used
                        writer.WriteElementString("window_bottom", "0");
                        window_bottom = 0;
                        
                        // centers horizontally (width)
                        writer.WriteElementString("window_left", Convert.ToString((Screen.PrimaryScreen.WorkingArea.Width / 2) - (900 / 2)));
                        window_left = ((Screen.PrimaryScreen.WorkingArea.Width / 2) - (900 / 2));

                        // not used
                        writer.WriteElementString("window_right", "0");
                        window_right = 0;

                        writer.WriteElementString("window_width", "900");
                        window_width = 900;

                        writer.WriteElementString("window_height", "700");
                        window_height = 700;

                        writer.WriteElementString("window_maximized", "false");
                        window_maximized = false;

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

        public static void saveSetting(String settingName, Object newValue)
        {

            var xmlDocument = XDocument.Load(userSettingsFile);

            var element = xmlDocument.Descendants(settingName).FirstOrDefault();

            if (element != null) element.Value = Convert.ToString(newValue);

            xmlDocument.Save(userSettingsFile);

        }


    }

}
