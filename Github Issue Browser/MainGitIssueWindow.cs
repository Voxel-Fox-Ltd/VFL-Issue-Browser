using System;
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
            // Make the POST request
            var values = new Dictionary<string, string>
            {
                { "client_id", "07c4c3bc8912ac22fa4c" },
                { "scope", "repo" },
            };
            var content = new FormUrlEncodedContent(values);
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://github.com/login/device/code"),
                Method = HttpMethod.Post,
                Content = content,
            };
            request.Headers.Add("Accept", "application/json");

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
            return JsonSerializer.Deserialize<GithubDeviceCode>(siteContent);
        }

        private void LoginStripMenuItem_Click(object sender, EventArgs e)
        {
            var deviceFlow = GetDeviceFlowCode();
            if (deviceFlow == null) return;
            Console.WriteLine($"Opening web window");
            var wb = new WebBrowser();
            wb.Navigate(deviceFlow.VerificationUri);
            wb.Show();
            wb.Focus();
            MessageBox.Show($"Please use the following device code to verify:\n{deviceFlow.UserCode}");
        }
    }
}
