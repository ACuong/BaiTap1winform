using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace BTViDuMVCGiaiPTBac1.Models
{
    public class Encryption
    {
        public string  PasswordEncryption(String pass)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "MD5");
        }
    }
}