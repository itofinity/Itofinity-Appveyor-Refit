using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Appveyor.Cli.Options.Command
{
    public class AccountName : AbstractOptionDefinition
    {
        public override string Template => "-an|--accountname";

        public override string Description => "The AppVeyor Account Name";

        public override CommandOptionType OptionType => CommandOptionType.SingleValue;
    }
}