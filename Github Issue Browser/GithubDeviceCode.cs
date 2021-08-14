using System;
using System.Collections.Generic;
using System.Text;

namespace GithubIssueBrowser
{
    public class GithubDeviceCode
    {
        string device_code;
        string user_code;
        string verification_uri;
        int expires_in;
        int interval;

        public string DeviceCode
        {
            get { return device_code; }
        }

        public string UserCode
        {
            get { return user_code; }
        }

        public string VerificationUri
        {
            get { return verification_uri; }
        }

        public int ExpiresIn
        {
            get { return expires_in; }
        }

        public int Interval
        {
            get { return interval; }
        }
    }
}
