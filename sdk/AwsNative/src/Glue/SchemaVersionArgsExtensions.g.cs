// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Glue.Inputs;

namespace Pulumi.AwsNative.Glue;

public static partial class SchemaVersionArgsExtensions
{
    public static global::Pulumi.AwsNative.Glue.Inputs.SchemaVersionArgs WithIsLatest(this global::Pulumi.AwsNative.Glue.Inputs.SchemaVersionArgs @selfRef, bool isLatest = true)
    {
        @selfRef.IsLatest = isLatest;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Glue.Inputs.SchemaVersionArgs WithVersionNumber(this global::Pulumi.AwsNative.Glue.Inputs.SchemaVersionArgs @selfRef, global::System.Int32 versionNumber)
    {
        @selfRef.VersionNumber = versionNumber;
        return @selfRef;
    }

}
