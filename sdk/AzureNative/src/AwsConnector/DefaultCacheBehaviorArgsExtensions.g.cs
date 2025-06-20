// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class DefaultCacheBehaviorArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithAllowedMethods(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowedMethods)
    {
        @selfRef.AllowedMethods = allowedMethods;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithAllowedMethods(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowedMethods = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithAllowedMethods(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowedMethods = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithCachePolicyId(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.String cachePolicyId)
    {
        @selfRef.CachePolicyId = cachePolicyId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithCachedMethods(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Collections.Generic.List<global::System.String> cachedMethods)
    {
        @selfRef.CachedMethods = cachedMethods;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithCachedMethods(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.CachedMethods = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithCachedMethods(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.CachedMethods = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithCompress(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, bool compress = true)
    {
        @selfRef.Compress = compress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithDefaultTTL(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Int32 defaultTTL)
    {
        @selfRef.DefaultTTL = defaultTTL;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithFieldLevelEncryptionId(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.String fieldLevelEncryptionId)
    {
        @selfRef.FieldLevelEncryptionId = fieldLevelEncryptionId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithForwardedValues(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ForwardedValuesArgs forwardedValues)
    {
        @selfRef.ForwardedValues = forwardedValues;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithForwardedValues(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ForwardedValuesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ForwardedValuesArgs();
        @configure(@item);
        @selfRef.ForwardedValues = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithFunctionAssociations(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.FunctionAssociationArgs> functionAssociations)
    {
        @selfRef.FunctionAssociations = functionAssociations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithFunctionAssociations(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.FunctionAssociationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.FunctionAssociationArgs>();
        @configure(@list);
        @selfRef.FunctionAssociations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithFunctionAssociations(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.FunctionAssociationArgs>> @create)
    {
        @selfRef.FunctionAssociations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithLambdaFunctionAssociations(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LambdaFunctionAssociationArgs> lambdaFunctionAssociations)
    {
        @selfRef.LambdaFunctionAssociations = lambdaFunctionAssociations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithLambdaFunctionAssociations(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LambdaFunctionAssociationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LambdaFunctionAssociationArgs>();
        @configure(@list);
        @selfRef.LambdaFunctionAssociations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithLambdaFunctionAssociations(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.LambdaFunctionAssociationArgs>> @create)
    {
        @selfRef.LambdaFunctionAssociations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithMaxTTL(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Int32 maxTTL)
    {
        @selfRef.MaxTTL = maxTTL;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithMinTTL(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Int32 minTTL)
    {
        @selfRef.MinTTL = minTTL;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithOriginRequestPolicyId(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.String originRequestPolicyId)
    {
        @selfRef.OriginRequestPolicyId = originRequestPolicyId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithRealtimeLogConfigArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.String realtimeLogConfigArn)
    {
        @selfRef.RealtimeLogConfigArn = realtimeLogConfigArn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithResponseHeadersPolicyId(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.String responseHeadersPolicyId)
    {
        @selfRef.ResponseHeadersPolicyId = responseHeadersPolicyId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithSmoothStreaming(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, bool smoothStreaming = true)
    {
        @selfRef.SmoothStreaming = smoothStreaming;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithTargetOriginId(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.String targetOriginId)
    {
        @selfRef.TargetOriginId = targetOriginId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithTrustedKeyGroups(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Collections.Generic.List<global::System.String> trustedKeyGroups)
    {
        @selfRef.TrustedKeyGroups = trustedKeyGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithTrustedKeyGroups(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.TrustedKeyGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithTrustedKeyGroups(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.TrustedKeyGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithTrustedSigners(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Collections.Generic.List<global::System.String> trustedSigners)
    {
        @selfRef.TrustedSigners = trustedSigners;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithTrustedSigners(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.TrustedSigners = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithTrustedSigners(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.TrustedSigners = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs WithViewerProtocolPolicy(this global::Pulumi.AzureNative.AwsConnector.Inputs.DefaultCacheBehaviorArgs @selfRef, global::System.String viewerProtocolPolicy)
    {
        @selfRef.ViewerProtocolPolicy = viewerProtocolPolicy;
        return @selfRef;
    }

}
