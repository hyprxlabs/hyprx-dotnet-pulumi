// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.DataSync;

public static partial class LocationNfsArgsExtensions
{
    public static global::Pulumi.AwsNative.DataSync.LocationNfsArgs WithMountOptions(this global::Pulumi.AwsNative.DataSync.LocationNfsArgs @selfRef, global::Pulumi.AwsNative.DataSync.Inputs.LocationNfsMountOptionsArgs mountOptions)
    {
        @selfRef.MountOptions = mountOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationNfsArgs WithMountOptions(this global::Pulumi.AwsNative.DataSync.LocationNfsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.Inputs.LocationNfsMountOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DataSync.Inputs.LocationNfsMountOptionsArgs();
        @configure(@item);
        @selfRef.MountOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationNfsArgs WithOnPremConfig(this global::Pulumi.AwsNative.DataSync.LocationNfsArgs @selfRef, global::Pulumi.AwsNative.DataSync.Inputs.LocationNfsOnPremConfigArgs onPremConfig)
    {
        @selfRef.OnPremConfig = onPremConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationNfsArgs WithOnPremConfig(this global::Pulumi.AwsNative.DataSync.LocationNfsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.Inputs.LocationNfsOnPremConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DataSync.Inputs.LocationNfsOnPremConfigArgs();
        @configure(@item);
        @selfRef.OnPremConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationNfsArgs WithServerHostname(this global::Pulumi.AwsNative.DataSync.LocationNfsArgs @selfRef, global::System.String serverHostname)
    {
        @selfRef.ServerHostname = serverHostname;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationNfsArgs WithSubdirectory(this global::Pulumi.AwsNative.DataSync.LocationNfsArgs @selfRef, global::System.String subdirectory)
    {
        @selfRef.Subdirectory = subdirectory;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationNfsArgs WithTags(this global::Pulumi.AwsNative.DataSync.LocationNfsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationNfsArgs WithTags(this global::Pulumi.AwsNative.DataSync.LocationNfsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationNfsArgs WithTags(this global::Pulumi.AwsNative.DataSync.LocationNfsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
