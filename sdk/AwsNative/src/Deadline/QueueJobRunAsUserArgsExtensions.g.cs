// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Deadline.Inputs;

namespace Pulumi.AwsNative.Deadline;

public static partial class QueueJobRunAsUserArgsExtensions
{
    public static global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs WithPosix(this global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs @selfRef, global::Pulumi.AwsNative.Deadline.Inputs.QueuePosixUserArgs posix)
    {
        @selfRef.Posix = posix;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs WithPosix(this global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Deadline.Inputs.QueuePosixUserArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Deadline.Inputs.QueuePosixUserArgs();
        @configure(@item);
        @selfRef.Posix = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs WithRunAs(this global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs @selfRef, global::Pulumi.AwsNative.Deadline.QueueRunAs runAs)
    {
        @selfRef.RunAs = runAs;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs WithRunAs(this global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Deadline.QueueRunAs> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Deadline.QueueRunAs>();
        @configure(@item);
        @selfRef.RunAs = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs WithWindows(this global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs @selfRef, global::Pulumi.AwsNative.Deadline.Inputs.QueueWindowsUserArgs windows)
    {
        @selfRef.Windows = windows;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs WithWindows(this global::Pulumi.AwsNative.Deadline.Inputs.QueueJobRunAsUserArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Deadline.Inputs.QueueWindowsUserArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Deadline.Inputs.QueueWindowsUserArgs();
        @configure(@item);
        @selfRef.Windows = @item;
        return @selfRef;
    }

}
