// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppConfig.Inputs;

namespace Pulumi.AwsNative.AppConfig;

public static partial class ExtensionActionArgsExtensions
{
    public static global::Pulumi.AwsNative.AppConfig.Inputs.ExtensionActionArgs WithDescription(this global::Pulumi.AwsNative.AppConfig.Inputs.ExtensionActionArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.Inputs.ExtensionActionArgs WithName(this global::Pulumi.AwsNative.AppConfig.Inputs.ExtensionActionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.Inputs.ExtensionActionArgs WithRoleArn(this global::Pulumi.AwsNative.AppConfig.Inputs.ExtensionActionArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppConfig.Inputs.ExtensionActionArgs WithUri(this global::Pulumi.AwsNative.AppConfig.Inputs.ExtensionActionArgs @selfRef, global::System.String uri)
    {
        @selfRef.Uri = uri;
        return @selfRef;
    }

}
