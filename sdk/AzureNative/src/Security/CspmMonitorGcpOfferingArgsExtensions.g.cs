// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Security.Inputs;

namespace Pulumi.AzureNative.Security;

public static partial class CspmMonitorGcpOfferingArgsExtensions
{
    public static global::Pulumi.AzureNative.Security.Inputs.CspmMonitorGcpOfferingArgs WithNativeCloudConnection(this global::Pulumi.AzureNative.Security.Inputs.CspmMonitorGcpOfferingArgs @selfRef, global::Pulumi.AzureNative.Security.Inputs.CspmMonitorGcpOfferingNativeCloudConnectionArgs nativeCloudConnection)
    {
        @selfRef.NativeCloudConnection = nativeCloudConnection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.CspmMonitorGcpOfferingArgs WithNativeCloudConnection(this global::Pulumi.AzureNative.Security.Inputs.CspmMonitorGcpOfferingArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Security.Inputs.CspmMonitorGcpOfferingNativeCloudConnectionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Security.Inputs.CspmMonitorGcpOfferingNativeCloudConnectionArgs();
        @configure(@item);
        @selfRef.NativeCloudConnection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.CspmMonitorGcpOfferingArgs WithOfferingType(this global::Pulumi.AzureNative.Security.Inputs.CspmMonitorGcpOfferingArgs @selfRef, global::System.String offeringType)
    {
        @selfRef.OfferingType = offeringType;
        return @selfRef;
    }

}
