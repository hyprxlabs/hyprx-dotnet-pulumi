// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DataMigration;

public static partial class FileArgsExtensions
{
    public static global::Pulumi.AzureNative.DataMigration.FileArgs WithFileName(this global::Pulumi.AzureNative.DataMigration.FileArgs @selfRef, global::System.String fileName)
    {
        @selfRef.FileName = fileName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.FileArgs WithGroupName(this global::Pulumi.AzureNative.DataMigration.FileArgs @selfRef, global::System.String groupName)
    {
        @selfRef.GroupName = groupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.FileArgs WithProjectName(this global::Pulumi.AzureNative.DataMigration.FileArgs @selfRef, global::System.String projectName)
    {
        @selfRef.ProjectName = projectName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.FileArgs WithProperties(this global::Pulumi.AzureNative.DataMigration.FileArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.ProjectFilePropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.FileArgs WithProperties(this global::Pulumi.AzureNative.DataMigration.FileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.ProjectFilePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.ProjectFilePropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.FileArgs WithServiceName(this global::Pulumi.AzureNative.DataMigration.FileArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

}
