// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.CloudFormation;

public static partial class HookTypeConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.CloudFormation.HookTypeConfigArgs WithConfiguration(this global::Pulumi.AwsNative.CloudFormation.HookTypeConfigArgs @selfRef, global::System.String configuration)
    {
        @selfRef.Configuration = configuration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFormation.HookTypeConfigArgs WithConfigurationAlias(this global::Pulumi.AwsNative.CloudFormation.HookTypeConfigArgs @selfRef, global::Pulumi.AwsNative.CloudFormation.HookTypeConfigConfigurationAlias configurationAlias)
    {
        @selfRef.ConfigurationAlias = configurationAlias;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFormation.HookTypeConfigArgs WithConfigurationAlias(this global::Pulumi.AwsNative.CloudFormation.HookTypeConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFormation.HookTypeConfigConfigurationAlias> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.CloudFormation.HookTypeConfigConfigurationAlias>();
        @configure(@item);
        @selfRef.ConfigurationAlias = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFormation.HookTypeConfigArgs WithTypeArn(this global::Pulumi.AwsNative.CloudFormation.HookTypeConfigArgs @selfRef, global::System.String typeArn)
    {
        @selfRef.TypeArn = typeArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFormation.HookTypeConfigArgs WithTypeName(this global::Pulumi.AwsNative.CloudFormation.HookTypeConfigArgs @selfRef, global::System.String typeName)
    {
        @selfRef.TypeName = typeName;
        return @selfRef;
    }

}
