// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataMigration.Inputs;

namespace Pulumi.AzureNative.DataMigration;

public static partial class MongoConnectionInformationArgsExtensions
{
    public static global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs WithConnectionString(this global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs @selfRef, global::System.String connectionString)
    {
        @selfRef.ConnectionString = connectionString;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs WithHost(this global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs @selfRef, global::System.String host)
    {
        @selfRef.Host = host;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs WithPassword(this global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs @selfRef, global::System.String password)
    {
        @selfRef.Password = password;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs WithPort(this global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs @selfRef, global::System.Int32 port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs WithUseSsl(this global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs @selfRef, bool useSsl = true)
    {
        @selfRef.UseSsl = useSsl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs WithUserName(this global::Pulumi.AzureNative.DataMigration.Inputs.MongoConnectionInformationArgs @selfRef, global::System.String userName)
    {
        @selfRef.UserName = userName;
        return @selfRef;
    }

}
