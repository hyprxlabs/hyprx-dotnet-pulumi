// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs;

namespace Pulumi.AwsNative.ElasticLoadBalancingV2;

public static partial class ListenerActionArgsExtensions
{
    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithAuthenticateCognitoConfig(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerAuthenticateCognitoConfigArgs authenticateCognitoConfig)
    {
        @selfRef.AuthenticateCognitoConfig = authenticateCognitoConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithAuthenticateCognitoConfig(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerAuthenticateCognitoConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerAuthenticateCognitoConfigArgs();
        @configure(@item);
        @selfRef.AuthenticateCognitoConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithAuthenticateOidcConfig(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerAuthenticateOidcConfigArgs authenticateOidcConfig)
    {
        @selfRef.AuthenticateOidcConfig = authenticateOidcConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithAuthenticateOidcConfig(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerAuthenticateOidcConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerAuthenticateOidcConfigArgs();
        @configure(@item);
        @selfRef.AuthenticateOidcConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithFixedResponseConfig(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerFixedResponseConfigArgs fixedResponseConfig)
    {
        @selfRef.FixedResponseConfig = fixedResponseConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithFixedResponseConfig(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerFixedResponseConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerFixedResponseConfigArgs();
        @configure(@item);
        @selfRef.FixedResponseConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithForwardConfig(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerForwardConfigArgs forwardConfig)
    {
        @selfRef.ForwardConfig = forwardConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithForwardConfig(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerForwardConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerForwardConfigArgs();
        @configure(@item);
        @selfRef.ForwardConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithOrder(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::System.Int32 order)
    {
        @selfRef.Order = order;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithRedirectConfig(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRedirectConfigArgs redirectConfig)
    {
        @selfRef.RedirectConfig = redirectConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithRedirectConfig(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRedirectConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRedirectConfigArgs();
        @configure(@item);
        @selfRef.RedirectConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithTargetGroupArn(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::System.String targetGroupArn)
    {
        @selfRef.TargetGroupArn = targetGroupArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs WithType(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerActionArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
