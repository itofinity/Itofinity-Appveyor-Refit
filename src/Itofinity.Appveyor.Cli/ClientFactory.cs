using Itofinity.Appveyor.Refit.Client;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Itofinity.Appveyor.Cli
{
    public class ClientFactory
    {
        private static ILogger Logger { get; } = ApplicationLogging.CreateLogger<ClientFactory>();
        public const string CanonicalApiUrl = "https://ci.appveyor.com/api";

        public static ApiClient GetClient(string apiToken)
        {
            return GetClient(CanonicalApiUrl, apiToken);
        }

        public static ApiClient GetClient(string apiUrl, string apiToken)
        {
            var tokenToUse = apiToken ?? Environment.GetEnvironmentVariable("APPVEYOR_API_TOKEN");

            if (string.IsNullOrWhiteSpace(tokenToUse))
            {
                Logger.LogError("API Token is empty. Either pass as -a <api token> or set APPVEYOR_API_TOKEN environment variable");
                // TODO for not continue and fail, possibly fail early here?
            }

            var client = new ApiClient(apiUrl, () =>
            {
                return Task.FromResult(new Tuple<string, string>("Bearer", tokenToUse));
            });

            return client;
        }

        public static string GetUserAgent(CommandLineApplication app)
        {
            // TODO
            return app.Name;
        }
    }
}