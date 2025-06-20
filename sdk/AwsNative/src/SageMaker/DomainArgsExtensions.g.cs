// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.SageMaker;

public static partial class DomainArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithAppNetworkAccessType(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::Pulumi.AwsNative.SageMaker.DomainAppNetworkAccessType appNetworkAccessType)
    {
        @selfRef.AppNetworkAccessType = appNetworkAccessType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithAppNetworkAccessType(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.DomainAppNetworkAccessType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.DomainAppNetworkAccessType>();
        @configure(@item);
        @selfRef.AppNetworkAccessType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithAppSecurityGroupManagement(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::Pulumi.AwsNative.SageMaker.DomainAppSecurityGroupManagement appSecurityGroupManagement)
    {
        @selfRef.AppSecurityGroupManagement = appSecurityGroupManagement;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithAppSecurityGroupManagement(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.DomainAppSecurityGroupManagement> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.DomainAppSecurityGroupManagement>();
        @configure(@item);
        @selfRef.AppSecurityGroupManagement = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithAuthMode(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::Pulumi.AwsNative.SageMaker.DomainAuthMode authMode)
    {
        @selfRef.AuthMode = authMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithAuthMode(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.DomainAuthMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.DomainAuthMode>();
        @configure(@item);
        @selfRef.AuthMode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithDefaultSpaceSettings(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.DomainDefaultSpaceSettingsArgs defaultSpaceSettings)
    {
        @selfRef.DefaultSpaceSettings = defaultSpaceSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithDefaultSpaceSettings(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.DomainDefaultSpaceSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.DomainDefaultSpaceSettingsArgs();
        @configure(@item);
        @selfRef.DefaultSpaceSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithDefaultUserSettings(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.DomainUserSettingsArgs defaultUserSettings)
    {
        @selfRef.DefaultUserSettings = defaultUserSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithDefaultUserSettings(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.DomainUserSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.DomainUserSettingsArgs();
        @configure(@item);
        @selfRef.DefaultUserSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithDomainName(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.String domainName)
    {
        @selfRef.DomainName = domainName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithDomainSettings(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.DomainSettingsArgs domainSettings)
    {
        @selfRef.DomainSettings = domainSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithDomainSettings(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.DomainSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.DomainSettingsArgs();
        @configure(@item);
        @selfRef.DomainSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithKmsKeyId(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithSubnetIds(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnetIds)
    {
        @selfRef.SubnetIds = subnetIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithSubnetIds(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SubnetIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithSubnetIds(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SubnetIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithTagPropagation(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::Pulumi.AwsNative.SageMaker.DomainTagPropagation tagPropagation)
    {
        @selfRef.TagPropagation = tagPropagation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithTagPropagation(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.DomainTagPropagation> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.DomainTagPropagation>();
        @configure(@item);
        @selfRef.TagPropagation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithTags(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithTags(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithTags(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.CreateOnlyTagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.DomainArgs WithVpcId(this global::Pulumi.AwsNative.SageMaker.DomainArgs @selfRef, global::System.String vpcId)
    {
        @selfRef.VpcId = vpcId;
        return @selfRef;
    }

}
