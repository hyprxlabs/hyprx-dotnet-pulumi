// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.WaFv2;

public static partial class WebAclArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithAssociationConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclAssociationConfigArgs associationConfig)
    {
        @selfRef.AssociationConfig = associationConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithAssociationConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclAssociationConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.WaFv2.Inputs.WebAclAssociationConfigArgs();
        @configure(@item);
        @selfRef.AssociationConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithCaptchaConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclCaptchaConfigArgs captchaConfig)
    {
        @selfRef.CaptchaConfig = captchaConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithCaptchaConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclCaptchaConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.WaFv2.Inputs.WebAclCaptchaConfigArgs();
        @configure(@item);
        @selfRef.CaptchaConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithChallengeConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclChallengeConfigArgs challengeConfig)
    {
        @selfRef.ChallengeConfig = challengeConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithChallengeConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclChallengeConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.WaFv2.Inputs.WebAclChallengeConfigArgs();
        @configure(@item);
        @selfRef.ChallengeConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithCustomResponseBodies(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclCustomResponseBodyArgs> customResponseBodies)
    {
        @selfRef.CustomResponseBodies = customResponseBodies;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithCustomResponseBodies(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclCustomResponseBodyArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclCustomResponseBodyArgs>();
        @configure(@dict);
        @selfRef.CustomResponseBodies = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithCustomResponseBodies(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclCustomResponseBodyArgs>> @create)
    {
        @selfRef.CustomResponseBodies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithDataProtectionConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclDataProtectionConfigArgs dataProtectionConfig)
    {
        @selfRef.DataProtectionConfig = dataProtectionConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithDataProtectionConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclDataProtectionConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.WaFv2.Inputs.WebAclDataProtectionConfigArgs();
        @configure(@item);
        @selfRef.DataProtectionConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithDefaultAction(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclDefaultActionArgs defaultAction)
    {
        @selfRef.DefaultAction = defaultAction;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithDefaultAction(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclDefaultActionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.WaFv2.Inputs.WebAclDefaultActionArgs();
        @configure(@item);
        @selfRef.DefaultAction = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithDescription(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithName(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithOnSourceDDoSProtectionConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclOnSourceDDoSProtectionConfigArgs onSourceDDoSProtectionConfig)
    {
        @selfRef.OnSourceDDoSProtectionConfig = onSourceDDoSProtectionConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithOnSourceDDoSProtectionConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclOnSourceDDoSProtectionConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.WaFv2.Inputs.WebAclOnSourceDDoSProtectionConfigArgs();
        @configure(@item);
        @selfRef.OnSourceDDoSProtectionConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithRules(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclRuleArgs> rules)
    {
        @selfRef.Rules = rules;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithRules(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclRuleArgs>();
        @configure(@list);
        @selfRef.Rules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithRules(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclRuleArgs>> @create)
    {
        @selfRef.Rules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithScope(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::Pulumi.AwsNative.WaFv2.WebAclScope scope)
    {
        @selfRef.Scope = scope;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithScope(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.WebAclScope> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.WaFv2.WebAclScope>();
        @configure(@item);
        @selfRef.Scope = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithTags(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithTags(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithTags(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithTokenDomains(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Collections.Generic.List<global::System.String> tokenDomains)
    {
        @selfRef.TokenDomains = tokenDomains;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithTokenDomains(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.TokenDomains = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithTokenDomains(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.TokenDomains = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithVisibilityConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclVisibilityConfigArgs visibilityConfig)
    {
        @selfRef.VisibilityConfig = visibilityConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.WebAclArgs WithVisibilityConfig(this global::Pulumi.AwsNative.WaFv2.WebAclArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclVisibilityConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.WaFv2.Inputs.WebAclVisibilityConfigArgs();
        @configure(@item);
        @selfRef.VisibilityConfig = @item;
        return @selfRef;
    }

}
