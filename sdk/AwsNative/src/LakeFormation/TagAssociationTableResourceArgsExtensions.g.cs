// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.LakeFormation.Inputs;

namespace Pulumi.AwsNative.LakeFormation;

public static partial class TagAssociationTableResourceArgsExtensions
{
    public static global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableResourceArgs WithCatalogId(this global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableResourceArgs @selfRef, global::System.String catalogId)
    {
        @selfRef.CatalogId = catalogId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableResourceArgs WithDatabaseName(this global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableResourceArgs @selfRef, global::System.String databaseName)
    {
        @selfRef.DatabaseName = databaseName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableResourceArgs WithName(this global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableResourceArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableResourceArgs WithTableWildcard(this global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableResourceArgs @selfRef, global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableWildcardArgs tableWildcard)
    {
        @selfRef.TableWildcard = tableWildcard;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableResourceArgs WithTableWildcard(this global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableResourceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableWildcardArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.LakeFormation.Inputs.TagAssociationTableWildcardArgs();
        @configure(@item);
        @selfRef.TableWildcard = @item;
        return @selfRef;
    }

}
