// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class DomainFSxLustreFileSystemConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.DomainFSxLustreFileSystemConfigArgs WithFileSystemId(this global::Pulumi.AwsNative.SageMaker.Inputs.DomainFSxLustreFileSystemConfigArgs @selfRef, global::System.String fileSystemId)
    {
        @selfRef.FileSystemId = fileSystemId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DomainFSxLustreFileSystemConfigArgs WithFileSystemPath(this global::Pulumi.AwsNative.SageMaker.Inputs.DomainFSxLustreFileSystemConfigArgs @selfRef, global::System.String fileSystemPath)
    {
        @selfRef.FileSystemPath = fileSystemPath;
        return @selfRef;
    }

}
