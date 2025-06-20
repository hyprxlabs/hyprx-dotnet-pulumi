// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ImageBuilder.Inputs;

namespace Pulumi.AwsNative.ImageBuilder;

public static partial class LifecyclePolicyExclusionRulesArgsExtensions
{
    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyExclusionRulesArgs WithAmis(this global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyExclusionRulesArgs @selfRef, global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyAmiExclusionRulesArgs amis)
    {
        @selfRef.Amis = amis;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyExclusionRulesArgs WithAmis(this global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyExclusionRulesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyAmiExclusionRulesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyAmiExclusionRulesArgs();
        @configure(@item);
        @selfRef.Amis = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyExclusionRulesArgs WithTagMap(this global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyExclusionRulesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tagMap)
    {
        @selfRef.TagMap = tagMap;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyExclusionRulesArgs WithTagMap(this global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyExclusionRulesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.TagMap = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyExclusionRulesArgs WithTagMap(this global::Pulumi.AwsNative.ImageBuilder.Inputs.LifecyclePolicyExclusionRulesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.TagMap = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
