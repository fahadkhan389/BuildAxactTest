using BuildAxactTest.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAxactTest.Configuration
{
    class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
       return (BrowserType)Enum.Parse(typeof(BrowserType),browser);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetSITEnv()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.SITEnv);
        
        
        }
        public string GetAccCreationEnv()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.AccCreationEnv);


        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }
        public string GetAccountActivationLink()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.AccActivation);
        }

        public string GetAccountLoginLink()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.AccLogin);
        }

    }
}
