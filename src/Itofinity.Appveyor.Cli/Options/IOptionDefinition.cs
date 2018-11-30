using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Appveyor.Cli.Options
{
    public interface IOptionDefinition
    {
        string Template { get; }
        string Description { get; }
        CommandOptionType OptionType { get; }
    }
}