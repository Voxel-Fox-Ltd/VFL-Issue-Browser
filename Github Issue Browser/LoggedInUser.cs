using System;
using System.Collections.Generic;
using System.Text;

namespace VFLIssueBrowser
{
    class LoggedInUser
    {
        public string Username { get; set; }
        public string AuthToken { get; set; }

        public string ToJson()
        {
            return $"{{\"Username\": \"{Username}\", \"AuthToken\": \"{AuthToken}\"}}";
        }
    }
}
