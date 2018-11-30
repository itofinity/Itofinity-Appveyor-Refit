using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Appveyor.Cli.Options.Global
{
    public class Porcelain : AbstractOptionDefinition
    {
        public override string Template => "-p|--porcelain";

        public override string Description => "Forces porcelain output suitable for scripting";

        public override CommandOptionType OptionType => CommandOptionType.NoValue;
    }
}