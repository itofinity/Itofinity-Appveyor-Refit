using Itofinity.Refit.Cli.Utils.Options;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Appveyor.Cli.Ext.Options.Command
{
    public class AccountName : AbstractOptionDefinition
    {
        public override string Template => "-an|--accountname";

        public override string Description => "The AppVeyor Account Name";

        public override CommandOptionType OptionType => CommandOptionType.SingleValue;
    }
}