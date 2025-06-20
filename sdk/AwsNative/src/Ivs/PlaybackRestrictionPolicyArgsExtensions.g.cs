// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ivs;

public static partial class PlaybackRestrictionPolicyArgsExtensions
{
    public static global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs WithAllowedCountries(this global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowedCountries)
    {
        @selfRef.AllowedCountries = allowedCountries;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs WithAllowedCountries(this global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowedCountries = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs WithAllowedCountries(this global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowedCountries = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs WithAllowedOrigins(this global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowedOrigins)
    {
        @selfRef.AllowedOrigins = allowedOrigins;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs WithAllowedOrigins(this global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowedOrigins = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs WithAllowedOrigins(this global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowedOrigins = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs WithEnableStrictOriginEnforcement(this global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs @selfRef, bool enableStrictOriginEnforcement = true)
    {
        @selfRef.EnableStrictOriginEnforcement = enableStrictOriginEnforcement;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs WithName(this global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs WithTags(this global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs WithTags(this global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs WithTags(this global::Pulumi.AwsNative.Ivs.PlaybackRestrictionPolicyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
