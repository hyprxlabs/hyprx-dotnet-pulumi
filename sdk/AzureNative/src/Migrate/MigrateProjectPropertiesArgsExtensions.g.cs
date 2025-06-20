// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class MigrateProjectPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs WithProvisioningState(this global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.ProvisioningState> provisioningState)
    {
        @selfRef.ProvisioningState = provisioningState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs WithPublicNetworkAccess(this global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs @selfRef, global::System.String publicNetworkAccess)
    {
        @selfRef.PublicNetworkAccess = publicNetworkAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs WithRegisteredTools(this global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> registeredTools)
    {
        @selfRef.RegisteredTools = registeredTools;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs WithRegisteredTools(this global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.RegisteredTools = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs WithRegisteredTools(this global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.RegisteredTools = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs WithServiceEndpoint(this global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs @selfRef, global::System.String serviceEndpoint)
    {
        @selfRef.ServiceEndpoint = serviceEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs WithUtilityStorageAccountId(this global::Pulumi.AzureNative.Migrate.Inputs.MigrateProjectPropertiesArgs @selfRef, global::System.String utilityStorageAccountId)
    {
        @selfRef.UtilityStorageAccountId = utilityStorageAccountId;
        return @selfRef;
    }

}
