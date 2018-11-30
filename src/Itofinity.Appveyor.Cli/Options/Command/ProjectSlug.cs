using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itofinity.Appveyor.Cli.Options.Command
{
    public class ProjectSlug : AbstractOptionDefinition
    {
        public override string Template => "-pl|--projectslug";

        public override string Description => "The AppVeyor Project Slug";

        public override CommandOptionType OptionType => CommandOptionType.SingleValue;
    }
}