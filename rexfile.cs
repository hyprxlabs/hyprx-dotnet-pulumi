#!/usr/bin/dotnet run
#:package Hyprx.Ansi
#:package Hyprx.Core
#:package Hyprx.Exec
#:package Hyprx.Shell;
#:package Hyprx.Rex.Console
#:property NoWarn SA1516
using Hyprx.Exec;
using static Hyprx.Ansi;
using static Hyprx.RexConsole;
using static Hyprx.Shell;

#pragma warning disable

Task("build", () =>
{
    Run("dotnet build");
});

Task("dev:setup", () =>
{
    Run("dotnet new install xunit.v3.templates");
});

Task("clean", () =>
{
    Run("dotnet clean");
});


Task("add", (ctx) =>
{
    var args = new List<string>(Argv);
    Echo(string.Join(" ", ctx.Args));
    var index = args.IndexOf("--name");
    if (index == -1)
    {
        var shortIndex = args.IndexOf("-n");
        if (shortIndex != -1)
        {
            index = shortIndex;
        }
        else
        {
            Console.WriteLine("Please provide a name using --name or -n");
            return;
        }
    }

    var name = args[index + 1];
    var baseName = $"Hyprx.Pulumi.{name}";

    if (Path.Exists($"./sdk/{name}/src/{baseName}.csproj"))
    {
        Console.WriteLine($"Project {name} already exists");
        return;
    }

    Run($"""
        dotnet new hxlib -n {baseName} -o ./sdk/{name}/src \
        --use-framework-prop Fx --changelog --use-license-path --use-icon-path  --unsafe
    """);

    Run($"""
        dotnet new hxtest -n {baseName}.Tests -o ./sdk/{name}/test \
        --use-framework-prop Fx 
    """);

    Run($"dotnet new sln -n {name} -o ./sdk/{name}");
    Run($"dotnet sln migrate ./sdk/{name}/{name}.sln");
    Run($"rm ./sdk/{name}/{name}.sln");

    Run($"dotnet sln . add ./sdk/{name}/src");
    Run($"dotnet sln . add ./sdk/{name}/test");
    Run($"dotnet sln ./sdk/{name}/{name}.slnx add ./sdk/{name}/src");
    Run($"dotnet sln ./sdk/{name}/{name}.slnx add ./sdk/{name}/test");
});



Task("rm", (ctx) =>
{
    var args = new List<string>(Argv);
    Echo(string.Join(" ", ctx.Args));
    var index = args.IndexOf("--name");
    if (index == -1)
    {
        Console.WriteLine("Please provide a name using --name");
        return;
    }

    var delete = args.IndexOf("--delete") > -1;

    var name = args[index + 1];
    var baseName = $"Hyprx.{name}";

    Run($"dotnet sln . remove ./{name}/src");
    Run($"dotnet sln . remove ./{name}/test");

    Run($"dotnet sln ./{name}/{baseName}.sln remove ./src");
    Run($"dotnet sln ./{name}/{baseName}.sln remove ./test");

    if (delete)
    {
        Fs.RemoveDir($"./{name}", true);
    }
});


Task("code", () =>
{
    var index = Argv.IndexOf("--name");
    if (index == -1)
    {
        index = Argv.IndexOf("-n");
    }

    if (index == -1)
    {
        Console.WriteLine("Please specify a project to open");
        return;
    }
    var dir = Argv[index + 1];

    var cwd = Directory.GetCurrentDirectory();
    var gi = Path.Combine(cwd, ".git");
    while (gi is not null && !Directory.Exists(gi))
    {
        cwd = Path.GetDirectoryName(cwd)!;
        gi = Path.Combine(cwd, ".git");
    }

    if (string.IsNullOrEmpty(gi))
    {
        Console.WriteLine("Unable to find root project directory");
        return;
    }

    

    dir = Path.Combine(cwd, "sdk", dir);
    Echo($"Opening {Blue(dir)}");
    Run($"code {dir}");
});

var ec = await RunTasksAsync(args);
return ec;