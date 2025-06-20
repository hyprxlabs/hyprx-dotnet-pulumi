// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Lightsail;

public static partial class InstanceArgsExtensions
{
    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithAddOns(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lightsail.Inputs.InstanceAddOnArgs> addOns)
    {
        @selfRef.AddOns = addOns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithAddOns(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lightsail.Inputs.InstanceAddOnArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Lightsail.Inputs.InstanceAddOnArgs>();
        @configure(@list);
        @selfRef.AddOns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithAddOns(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Lightsail.Inputs.InstanceAddOnArgs>> @create)
    {
        @selfRef.AddOns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithAvailabilityZone(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.String availabilityZone)
    {
        @selfRef.AvailabilityZone = availabilityZone;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithBlueprintId(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.String blueprintId)
    {
        @selfRef.BlueprintId = blueprintId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithBundleId(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.String bundleId)
    {
        @selfRef.BundleId = bundleId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithHardware(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::Pulumi.AwsNative.Lightsail.Inputs.InstanceHardwareArgs hardware)
    {
        @selfRef.Hardware = hardware;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithHardware(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lightsail.Inputs.InstanceHardwareArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lightsail.Inputs.InstanceHardwareArgs();
        @configure(@item);
        @selfRef.Hardware = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithInstanceName(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.String instanceName)
    {
        @selfRef.InstanceName = instanceName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithKeyPairName(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.String keyPairName)
    {
        @selfRef.KeyPairName = keyPairName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithLocation(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::Pulumi.AwsNative.Lightsail.Inputs.InstanceLocationArgs location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithLocation(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lightsail.Inputs.InstanceLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lightsail.Inputs.InstanceLocationArgs();
        @configure(@item);
        @selfRef.Location = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithNetworking(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs networking)
    {
        @selfRef.Networking = networking;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithNetworking(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lightsail.Inputs.InstanceNetworkingArgs();
        @configure(@item);
        @selfRef.Networking = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithState(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::Pulumi.AwsNative.Lightsail.Inputs.InstanceStateArgs state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithState(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lightsail.Inputs.InstanceStateArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lightsail.Inputs.InstanceStateArgs();
        @configure(@item);
        @selfRef.State = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithTags(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithTags(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithTags(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.InstanceArgs WithUserData(this global::Pulumi.AwsNative.Lightsail.InstanceArgs @selfRef, global::System.String userData)
    {
        @selfRef.UserData = userData;
        return @selfRef;
    }

}
