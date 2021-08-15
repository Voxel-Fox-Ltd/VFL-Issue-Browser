﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubIssueBrowser
{
    public partial class MainGitIssueWindow : Form
    {

        private static readonly HttpClient http = new HttpClient();

        public MainGitIssueWindow()
        {
            Console.WriteLine($"Before startup");
            InitializeComponent();
            Console.WriteLine($"After startup");
        }

        private GithubDeviceCode GetDeviceFlowCode()
        {
            // Make the request args
            var values = new Dictionary<string, string>
            {
                { "client_id", "07c4c3bc8912ac22fa4c" },
                { "scope", "repo user" },
            };
            var content = new FormUrlEncodedContent(values);
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://github.com/login/device/code"),
                Method = HttpMethod.Post,
                Content = content,
            };

            // Make the POST request
            Console.WriteLine("Sending POST request");
            var siteTask = http.SendAsync(request);
            siteTask.Wait();
            var site = siteTask.Result;
            Console.WriteLine($"Sent POST request - {site.StatusCode}");

            // See if it's okay
            if (!site.IsSuccessStatusCode) return null;

            // Parse the data
            var siteContentTask = site.Content.ReadAsStringAsync();
            siteContentTask.Wait();
            var siteContent = siteContentTask.Result;
            Console.WriteLine($"Returned POST content - {siteContent}");
            return GithubDeviceCode.FromResponse(siteContent);
        }

        private string GetGithubAccessToken(GithubDeviceCode deviceCode)
        {
            // Make the request args
            var values = new Dictionary<string, string>
            {
                { "client_id", "07c4c3bc8912ac22fa4c" },
                { "device_code", deviceCode.DeviceCode },
                { "grant_type", "urn:ietf:params:oauth:grant-type:device_code" },
            };
            var content = new FormUrlEncodedContent(values);
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://github.com/login/oauth/access_token"),
                Method = HttpMethod.Post,
                Content = content,
            };

            // Make the POST request
            Console.WriteLine($"Sending POST request {request.RequestUri}");
            var siteTask = http.SendAsync(request);
            siteTask.Wait();
            var site = siteTask.Result;
            Console.WriteLine($"Sent POST request - {site.StatusCode}");

            // See if it's okay
            if (!site.IsSuccessStatusCode) return null;

            // Parse the data
            var siteContentTask = site.Content.ReadAsStringAsync();
            siteContentTask.Wait();
            var siteContent = siteContentTask.Result;
            Console.WriteLine($"Returned POST content - {siteContent}");
            foreach(var i in siteContent.Split("&"))
            {
                var dataSplit = i.Split("=");
                if(dataSplit[0] == "access_token")
                {
                    // Console.WriteLine($"Access token {dataSplit[1]}");
                    return dataSplit[1].Trim();
                }
            }
            return null;
        }

        private string GetGithubUsername(string bearerToken)
        {
            // Make the request args
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://api.github.com/user"),
                // RequestUri = new Uri("https://httpbin.org/get"),
                Method = HttpMethod.Get,
            };
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("Authorization", $"token {bearerToken}");
            request.Headers.Add("User-Agent", "Issue Browser for Github (kae.issuebrowser@voxelfox.co.uk)");

            // Make the POST request
            Console.WriteLine($"Sending GET request {request.RequestUri}");
            var siteTask = http.SendAsync(request);
            siteTask.Wait();
            var site = siteTask.Result;
            Console.WriteLine($"Sent GET request - {site.StatusCode}");

            // See if it's okay
            if (!site.IsSuccessStatusCode) return null;

            // Parse the data
            var siteContentTask = site.Content.ReadAsStringAsync();
            siteContentTask.Wait();
            var siteContent = siteContentTask.Result;
            Console.WriteLine($"Returned GET content - {siteContent}");
            var siteJson = JsonSerializer.Deserialize<GithubUser>(siteContent);
            return siteJson.login;
        }

        private void LoginStripMenuItem_Click(object sender, EventArgs e)
        {
            var deviceFlow = GetDeviceFlowCode();
            if (deviceFlow == null) return;
            Console.WriteLine($"Opening web window - {deviceFlow.VerificationUri}");
            Process.Start("explorer", deviceFlow.VerificationUri);
            Clipboard.SetText(deviceFlow.UserCode);
            MessageBox.Show($"Please use the following device code to verify:\n{deviceFlow.UserCode}\nIt has been copied to your clipboard.");
            string at = GetGithubAccessToken(deviceFlow);
            Console.WriteLine(GetGithubUsername(at));
        }
    }
}
