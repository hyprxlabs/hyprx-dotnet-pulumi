// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AutoScalingAutoScalingGroupArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs WithLocation(this global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs WithName(this global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs WithProperties(this global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.AutoScalingAutoScalingGroupPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs WithProperties(this global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.AutoScalingAutoScalingGroupPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.AutoScalingAutoScalingGroupPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs WithResourceGroupName(this global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.AutoScalingAutoScalingGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
