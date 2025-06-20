// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DataMigration;

public static partial class DatabaseMigrationsMongoToCosmosDbRUMongoArgsExtensions
{
    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithCollectionList(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataMigration.Inputs.MongoMigrationCollectionArgs> collectionList)
    {
        @selfRef.CollectionList = collectionList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithCollectionList(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataMigration.Inputs.MongoMigrationCollectionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataMigration.Inputs.MongoMigrationCollectionArgs>();
        @configure(@list);
        @selfRef.CollectionList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithCollectionList(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataMigration.Inputs.MongoMigrationCollectionArgs>> @create)
    {
        @selfRef.CollectionList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithKind(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithMigrationName(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.String migrationName)
    {
        @selfRef.MigrationName = migrationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithMigrationOperationId(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.String migrationOperationId)
    {
        @selfRef.MigrationOperationId = migrationOperationId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithMigrationService(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.String migrationService)
    {
        @selfRef.MigrationService = migrationService;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithProvisioningError(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.String provisioningError)
    {
        @selfRef.ProvisioningError = provisioningError;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithResourceGroupName(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithScope(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.String scope)
    {
        @selfRef.Scope = scope;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithSourceMongoConnection(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs sourceMongoConnection)
    {
        @selfRef.SourceMongoConnection = sourceMongoConnection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithSourceMongoConnection(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs();
        @configure(@item);
        @selfRef.SourceMongoConnection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithTargetMongoConnection(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs targetMongoConnection)
    {
        @selfRef.TargetMongoConnection = targetMongoConnection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithTargetMongoConnection(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs();
        @configure(@item);
        @selfRef.TargetMongoConnection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs WithTargetResourceName(this global::Pulumi.AzureNative.DataMigration.DatabaseMigrationsMongoToCosmosDbRUMongoArgs @selfRef, global::System.String targetResourceName)
    {
        @selfRef.TargetResourceName = targetResourceName;
        return @selfRef;
    }

}
