// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Rum;

public static partial class AppMonitorArgsExtensions
{
    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithAppMonitorConfiguration(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::Pulumi.AwsNative.Rum.Inputs.AppMonitorConfigurationArgs appMonitorConfiguration)
    {
        @selfRef.AppMonitorConfiguration = appMonitorConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithAppMonitorConfiguration(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rum.Inputs.AppMonitorConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rum.Inputs.AppMonitorConfigurationArgs();
        @configure(@item);
        @selfRef.AppMonitorConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithCustomEvents(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::Pulumi.AwsNative.Rum.Inputs.AppMonitorCustomEventsArgs customEvents)
    {
        @selfRef.CustomEvents = customEvents;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithCustomEvents(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rum.Inputs.AppMonitorCustomEventsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rum.Inputs.AppMonitorCustomEventsArgs();
        @configure(@item);
        @selfRef.CustomEvents = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithCwLogEnabled(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, bool cwLogEnabled = true)
    {
        @selfRef.CwLogEnabled = cwLogEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithDeobfuscationConfiguration(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::Pulumi.AwsNative.Rum.Inputs.AppMonitorDeobfuscationConfigurationArgs deobfuscationConfiguration)
    {
        @selfRef.DeobfuscationConfiguration = deobfuscationConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithDeobfuscationConfiguration(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rum.Inputs.AppMonitorDeobfuscationConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rum.Inputs.AppMonitorDeobfuscationConfigurationArgs();
        @configure(@item);
        @selfRef.DeobfuscationConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithDomain(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.String domain)
    {
        @selfRef.Domain = domain;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithDomainList(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.Collections.Generic.List<global::System.String> domainList)
    {
        @selfRef.DomainList = domainList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithDomainList(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DomainList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithDomainList(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DomainList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithName(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithResourcePolicy(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::Pulumi.AwsNative.Rum.Inputs.AppMonitorResourcePolicyArgs resourcePolicy)
    {
        @selfRef.ResourcePolicy = resourcePolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithResourcePolicy(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rum.Inputs.AppMonitorResourcePolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rum.Inputs.AppMonitorResourcePolicyArgs();
        @configure(@item);
        @selfRef.ResourcePolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithTags(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithTags(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.AppMonitorArgs WithTags(this global::Pulumi.AwsNative.Rum.AppMonitorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
