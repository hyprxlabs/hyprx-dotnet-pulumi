// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataProtection.Inputs;

namespace Pulumi.AzureNative.DataProtection;

public static partial class BlobBackupDatasourceParametersArgsExtensions
{
    public static global::Pulumi.AzureNative.DataProtection.Inputs.BlobBackupDatasourceParametersArgs WithContainersList(this global::Pulumi.AzureNative.DataProtection.Inputs.BlobBackupDatasourceParametersArgs @selfRef, global::System.Collections.Generic.List<global::System.String> containersList)
    {
        @selfRef.ContainersList = containersList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataProtection.Inputs.BlobBackupDatasourceParametersArgs WithContainersList(this global::Pulumi.AzureNative.DataProtection.Inputs.BlobBackupDatasourceParametersArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ContainersList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataProtection.Inputs.BlobBackupDatasourceParametersArgs WithContainersList(this global::Pulumi.AzureNative.DataProtection.Inputs.BlobBackupDatasourceParametersArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ContainersList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataProtection.Inputs.BlobBackupDatasourceParametersArgs WithObjectType(this global::Pulumi.AzureNative.DataProtection.Inputs.BlobBackupDatasourceParametersArgs @selfRef, global::System.String objectType)
    {
        @selfRef.ObjectType = objectType;
        return @selfRef;
    }

}
