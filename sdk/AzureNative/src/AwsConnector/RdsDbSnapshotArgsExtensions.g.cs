// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AwsConnector;

public static partial class RdsDbSnapshotArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs WithLocation(this global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs WithName(this global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs WithProperties(this global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.RdsDBSnapshotPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs WithProperties(this global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.RdsDBSnapshotPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.RdsDBSnapshotPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs WithResourceGroupName(this global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.RdsDbSnapshotArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
