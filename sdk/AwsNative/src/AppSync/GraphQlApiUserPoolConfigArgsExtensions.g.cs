// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppSync.Inputs;

namespace Pulumi.AwsNative.AppSync;

public static partial class GraphQlApiUserPoolConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiUserPoolConfigArgs WithAppIdClientRegex(this global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiUserPoolConfigArgs @selfRef, global::System.String appIdClientRegex)
    {
        @selfRef.AppIdClientRegex = appIdClientRegex;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiUserPoolConfigArgs WithAwsRegion(this global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiUserPoolConfigArgs @selfRef, global::System.String awsRegion)
    {
        @selfRef.AwsRegion = awsRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiUserPoolConfigArgs WithDefaultAction(this global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiUserPoolConfigArgs @selfRef, global::System.String defaultAction)
    {
        @selfRef.DefaultAction = defaultAction;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiUserPoolConfigArgs WithUserPoolId(this global::Pulumi.AwsNative.AppSync.Inputs.GraphQlApiUserPoolConfigArgs @selfRef, global::System.String userPoolId)
    {
        @selfRef.UserPoolId = userPoolId;
        return @selfRef;
    }

}
