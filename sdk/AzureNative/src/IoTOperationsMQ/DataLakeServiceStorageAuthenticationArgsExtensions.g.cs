// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperationsMQ.Inputs;

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class DataLakeServiceStorageAuthenticationArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.DataLakeServiceStorageAuthenticationArgs WithAccessTokenSecretName(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.DataLakeServiceStorageAuthenticationArgs @selfRef, global::System.String accessTokenSecretName)
    {
        @selfRef.AccessTokenSecretName = accessTokenSecretName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.DataLakeServiceStorageAuthenticationArgs WithSystemAssignedManagedIdentity(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.DataLakeServiceStorageAuthenticationArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ManagedIdentityAuthenticationArgs systemAssignedManagedIdentity)
    {
        @selfRef.SystemAssignedManagedIdentity = systemAssignedManagedIdentity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.DataLakeServiceStorageAuthenticationArgs WithSystemAssignedManagedIdentity(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.DataLakeServiceStorageAuthenticationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ManagedIdentityAuthenticationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ManagedIdentityAuthenticationArgs();
        @configure(@item);
        @selfRef.SystemAssignedManagedIdentity = @item;
        return @selfRef;
    }

}
