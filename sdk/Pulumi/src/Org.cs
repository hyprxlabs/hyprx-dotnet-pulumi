

public readonly struct Org
{
    private static readonly HashSet<Org> s_orgs = new HashSet<Org>();

    public Org(string abbr)
    {
        this.Abbr = abbr.ToLowerInvariant();
        this.Name = abbr;
        if (!s_orgs.Any(x => x.Abbr == this.Abbr))
        {
            s_orgs.Add(this);
        }
    }

    public Org(string abbr, string name)
    {
        this.Abbr = abbr.ToLowerInvariant();
        this.Name = name;
        s_orgs.Add(this);
    }

    public string Abbr { get; }

    public string Name { get; }

    public static Org? Default { get; set; }

    public static Org From(string abbr)
    {
        var org = s_orgs.FirstOrDefault(x => x.Abbr == abbr.ToLowerInvariant());
        if (org == default)
        {
            org = new Org(abbr);
            s_orgs.Add(org);
        }

        return org;
    }

    public static Org From(string abbr, string name)
    {
        var org = s_orgs.FirstOrDefault(x => x.Abbr == abbr.ToLowerInvariant());
        if (org == default)
        {
            org = new Org(abbr, name);
            s_orgs.Add(org);
        }

        return org;
    }

    public static IEnumerable<Org> All => s_orgs;

    override public string ToString()
    {
        return this.Abbr;
    }
}