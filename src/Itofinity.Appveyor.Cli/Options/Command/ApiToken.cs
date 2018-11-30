using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Appveyor.Cli.Options.Command
{
    public class ApiToken : AbstractOptionDefinition
    {
        public override string Template => "-a|--apitoken";

        public override string Description => "An AppVeyor API Token";

        public override CommandOptionType OptionType => CommandOptionType.SingleValue;
    }
}