// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.OpenSearchServerless.Inputs;

namespace Pulumi.AwsNative.OpenSearchServerless;

public static partial class MappingsPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.OpenSearchServerless.Inputs.MappingsPropertiesArgs WithProperties(this global::Pulumi.AwsNative.OpenSearchServerless.Inputs.MappingsPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AwsNative.OpenSearchServerless.Inputs.IndexPropertyMappingArgs> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchServerless.Inputs.MappingsPropertiesArgs WithProperties(this global::Pulumi.AwsNative.OpenSearchServerless.Inputs.MappingsPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AwsNative.OpenSearchServerless.Inputs.IndexPropertyMappingArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AwsNative.OpenSearchServerless.Inputs.IndexPropertyMappingArgs>();
        @configure(@dict);
        @selfRef.Properties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchServerless.Inputs.MappingsPropertiesArgs WithProperties(this global::Pulumi.AwsNative.OpenSearchServerless.Inputs.MappingsPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AwsNative.OpenSearchServerless.Inputs.IndexPropertyMappingArgs>> @create)
    {
        @selfRef.Properties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
