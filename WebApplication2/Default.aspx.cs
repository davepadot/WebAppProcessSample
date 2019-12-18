using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var exe = $@"c:\windows\system32\ping.exe";
            var start = new ProcessStartInfo
            {
                FileName = exe,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = "google.com"
            };
            using var process = Process.Start(start);
            using var reader = process.StandardOutput;
            var result = reader.ReadToEnd();
            Response.Write(result);

        }
    }
}