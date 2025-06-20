// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.AppConfig;

public static partial class EnvironmentArgsExtensions
{
    public static global::Pulumi.AwsNative.AppConfig.EnvironmentArgs WithApplicationId(this global::Pulumi.AwsNative.AppConfig.EnvironmentArgs @selfRef, global::System.String applicationId)
    {
        @selfRef.ApplicationId = applicationId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.EnvironmentArgs WithDeletionProtectionCheck(this global::Pulumi.AwsNative.AppConfig.EnvironmentArgs @selfRef, global::Pulumi.AwsNative.AppConfig.EnvironmentDeletionProtectionCheck deletionProtectionCheck)
    {
        @selfRef.DeletionProtectionCheck = deletionProtectionCheck;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.EnvironmentArgs WithDeletionProtectionCheck(this global::Pulumi.AwsNative.AppConfig.EnvironmentArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppConfig.EnvironmentDeletionProtectionCheck> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.AppConfig.EnvironmentDeletionProtectionCheck>();
        @configure(@item);
        @selfRef.DeletionProtectionCheck = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.EnvironmentArgs WithDescription(this global::Pulumi.AwsNative.AppConfig.EnvironmentArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.EnvironmentArgs WithMonitors(this global::Pulumi.AwsNative.AppConfig.EnvironmentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppConfig.Inputs.EnvironmentMonitorArgs> monitors)
    {
        @selfRef.Monitors = monitors;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.EnvironmentArgs WithMonitors(this global::Pulumi.AwsNative.AppConfig.EnvironmentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppConfig.Inputs.EnvironmentMonitorArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppConfig.Inputs.EnvironmentMonitorArgs>();
        @configure(@list);
        @selfRef.Monitors = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.EnvironmentArgs WithMonitors(this global::Pulumi.AwsNative.AppConfig.EnvironmentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.AppConfig.Inputs.EnvironmentMonitorArgs>> @create)
    {
        @selfRef.Monitors = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.EnvironmentArgs WithName(this global::Pulumi.AwsNative.AppConfig.EnvironmentArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.EnvironmentArgs WithTags(this global::Pulumi.AwsNative.AppConfig.EnvironmentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.EnvironmentArgs WithTags(this global::Pulumi.AwsNative.AppConfig.EnvironmentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.EnvironmentArgs WithTags(this global::Pulumi.AwsNative.AppConfig.EnvironmentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
