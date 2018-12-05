using Itofinity.Appveyor.Refit.Client;
using Itofinity.Refit.Cli.Utils;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Itofinity.Appveyor.Cli
{
    public class ClientFactory : IClientFactory<ApiClient>
    {
        private static ILogger Logger { get; } = ApplicationLogging.CreateLogger<ClientFactory>();

        public Type ClientType => typeof(ApiClient);

        public const string CanonicalApiUrl = "https://ci.appveyor.com/api";

        public ApiClient GetClient()
        {
            throw new NotImplementedException("Appveory requires authentication");
        }

        public ApiClient GetClient(string securityToken)
        {
            return GetClient(CanonicalApiUrl, securityToken);
        }

        public ApiClient GetClient(string apiUrl, string securityToken)
        {
            var tokenToUse = securityToken ?? Environment.GetEnvironmentVariable("APPVEYOR_API_TOKEN");

            if (string.IsNullOrWhiteSpace(tokenToUse))
            {
                Logger.LogError("API Token is empty. Either pass as -a <api token> or set APPVEYOR_API_TOKEN environment variable");
                // TODO for not continue and fail, possibly fail early here?
            }

            return GetClient(apiUrl, () =>
            {
                return Task.FromResult(new Tuple<string, string>("Bearer", tokenToUse));
            });
        }

        public ApiClient GetClient(string apiUrl, Func<Task<Tuple<string, string>>> getSchemeAndToken)
        {
            var client = new ApiClient(apiUrl, getSchemeAndToken);

            return client;
        }

        public string GetUserAgent(CommandLineApplication app)
        {
            // TODO
            return app.Name;
        }

        public IEnumerable<PropertyInfo> GetProperties()
        {
            return typeof(ApiClient).GetProperties().Where(p => p.Name.Contains("Api"));
        }
    }
}