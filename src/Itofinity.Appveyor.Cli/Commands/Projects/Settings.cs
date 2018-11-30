using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Itofinity.Appveyor.Cli.Options.Command;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Appveyor.Cli.Commands.Projects
{
    public class Settings : AbstractCommandDefinition
    {
        public override string Name { get; } = GetCommandName(typeof(Settings));
        public string Description => $"Retrieves the settings data for the specified project";

        public override Action<CommandLineApplication> GetConfiguration(CommandLineApplication app)
        {
            return (command) =>
            {
                command.Description = Description;

                SetHelpOption(command);
                SetApiTokenOption(command);

                var accountNameOption = SetOption(command, new AccountName());
                var projectSlugOption = SetOption(command, new ProjectSlug());

                var yamlOption = command.Option("--yaml", "Get as YAML", CommandOptionType.NoValue);

                command.OnExecute(() =>
                {
                    return RunRequest(command,
                        app,
                        () =>
                        {
                            if (yamlOption.HasValue())
                            {
                                return ClientFactory.GetClient(ApiTokenOption.Value())
                            .ProjectApiClient
                            .GetProjectSettingsYaml(ClientFactory.GetUserAgent(app),
                                accountNameOption.Value(),
                                projectSlugOption.Value())
                            .Result;
                            }
                            else
                            {
                                return ClientFactory.GetClient(ApiTokenOption.Value())
                            .ProjectApiClient
                            .GetProjectSettings(ClientFactory.GetUserAgent(app),
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