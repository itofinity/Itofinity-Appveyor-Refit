using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Appveyor.Cli.Options.Global
{
    public class Raw : AbstractOptionDefinition
    {
        public override string Template => "-r|--raw";

        public override string Description => "Forces raw JSON output";

        public override CommandOptionType OptionType => CommandOptionType.NoValue;
    }
}