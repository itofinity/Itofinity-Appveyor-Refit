using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.CommandLineUtils;
using System.Reflection;

namespace Itofinity.Appveyor.Cli.Ext.Commands.Projects
{
    public class List : AbstractCommandDefinition
    {
        public override string Name { get; } = GetCommandName(typeof(List));

        public string Description => $"This is the description for {Name}.";

        public override Action<CommandLineApplication> GetConfiguration(CommandLineApplication app)
        {
            return (command) =>
            {
                command.Description = Description;

                SetHelpOption(command);
                SetApiTokenOption(command);

                command.OnExecute(() =>
                {
                    return RunRequest(command,
                        app,
                        () =>
                        {
                            return ClientFactory.GetClient(ApiTokenOption.Value()).ProjectApiClient.GetProjects(ClientFactory.GetUserAgent(app)).Result;
                        }
                        );
                });
            };
        }
    }
}