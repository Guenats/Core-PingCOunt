using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SharpRaven;
using SharpRaven.Data;

namespace PingCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ravenClient = new RavenClient("https://e2d1071a2fbb48438ef154108dda46ab:b69cc349191f4b399429267ad4456b37@sentry.io/257710");
            ravenClient.Capture(new SentryEvent("Le programme PingCount vient de se lancer!"));
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
