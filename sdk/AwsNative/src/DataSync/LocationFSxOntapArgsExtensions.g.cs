// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.DataSync;

public static partial class LocationFSxOntapArgsExtensions
{
    public static global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs WithProtocol(this global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs @selfRef, global::Pulumi.AwsNative.DataSync.Inputs.LocationFSxOntapProtocolArgs protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs WithProtocol(this global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.Inputs.LocationFSxOntapProtocolArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DataSync.Inputs.LocationFSxOntapProtocolArgs();
        @configure(@item);
        @selfRef.Protocol = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs WithSecurityGroupArns(this global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs @selfRef, global::System.Collections.Generic.List<global::System.String> securityGroupArns)
    {
        @selfRef.SecurityGroupArns = securityGroupArns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs WithSecurityGroupArns(this global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SecurityGroupArns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs WithSecurityGroupArns(this global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SecurityGroupArns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs WithStorageVirtualMachineArn(this global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs @selfRef, global::System.String storageVirtualMachineArn)
    {
        @selfRef.StorageVirtualMachineArn = storageVirtualMachineArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs WithSubdirectory(this global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs @selfRef, global::System.String subdirectory)
    {
        @selfRef.Subdirectory = subdirectory;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs WithTags(this global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs WithTags(this global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs WithTags(this global::Pulumi.AwsNative.DataSync.LocationFSxOntapArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
