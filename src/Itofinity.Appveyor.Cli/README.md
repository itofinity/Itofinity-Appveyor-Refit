## Install
Download the latest release for your platform from https://github.com/itofinity/Itofinity-Appveyor-Refit/releases.

Currently releases for all platforms are in the form of self-contained zips, simply extract the contents to a folder of your choice.

There are _no_ external dependencies.

## Run

### Windows

    >\path\to\install\Itofinity.Appveyor.Cli.exe

### Linux

    >\path\to\install\Itofinity.Appveyor.Cli

### macOS

    >\path\to\install\Itofinity.Appveyor.Cli

Documentation for now refers to the windows .exe version, but it should be simple to adjust.

## Options

The cli is built to be self-explanatory but, its early days, so here are some basics

To access a list of available commands
    
    >Itofinity.Appveyor.Cli.exe --help

To access help on a specific command
    
    >Itofinity.Appveyor.Cli.exe {command} --help

To run a specific command
    
    >Itofinity.Appveyor.Cli.exe {command} -t {apikey} --indent

## Commands

### Porcelain Commands

Porcelain commands are auto-generated from the API client, and return JSON.

Porcelain commands are always available

### Extension Commands

Extension commands potentially provide more nuanced parameters and results, since they can be written to achieve a particular task.

Extension commands are loaded by MEF from the _extensions_ sub-folder.

They are not available if the _extensions_ sub-folder is empty.

_Itofinity.AppVeyor.Cli.Ext_ provides some example extension commands.

### Authentication

The AppVeyor API requires authentication, you need an API Key from https://ci.appveyor.com/api-keys, one that is suitable for the account you are trying to access.

You can provide the key specifically via the token parameter 

    >Itofinity.Appveyor.Cli.exe {command} -t {apikey}

Or predefine it as an environment variable

    >$env:APPVEYOR_API_TOKEN={apikey}
    >Itofinity.Appveyor.Cli.exe {command}

### Common options

    --indent

Json output is raw and un-formattted by default, --indent creates formatted output

    --output

Output is to the calling console by default, --output redirects to the specified file


    --filter

Use _jsonpath_ to extract and output only sub-sections, values etc from the main Json response

 