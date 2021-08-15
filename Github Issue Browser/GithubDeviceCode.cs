using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Web;

namespace VFLIssueBrowser
{
    public class GithubDeviceCode
    {
        public string DeviceCode { get; set; }
        public string UserCode { get; set; }
        public string VerificationUri { get; set; }
        public int ExpiresIn { get; set; }
        public int Interval { get; set; }

        public static GithubDeviceCode FromResponse(string response) 
        {
            var dict = new Dictionary<string, string>();
            var data = response.Split("&");
            // device_code = 9f8f7a73806ffd08fb63c6390b56bac7b344050c & expires_in = 899 & interval = 5 & user_code = 3B51 - 95E2 & verification_uri = https % 3A % 2F % 2Fgithub.com % 2Flogin % 2Fdevice
            foreach (var i in data)
            {
                var itemSplit = i.Split("=");
                var key = itemSplit[0];
                var value = HttpUtility.UrlDecode(itemSplit[1]);
                dict.Add(key, value);
            }
            var ghc = new GithubDeviceCode();
            ghc.DeviceCode = dict.GetValueOrDefault("device_code", null);
            ghc.UserCode = dict.GetValueOrDefault("user_code", null);
            ghc.VerificationUri = dict.GetValueOrDefault("verification_uri", null);
            ghc.ExpiresIn = int.Parse(dict.GetValueOrDefault("expires_in", "0"));
            ghc.Interval = int.Parse(dict.GetValueOrDefault("interval", "0"));
            return ghc;
        }
    }

    public class GithubNamingPoilcy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            var parts = name.Split("_");
            var builder = new StringBuilder();
            foreach (var i in parts)
            {
                char firstChar = i[0];
                firstChar = char.ToUpper(firstChar);
                var charArray = i.ToCharArray();
                charArray[0] = firstChar;
                _ = builder.Append(charArray.ToString());
            }
            return builder.ToString();
        }
    }
}
