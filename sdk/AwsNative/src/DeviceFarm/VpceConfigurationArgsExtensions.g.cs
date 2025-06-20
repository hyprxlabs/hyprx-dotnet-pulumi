// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.DeviceFarm;

public static partial class VpceConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs WithServiceDnsName(this global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs @selfRef, global::System.String serviceDnsName)
    {
        @selfRef.ServiceDnsName = serviceDnsName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs WithTags(this global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs WithTags(this global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs WithTags(this global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs WithVpceConfigurationDescription(this global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs @selfRef, global::System.String vpceConfigurationDescription)
    {
        @selfRef.VpceConfigurationDescription = vpceConfigurationDescription;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs WithVpceConfigurationName(this global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs @selfRef, global::System.String vpceConfigurationName)
    {
        @selfRef.VpceConfigurationName = vpceConfigurationName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs WithVpceServiceName(this global::Pulumi.AwsNative.DeviceFarm.VpceConfigurationArgs @selfRef, global::System.String vpceServiceName)
    {
        @selfRef.VpceServiceName = vpceServiceName;
        return @selfRef;
    }

}
