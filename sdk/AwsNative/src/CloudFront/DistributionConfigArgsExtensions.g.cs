// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CloudFront.Inputs;

namespace Pulumi.AwsNative.CloudFront;

public static partial class DistributionConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithAliases(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Collections.Generic.List<global::System.String> aliases)
    {
        @selfRef.Aliases = aliases;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithAliases(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Aliases = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithAliases(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Aliases = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithAnycastIpListId(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.String anycastIpListId)
    {
        @selfRef.AnycastIpListId = anycastIpListId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithCacheBehaviors(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionCacheBehaviorArgs> cacheBehaviors)
    {
        @selfRef.CacheBehaviors = cacheBehaviors;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithCacheBehaviors(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionCacheBehaviorArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionCacheBehaviorArgs>();
        @configure(@list);
        @selfRef.CacheBehaviors = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithCacheBehaviors(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionCacheBehaviorArgs>> @create)
    {
        @selfRef.CacheBehaviors = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithCnames(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Collections.Generic.List<global::System.String> cnames)
    {
        @selfRef.Cnames = cnames;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithCnames(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Cnames = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithCnames(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Cnames = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithComment(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.String comment)
    {
        @selfRef.Comment = comment;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithConnectionMode(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::Pulumi.AwsNative.CloudFront.DistributionConnectionMode connectionMode)
    {
        @selfRef.ConnectionMode = connectionMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithConnectionMode(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.DistributionConnectionMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.CloudFront.DistributionConnectionMode>();
        @configure(@item);
        @selfRef.ConnectionMode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithContinuousDeploymentPolicyId(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.String continuousDeploymentPolicyId)
    {
        @selfRef.ContinuousDeploymentPolicyId = continuousDeploymentPolicyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithCustomErrorResponses(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionCustomErrorResponseArgs> customErrorResponses)
    {
        @selfRef.CustomErrorResponses = customErrorResponses;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithCustomErrorResponses(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionCustomErrorResponseArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionCustomErrorResponseArgs>();
        @configure(@list);
        @selfRef.CustomErrorResponses = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithCustomErrorResponses(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionCustomErrorResponseArgs>> @create)
    {
        @selfRef.CustomErrorResponses = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithCustomOrigin(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::Pulumi.AwsNative.CloudFront.Inputs.DistributionLegacyCustomOriginArgs customOrigin)
    {
        @selfRef.CustomOrigin = customOrigin;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithCustomOrigin(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionLegacyCustomOriginArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudFront.Inputs.DistributionLegacyCustomOriginArgs();
        @configure(@item);
        @selfRef.CustomOrigin = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithDefaultCacheBehavior(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::Pulumi.AwsNative.CloudFront.Inputs.DistributionDefaultCacheBehaviorArgs defaultCacheBehavior)
    {
        @selfRef.DefaultCacheBehavior = defaultCacheBehavior;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithDefaultCacheBehavior(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionDefaultCacheBehaviorArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudFront.Inputs.DistributionDefaultCacheBehaviorArgs();
        @configure(@item);
        @selfRef.DefaultCacheBehavior = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithDefaultRootObject(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.String defaultRootObject)
    {
        @selfRef.DefaultRootObject = defaultRootObject;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithEnabled(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithHttpVersion(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.String httpVersion)
    {
        @selfRef.HttpVersion = httpVersion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithIpv6Enabled(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, bool ipv6Enabled = true)
    {
        @selfRef.Ipv6Enabled = ipv6Enabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithLogging(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::Pulumi.AwsNative.CloudFront.Inputs.DistributionLoggingArgs logging)
    {
        @selfRef.Logging = logging;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithLogging(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionLoggingArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudFront.Inputs.DistributionLoggingArgs();
        @configure(@item);
        @selfRef.Logging = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithOriginGroups(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupsArgs originGroups)
    {
        @selfRef.OriginGroups = originGroups;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithOriginGroups(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginGroupsArgs();
        @configure(@item);
        @selfRef.OriginGroups = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithOrigins(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginArgs> origins)
    {
        @selfRef.Origins = origins;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithOrigins(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginArgs>();
        @configure(@list);
        @selfRef.Origins = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithOrigins(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginArgs>> @create)
    {
        @selfRef.Origins = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithPriceClass(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.String priceClass)
    {
        @selfRef.PriceClass = priceClass;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithRestrictions(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::Pulumi.AwsNative.CloudFront.Inputs.DistributionRestrictionsArgs restrictions)
    {
        @selfRef.Restrictions = restrictions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithRestrictions(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionRestrictionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudFront.Inputs.DistributionRestrictionsArgs();
        @configure(@item);
        @selfRef.Restrictions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithS3Origin(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::Pulumi.AwsNative.CloudFront.Inputs.DistributionLegacyS3OriginArgs s3Origin)
    {
        @selfRef.S3Origin = s3Origin;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithS3Origin(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionLegacyS3OriginArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudFront.Inputs.DistributionLegacyS3OriginArgs();
        @configure(@item);
        @selfRef.S3Origin = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithStaging(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, bool staging = true)
    {
        @selfRef.Staging = staging;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithTenantConfig(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigTenantConfigPropertiesArgs tenantConfig)
    {
        @selfRef.TenantConfig = tenantConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithTenantConfig(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigTenantConfigPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigTenantConfigPropertiesArgs();
        @configure(@item);
        @selfRef.TenantConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithViewerCertificate(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::Pulumi.AwsNative.CloudFront.Inputs.DistributionViewerCertificateArgs viewerCertificate)
    {
        @selfRef.ViewerCertificate = viewerCertificate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithViewerCertificate(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.Inputs.DistributionViewerCertificateArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudFront.Inputs.DistributionViewerCertificateArgs();
        @configure(@item);
        @selfRef.ViewerCertificate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs WithWebAclId(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionConfigArgs @selfRef, global::System.String webAclId)
    {
        @selfRef.WebAclId = webAclId;
        return @selfRef;
    }

}
