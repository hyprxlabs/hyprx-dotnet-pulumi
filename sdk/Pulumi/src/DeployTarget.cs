
namespace Pulumi;

public readonly struct DeployTarget
{
    public string Name { get; }

    public string Abbr { get; }

    public string Short { get; }

    public string FormattedName { get; }

    public DeployTarget(string formattedName, string name, string abbr, string shortName)
    {
        this.FormattedName = formattedName;
        this.Abbr = abbr;
        this.Short = shortName;
        this.FormattedName = formattedName;
    }

    public DeployTarget(string name, string abbr, string shortName)
    {
        this.FormattedName = name;
        this.Abbr = abbr;
        this.Short = shortName;
        this.Name = name.ToLowerInvariant();
    }

    public DeployTarget(string name, string abbr)
    {
        this.FormattedName = name;
        this.Abbr = abbr;
        this.Short = name.ToLowerInvariant()[0].ToString();
        this.Name = name.ToLowerInvariant();
    }

    public static DeployTarget Default { get; } = Development;

    public static DeployTarget Production { get; } = new("Production", "production", "prod", "p");

    public static DeployTarget Staging { get; } = new("Staging", "staging", "stg", "s");

    public static DeployTarget Testing { get; } = new("Testing", "testing", "test", "t");

    public static DeployTarget Development { get; } = new("Development", "development", "dev", "d");

    public static DeployTarget Local { get; } = new("Local", "local", "loc", "l");

    public static DeployTarget Beta { get; } = new("Beta", "beta", "beta", "b");

    public static DeployTarget Alpha { get; } = new("Alpha", "alpha", "alpha", "a");

    public static DeployTarget Uat { get; } = new("User Acceptance Testing", "user acceptance testing", "uat", "u");

    public static DeployTarget QualityAssurance { get; } = new("Quality Assurance", "quality assurance", "qa", "q");

    public static DeployTarget PenetrationTesting { get; } = new("Penetration Testing", "penetration testing", "pt", "pt");

    public static static implicit operator DeployTarget((string formatted, string name, string abbr, string shortName) tuple)
    {
        return new DeployTarget(tuple.formatted, tuple.name, tuple.abbr, tuple.shortName);
    }

    public static implicit operator DeployTarget((string name, string abbr) tuple)
    {
        return new DeployTarget(tuple.name, tuple.abbr);
    }

    public static implicit operator DeployTarget((string name, string abbr, string shortName) tuple)
    {
        return new DeployTarget(tuple.name, tuple.abbr, tuple.shortName);
    }

    override public string ToString()
    {
        return this.Abbr;
    }
}