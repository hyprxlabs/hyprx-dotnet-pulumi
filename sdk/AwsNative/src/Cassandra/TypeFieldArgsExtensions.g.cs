// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Cassandra.Inputs;

namespace Pulumi.AwsNative.Cassandra;

public static partial class TypeFieldArgsExtensions
{
    public static global::Pulumi.AwsNative.Cassandra.Inputs.TypeFieldArgs WithFieldName(this global::Pulumi.AwsNative.Cassandra.Inputs.TypeFieldArgs @selfRef, global::System.String fieldName)
    {
        @selfRef.FieldName = fieldName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Cassandra.Inputs.TypeFieldArgs WithFieldType(this global::Pulumi.AwsNative.Cassandra.Inputs.TypeFieldArgs @selfRef, global::System.String fieldType)
    {
        @selfRef.FieldType = fieldType;
        return @selfRef;
    }

}
