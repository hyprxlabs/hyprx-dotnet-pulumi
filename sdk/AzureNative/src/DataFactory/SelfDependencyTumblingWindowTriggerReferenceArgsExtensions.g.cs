// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class SelfDependencyTumblingWindowTriggerReferenceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.SelfDependencyTumblingWindowTriggerReferenceArgs WithOffset(this global::Pulumi.AzureNative.DataFactory.Inputs.SelfDependencyTumblingWindowTriggerReferenceArgs @selfRef, global::System.String offset)
    {
        @selfRef.Offset = offset;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SelfDependencyTumblingWindowTriggerReferenceArgs WithSize(this global::Pulumi.AzureNative.DataFactory.Inputs.SelfDependencyTumblingWindowTriggerReferenceArgs @selfRef, global::System.String size)
    {
        @selfRef.Size = size;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SelfDependencyTumblingWindowTriggerReferenceArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.SelfDependencyTumblingWindowTriggerReferenceArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
