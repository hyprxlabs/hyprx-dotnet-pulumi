// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Storage.Inputs;

namespace Pulumi.AzureNative.Storage;

public static partial class TagFilterArgsExtensions
{
    public static global::Pulumi.AzureNative.Storage.Inputs.TagFilterArgs WithName(this global::Pulumi.AzureNative.Storage.Inputs.TagFilterArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.TagFilterArgs WithOp(this global::Pulumi.AzureNative.Storage.Inputs.TagFilterArgs @selfRef, global::System.String op)
    {
        @selfRef.Op = op;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.TagFilterArgs WithValue(this global::Pulumi.AzureNative.Storage.Inputs.TagFilterArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
