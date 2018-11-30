using Itofinity.Appveyor.Cli.Commands;
using Itofinity.Appveyor.Cli.Options;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Itofinity.Appveyor.Cli
{
    internal class Program
    {
        private static IEnumerable<IOptionDefinition> _globalOptions = new List<IOptionDefinition>()
        {
            new Options.Global.Verbosity(),
            new Options.Global.LogFilePath(),
            new Options.Global.Raw(),
            new Options.Global.Porcelain()
        };

        private static IEnumerable<ICommandDefinition> _commandDefinitions = new List<ICommandDefinition>()
        {
            new Commands.Users.List(),
            new Commands.Projects.List(),
            new Commands.Projects.Settings(),
            new Commands.Projects.Builds.List(),
            new Commands.Builds.Jobs.Artifacts.List(),
        };

        private static ILogger Logger { get; } = ApplicationLogging.CreateLogger<Program>();

        private static void Main(string[] args)
        {
            var app = new CommandLineApplication();
            app.Name = "Itofinity Appveyor CLI";
            app.Description = ".NET Core powered CLI for AppVeyor.";
            app.HelpOption("-?|-h|--help");

            _globalOptions.ToList().ForEach(o => app.Option(o.Template, o.Description, o.OptionType));

            app.OnExecute(() =>
            {
                // minimal requirements
                app.ShowHint();

                return 0;
            });

            // set top level commands
            _commandDefinitions.ToList().ForEach(cd => app.Command(cd.Name, cd.GetConfiguration(app)));

            app.Execute(args);
#if DEBUG
            Console.WriteLine();
            Console.WriteLine("In DEBUG Mode, hit [ENTER] to exit.");
            Console.ReadLine();
#endif
        }
    }
}