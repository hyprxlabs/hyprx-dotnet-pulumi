// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Deadline.Inputs;

namespace Pulumi.AwsNative.Deadline;

public static partial class StorageProfileFileSystemLocationArgsExtensions
{
    public static global::Pulumi.AwsNative.Deadline.Inputs.StorageProfileFileSystemLocationArgs WithName(this global::Pulumi.AwsNative.Deadline.Inputs.StorageProfileFileSystemLocationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Deadline.Inputs.StorageProfileFileSystemLocationArgs WithPath(this global::Pulumi.AwsNative.Deadline.Inputs.StorageProfileFileSystemLocationArgs @selfRef, global::System.String path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Deadline.Inputs.StorageProfileFileSystemLocationArgs WithType(this global::Pulumi.AwsNative.Deadline.Inputs.StorageProfileFileSystemLocationArgs @selfRef, global::Pulumi.AwsNative.Deadline.StorageProfileFileSystemLocationType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Deadline.Inputs.StorageProfileFileSystemLocationArgs WithType(this global::Pulumi.AwsNative.Deadline.Inputs.StorageProfileFileSystemLocationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Deadline.StorageProfileFileSystemLocationType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Deadline.StorageProfileFileSystemLocationType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
