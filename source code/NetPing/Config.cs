using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NetPing
{
    class Config
    {
        string fileConfigPath = Path.Combine(Environment.CurrentDirectory, "config.ini");

        public bool AlertIfOnline = true,
            AlertIfOffline = true,
            CheckForInternetConnection = true, Collapse = false,
            ShowAlertMessage = false;
        public int AlertTimes = 0;
        public string SpecificAddress = "www.google.com";

        public bool Read()
        {
            try
            {
                if (File.Exists(fileConfigPath))
                {
                    string[] sa = File.ReadAllLines(fileConfigPath);

                    foreach (string s in sa)
                    {
                        string[] sb = s.Split('=');

                        if (sb.Length >= 2)
                        {
                            string a = sb[0].ToLower();
                            string b = sb[1];

                            switch (a)
                            {
                                case "collapse":
                                case "alertifonline":
                                case "alertifoffline":
                                case "checkforinternetconnection":
                                case "showalertmessage":
                                    {
                                        bool yes = true;

                                        int ii = 0;

                                        if (!int.TryParse(b, out ii))
                                        {
                                            continue;
                                        }

                                        yes = Convert.ToBoolean(ii);

                                        switch (a)
                                        {
                                            case "collapse":
                                                Collapse = yes; break;
                                            case "alertifonline":
                                                AlertIfOnline = yes; break;
                                            case "alertifoffline":
                                                AlertIfOffline = yes; break;
                                            case "checkforinternetconnection":
                                                CheckForInternetConnection = yes; break;
                                            case "showalertmessage":
                                                ShowAlertMessage = yes;break;
                                            default:
                                                break;
                                        }

                                        break;
                                    }
                                case "alerttimes":
                                    {
                                        int.TryParse(b, out AlertTimes);
                                        break;
                                    }
                                case "specificaddress":
                                    SpecificAddress = b.Trim();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    return true;
                }
            }
            catch 
            {
                
            }

            return false;
        }

        public void Write()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("[NetPingConfig]");

            sb.Append("ShowAlertMessage=");
            sb.AppendLine(Convert.ToInt32(ShowAlertMessage).ToString());

            sb.Append("Collapse=");
            sb.AppendLine(Convert.ToInt32(Collapse).ToString());

            sb.Append("AlertIfOnline=");
            sb.AppendLine(Convert.ToInt32(AlertIfOnline).ToString());

            sb.Append("AlertIfOffline=");
            sb.AppendLine(Convert.ToInt32(AlertIfOffline).ToString());

            sb.Append("CheckForInternetConnection=");
            sb.AppendLine(Convert.ToInt32(CheckForInternetConnection).ToString());

            sb.Append("AlertTimes=");
            sb.AppendLine(AlertTimes.ToString());

            sb.Append("SpecificAddress=");
            sb.AppendLine(SpecificAddress);

            string file = Path.Combine(Environment.CurrentDirectory, "config");

            try
            {
                File.WriteAllText(fileConfigPath, sb.ToString());
            }
            catch { }
        }
    }
}
