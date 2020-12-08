using BuildAxactTest.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAxactTest.Interface
{
  public  interface IConfig
    {
        BrowserType GetBrowser(); 
        string GetUsername();
        string GetPassword();
        string GetSITEnv();
        string GetAccCreationEnv();
        string GetAccountActivationLink();
        string GetAccountLoginLink();

    }
}
