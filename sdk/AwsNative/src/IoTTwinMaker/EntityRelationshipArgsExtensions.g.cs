// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTTwinMaker.Inputs;

namespace Pulumi.AwsNative.IoTTwinMaker;

public static partial class EntityRelationshipArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityRelationshipArgs WithRelationshipType(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityRelationshipArgs @selfRef, global::System.String relationshipType)
    {
        @selfRef.RelationshipType = relationshipType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityRelationshipArgs WithTargetComponentTypeId(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityRelationshipArgs @selfRef, global::System.String targetComponentTypeId)
    {
        @selfRef.TargetComponentTypeId = targetComponentTypeId;
        return @selfRef;
    }

}
