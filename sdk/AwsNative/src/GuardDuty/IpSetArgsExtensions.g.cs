// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.GuardDuty;

public static partial class IpSetArgsExtensions
{
    public static global::Pulumi.AwsNative.GuardDuty.IpSetArgs WithActivate(this global::Pulumi.AwsNative.GuardDuty.IpSetArgs @selfRef, bool activate = true)
    {
        @selfRef.Activate = activate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GuardDuty.IpSetArgs WithDetectorId(this global::Pulumi.AwsNative.GuardDuty.IpSetArgs @selfRef, global::System.String detectorId)
    {
        @selfRef.DetectorId = detectorId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GuardDuty.IpSetArgs WithFormat(this global::Pulumi.AwsNative.GuardDuty.IpSetArgs @selfRef, global::System.String format)
    {
        @selfRef.Format = format;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GuardDuty.IpSetArgs WithLocation(this global::Pulumi.AwsNative.GuardDuty.IpSetArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GuardDuty.IpSetArgs WithName(this global::Pulumi.AwsNative.GuardDuty.IpSetArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GuardDuty.IpSetArgs WithTags(this global::Pulumi.AwsNative.GuardDuty.IpSetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GuardDuty.IpSetArgs WithTags(this global::Pulumi.AwsNative.GuardDuty.IpSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GuardDuty.IpSetArgs WithTags(this global::Pulumi.AwsNative.GuardDuty.IpSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
