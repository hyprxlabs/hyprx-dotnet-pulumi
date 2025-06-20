// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WaFv2.Inputs;

namespace Pulumi.AwsNative.WaFv2;

public static partial class LoggingFilterPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.Inputs.LoggingFilterPropertiesArgs WithDefaultBehavior(this global::Pulumi.AwsNative.WaFv2.Inputs.LoggingFilterPropertiesArgs @selfRef, global::Pulumi.AwsNative.WaFv2.LoggingConfigurationLoggingFilterPropertiesDefaultBehavior defaultBehavior)
    {
        @selfRef.DefaultBehavior = defaultBehavior;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.LoggingFilterPropertiesArgs WithDefaultBehavior(this global::Pulumi.AwsNative.WaFv2.Inputs.LoggingFilterPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.LoggingConfigurationLoggingFilterPropertiesDefaultBehavior> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.WaFv2.LoggingConfigurationLoggingFilterPropertiesDefaultBehavior>();
        @configure(@item);
        @selfRef.DefaultBehavior = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.LoggingFilterPropertiesArgs WithFilters(this global::Pulumi.AwsNative.WaFv2.Inputs.LoggingFilterPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.LoggingConfigurationFilterArgs> filters)
    {
        @selfRef.Filters = filters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.LoggingFilterPropertiesArgs WithFilters(this global::Pulumi.AwsNative.WaFv2.Inputs.LoggingFilterPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.LoggingConfigurationFilterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.LoggingConfigurationFilterArgs>();
        @configure(@list);
        @selfRef.Filters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.LoggingFilterPropertiesArgs WithFilters(this global::Pulumi.AwsNative.WaFv2.Inputs.LoggingFilterPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.WaFv2.Inputs.LoggingConfigurationFilterArgs>> @create)
    {
        @selfRef.Filters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
