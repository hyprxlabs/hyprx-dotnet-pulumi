// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.LakeFormation.Inputs;

namespace Pulumi.AwsNative.LakeFormation;

public static partial class TagAssociationDatabaseResourceArgsExtensions
{
    public static global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationDatabaseResourceArgs WithCatalogId(this global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationDatabaseResourceArgs @selfRef, global::System.String catalogId)
    {
        @selfRef.CatalogId = catalogId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationDatabaseResourceArgs WithName(this global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationDatabaseResourceArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
