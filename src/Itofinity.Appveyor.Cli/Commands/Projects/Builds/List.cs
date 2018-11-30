using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Itofinity.Appveyor.Cli.Options.Command;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Appveyor.Cli.Commands.Projects.Builds
{
    public class List : AbstractCommandDefinition
    {
        public override string Name { get; } = GetCommandName(typeof(List));
        public string Description => $"Retrieves the build data for the specified project";

        public override Action<CommandLineApplication> GetConfiguration(CommandLineApplication app)
        {
            return (command) =>
            {
                command.Description = Description;

                SetHelpOption(command);
                SetApiTokenOption(command);

                var accountNameOption = SetOption(command, new AccountName());
                var projectSlugOption = SetOption(command, new ProjectSlug());

                var versionOption = command.Option("--version", "The build version", CommandOptionType.SingleValue);

                command.OnExecute(() =>
                {
                    return RunRequest(command,
                        app,
                        () =>
                        {
                            if (versionOption.HasValue())
                            {
                                return ClientFactory.GetClient(ApiTokenOption.Value())
                                .ProjectApiClient
                                .GetProjectBuildByVersion(ClientFactory.GetUserAgent(app),
                                    accountNameOption.Value(),
                                    projectSlugOption.Value(),
                                    versionOption.Value())
                                .Result;
                            }
                            else
                            {
                                return ClientFactory.GetClient(ApiTokenOption.Value())
                                .ProjectApiClient
                                .GetProjectLastBuild(ClientFactory.GetUserAgent(app),
                                    accountNameOption.Value(),
                                    projectSlugOption.Value())
                                .Result;
                            }
                        }
                        );
                });
            };
        }
    }
}