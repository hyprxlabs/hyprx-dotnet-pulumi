// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class SqlVmSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.SqlVmSettingsArgs WithInstanceSeries(this global::Pulumi.AzureNative.Migrate.Inputs.SqlVmSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureVmFamily>> instanceSeries)
    {
        @selfRef.InstanceSeries = instanceSeries;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.SqlVmSettingsArgs WithInstanceSeries(this global::Pulumi.AzureNative.Migrate.Inputs.SqlVmSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureVmFamily>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureVmFamily>>();
        @configure(@list);
        @selfRef.InstanceSeries = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.SqlVmSettingsArgs WithInstanceSeries(this global::Pulumi.AzureNative.Migrate.Inputs.SqlVmSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.AzureVmFamily>>> @create)
    {
        @selfRef.InstanceSeries = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
