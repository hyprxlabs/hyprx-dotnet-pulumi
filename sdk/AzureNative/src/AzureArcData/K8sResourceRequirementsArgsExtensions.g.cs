// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureArcData.Inputs;

namespace Pulumi.AzureNative.AzureArcData;

public static partial class K8sResourceRequirementsArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs WithLimits(this global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> limits)
    {
        @selfRef.Limits = limits;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs WithLimits(this global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Limits = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs WithLimits(this global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Limits = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs WithRequests(this global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> requests)
    {
        @selfRef.Requests = requests;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs WithRequests(this global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Requests = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs WithRequests(this global::Pulumi.AzureNative.AzureArcData.Inputs.K8sResourceRequirementsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Requests = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
