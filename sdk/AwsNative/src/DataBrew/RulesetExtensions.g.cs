// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.DataBrew;

public static partial class RulesetExtensions
{

    extension(Ruleset)
    {
        public static Ruleset New(string @id, global::Pulumi.AwsNative.DataBrew.RulesetArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Ruleset(@id, @args, @options);
        }

        public static Ruleset New(string @id, global::System.Action<global::Pulumi.AwsNative.DataBrew.RulesetArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.DataBrew.RulesetArgs @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new Ruleset(@id, @args, @options);
        }

    }

}
