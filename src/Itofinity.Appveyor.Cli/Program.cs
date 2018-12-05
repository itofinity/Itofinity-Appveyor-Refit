using Itofinity.Appveyor.Refit.Client;
using Itofinity.Refit.Cli.Utils;
using System.Collections.Generic;

namespace Itofinity.Appveyor.Cli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CliBuilder<ApiClient>
                .Build<ApiClient>(
                    "Itofinity Appveyor CLI",
                    ".NET Core powered CLI for AppVeyor.",
                    new ClientFactory(),
                    new PorcelainCommandFactory(),
                    new List<string>() { "extensions" },
                    "*.dll")
                .Execute(args);
        }
    }
}