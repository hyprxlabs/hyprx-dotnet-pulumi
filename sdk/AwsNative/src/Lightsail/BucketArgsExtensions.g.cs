// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Lightsail;

public static partial class BucketArgsExtensions
{
    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithAccessRules(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::Pulumi.AwsNative.Lightsail.Inputs.BucketAccessRulesArgs accessRules)
    {
        @selfRef.AccessRules = accessRules;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithAccessRules(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lightsail.Inputs.BucketAccessRulesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lightsail.Inputs.BucketAccessRulesArgs();
        @configure(@item);
        @selfRef.AccessRules = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithBucketName(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.String bucketName)
    {
        @selfRef.BucketName = bucketName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithBundleId(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.String bundleId)
    {
        @selfRef.BundleId = bundleId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithObjectVersioning(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, bool objectVersioning = true)
    {
        @selfRef.ObjectVersioning = objectVersioning;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithReadOnlyAccessAccounts(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.Collections.Generic.List<global::System.String> readOnlyAccessAccounts)
    {
        @selfRef.ReadOnlyAccessAccounts = readOnlyAccessAccounts;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithReadOnlyAccessAccounts(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ReadOnlyAccessAccounts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithReadOnlyAccessAccounts(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ReadOnlyAccessAccounts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithResourcesReceivingAccess(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.Collections.Generic.List<global::System.String> resourcesReceivingAccess)
    {
        @selfRef.ResourcesReceivingAccess = resourcesReceivingAccess;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithResourcesReceivingAccess(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ResourcesReceivingAccess = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithResourcesReceivingAccess(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ResourcesReceivingAccess = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithTags(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithTags(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.BucketArgs WithTags(this global::Pulumi.AwsNative.Lightsail.BucketArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
