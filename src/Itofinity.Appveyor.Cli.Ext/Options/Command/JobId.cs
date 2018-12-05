using Itofinity.Refit.Cli.Utils.Options;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Appveyor.Cli.Ext.Options.Command
{
    public class JobId : AbstractOptionDefinition
    {
        public override string Template => "-ji|--jobid";

        public override string Description => "The AppVeyor Job Id";

        public override CommandOptionType OptionType => CommandOptionType.SingleValue;
    }
}