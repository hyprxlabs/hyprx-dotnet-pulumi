// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Aad.Inputs;

namespace Pulumi.AzureNative.Aad;

public static partial class ConfigDiagnosticsValidatorResultIssueArgsExtensions
{
    public static global::Pulumi.AzureNative.Aad.Inputs.ConfigDiagnosticsValidatorResultIssueArgs WithDescriptionParams(this global::Pulumi.AzureNative.Aad.Inputs.ConfigDiagnosticsValidatorResultIssueArgs @selfRef, global::System.Collections.Generic.List<global::System.String> descriptionParams)
    {
        @selfRef.DescriptionParams = descriptionParams;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.Inputs.ConfigDiagnosticsValidatorResultIssueArgs WithDescriptionParams(this global::Pulumi.AzureNative.Aad.Inputs.ConfigDiagnosticsValidatorResultIssueArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DescriptionParams = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.Inputs.ConfigDiagnosticsValidatorResultIssueArgs WithDescriptionParams(this global::Pulumi.AzureNative.Aad.Inputs.ConfigDiagnosticsValidatorResultIssueArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DescriptionParams = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Aad.Inputs.ConfigDiagnosticsValidatorResultIssueArgs WithId(this global::Pulumi.AzureNative.Aad.Inputs.ConfigDiagnosticsValidatorResultIssueArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

}
