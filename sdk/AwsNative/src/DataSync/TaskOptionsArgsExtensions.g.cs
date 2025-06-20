// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DataSync.Inputs;

namespace Pulumi.AwsNative.DataSync;

public static partial class TaskOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithAtime(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsAtime atime)
    {
        @selfRef.Atime = atime;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithAtime(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsAtime> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsAtime>();
        @configure(@item);
        @selfRef.Atime = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithBytesPerSecond(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Int32 bytesPerSecond)
    {
        @selfRef.BytesPerSecond = bytesPerSecond;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithGid(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsGid gid)
    {
        @selfRef.Gid = gid;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithGid(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsGid> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsGid>();
        @configure(@item);
        @selfRef.Gid = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithLogLevel(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsLogLevel logLevel)
    {
        @selfRef.LogLevel = logLevel;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithLogLevel(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsLogLevel> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsLogLevel>();
        @configure(@item);
        @selfRef.LogLevel = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithMtime(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsMtime mtime)
    {
        @selfRef.Mtime = mtime;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithMtime(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsMtime> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsMtime>();
        @configure(@item);
        @selfRef.Mtime = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithObjectTags(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsObjectTags objectTags)
    {
        @selfRef.ObjectTags = objectTags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithObjectTags(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsObjectTags> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsObjectTags>();
        @configure(@item);
        @selfRef.ObjectTags = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithOverwriteMode(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsOverwriteMode overwriteMode)
    {
        @selfRef.OverwriteMode = overwriteMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithOverwriteMode(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsOverwriteMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsOverwriteMode>();
        @configure(@item);
        @selfRef.OverwriteMode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithPosixPermissions(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsPosixPermissions posixPermissions)
    {
        @selfRef.PosixPermissions = posixPermissions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithPosixPermissions(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsPosixPermissions> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsPosixPermissions>();
        @configure(@item);
        @selfRef.PosixPermissions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithPreserveDeletedFiles(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsPreserveDeletedFiles preserveDeletedFiles)
    {
        @selfRef.PreserveDeletedFiles = preserveDeletedFiles;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithPreserveDeletedFiles(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsPreserveDeletedFiles> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsPreserveDeletedFiles>();
        @configure(@item);
        @selfRef.PreserveDeletedFiles = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithPreserveDevices(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsPreserveDevices preserveDevices)
    {
        @selfRef.PreserveDevices = preserveDevices;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithPreserveDevices(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsPreserveDevices> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsPreserveDevices>();
        @configure(@item);
        @selfRef.PreserveDevices = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithSecurityDescriptorCopyFlags(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsSecurityDescriptorCopyFlags securityDescriptorCopyFlags)
    {
        @selfRef.SecurityDescriptorCopyFlags = securityDescriptorCopyFlags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithSecurityDescriptorCopyFlags(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsSecurityDescriptorCopyFlags> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsSecurityDescriptorCopyFlags>();
        @configure(@item);
        @selfRef.SecurityDescriptorCopyFlags = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithTaskQueueing(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsTaskQueueing taskQueueing)
    {
        @selfRef.TaskQueueing = taskQueueing;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithTaskQueueing(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsTaskQueueing> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsTaskQueueing>();
        @configure(@item);
        @selfRef.TaskQueueing = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithTransferMode(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsTransferMode transferMode)
    {
        @selfRef.TransferMode = transferMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithTransferMode(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsTransferMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsTransferMode>();
        @configure(@item);
        @selfRef.TransferMode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithUid(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsUid uid)
    {
        @selfRef.Uid = uid;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithUid(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsUid> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsUid>();
        @configure(@item);
        @selfRef.Uid = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithVerifyMode(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::Pulumi.AwsNative.DataSync.TaskOptionsVerifyMode verifyMode)
    {
        @selfRef.VerifyMode = verifyMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs WithVerifyMode(this global::Pulumi.AwsNative.DataSync.Inputs.TaskOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataSync.TaskOptionsVerifyMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.DataSync.TaskOptionsVerifyMode>();
        @configure(@item);
        @selfRef.VerifyMode = @item;
        return @selfRef;
    }

}
