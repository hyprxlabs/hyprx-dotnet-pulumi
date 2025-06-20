namespace PulumiGen;

public static class Commands
{
    public static async Task<int> HandleGenerateCommand(string[] args)
    {
        if (args.Length != 1)
        {
            global::System.Console.WriteLine("Usage: PulumiGen <shortName>");
            global::System.Console.WriteLine("Example: PulumiGen AzureNative");
            global::System.Console.WriteLine();
            global::System.Console.WriteLine("Available providers:");
            global::System.Console.WriteLine("  - Acme");
            global::System.Console.WriteLine("  - AzureNative");
            global::System.Console.WriteLine("  - AzureAd");
            global::System.Console.WriteLine("  - AzureDevOps");
            global::System.Console.WriteLine("  - Cloudflare");
            global::System.Console.WriteLine("  - Command");
            global::System.Console.WriteLine("  - DigitalOcean");
            global::System.Console.WriteLine("  - Docker");
            global::System.Console.WriteLine("  - Github");
            global::System.Console.WriteLine("  - Libvirt");
            global::System.Console.WriteLine("  - ProxmoxVE");
            global::System.Console.WriteLine("  - Random");
            global::System.Console.WriteLine("  - Slack");
            global::System.Console.WriteLine("  - TlsSelfSignedCert");
            global::System.Console.WriteLine("  - Unfi");
            global::System.Console.WriteLine("  - Vault");
            return 1;
        }

        string shortName = args[0];

        try
        {
            var generator = new CodeGenerator();
            await generator.GenerateAsync(shortName);
            global::System.Console.WriteLine($"✅ Code generation completed successfully for {shortName}");
            return 0;
        }
        catch (Exception ex)
        {
            global::System.Console.WriteLine($"❌ Error: {ex.Message}");
            if (ex.InnerException != null)
            {
                global::System.Console.WriteLine($"   Inner exception: {ex.InnerException.Message}");
            }

            return 1;
        }
    }
}