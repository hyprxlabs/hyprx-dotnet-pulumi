// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Media.Inputs;

namespace Pulumi.AzureNative.Media;

public static partial class JobInputSequenceArgsExtensions
{
    public static global::Pulumi.AzureNative.Media.Inputs.JobInputSequenceArgs WithInputs(this global::Pulumi.AzureNative.Media.Inputs.JobInputSequenceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.JobInputClipArgs> inputs)
    {
        @selfRef.Inputs = inputs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.JobInputSequenceArgs WithInputs(this global::Pulumi.AzureNative.Media.Inputs.JobInputSequenceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.JobInputClipArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.JobInputClipArgs>();
        @configure(@list);
        @selfRef.Inputs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.JobInputSequenceArgs WithInputs(this global::Pulumi.AzureNative.Media.Inputs.JobInputSequenceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Media.Inputs.JobInputClipArgs>> @create)
    {
        @selfRef.Inputs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.JobInputSequenceArgs WithOdataType(this global::Pulumi.AzureNative.Media.Inputs.JobInputSequenceArgs @selfRef, global::System.String odataType)
    {
        @selfRef.OdataType = odataType;
        return @selfRef;
    }

}
