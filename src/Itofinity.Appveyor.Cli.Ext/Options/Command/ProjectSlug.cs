using Itofinity.Refit.Cli.Utils.Options;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Appveyor.Cli.Ext.Options.Command
{
    public class ProjectSlug : AbstractOptionDefinition
    {
        public override string Template => "-pl|--projectslug";

        public override string Description => "The AppVeyor Project Slug";

        public override CommandOptionType OptionType => CommandOptionType.SingleValue;
    }
}