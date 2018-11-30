using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Appveyor.Cli.Options.Command
{
    public class JobId : AbstractOptionDefinition
    {
        public override string Template => "-ji|--jobid";

        public override string Description => "The AppVeyor Job Id";

        public override CommandOptionType OptionType => CommandOptionType.SingleValue;
    }
}