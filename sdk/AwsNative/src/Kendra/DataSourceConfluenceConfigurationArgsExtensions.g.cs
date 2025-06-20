// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Kendra.Inputs;

namespace Pulumi.AwsNative.Kendra;

public static partial class DataSourceConfluenceConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithAttachmentConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceAttachmentConfigurationArgs attachmentConfiguration)
    {
        @selfRef.AttachmentConfiguration = attachmentConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithAttachmentConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceAttachmentConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceAttachmentConfigurationArgs();
        @configure(@item);
        @selfRef.AttachmentConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithBlogConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceBlogConfigurationArgs blogConfiguration)
    {
        @selfRef.BlogConfiguration = blogConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithBlogConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceBlogConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceBlogConfigurationArgs();
        @configure(@item);
        @selfRef.BlogConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithExclusionPatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> exclusionPatterns)
    {
        @selfRef.ExclusionPatterns = exclusionPatterns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithExclusionPatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ExclusionPatterns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithExclusionPatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ExclusionPatterns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithInclusionPatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> inclusionPatterns)
    {
        @selfRef.InclusionPatterns = inclusionPatterns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithInclusionPatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.InclusionPatterns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithInclusionPatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.InclusionPatterns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithPageConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluencePageConfigurationArgs pageConfiguration)
    {
        @selfRef.PageConfiguration = pageConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithPageConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluencePageConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluencePageConfigurationArgs();
        @configure(@item);
        @selfRef.PageConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithSecretArn(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.String secretArn)
    {
        @selfRef.SecretArn = secretArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithServerUrl(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.String serverUrl)
    {
        @selfRef.ServerUrl = serverUrl;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithSpaceConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceSpaceConfigurationArgs spaceConfiguration)
    {
        @selfRef.SpaceConfiguration = spaceConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithSpaceConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceSpaceConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceSpaceConfigurationArgs();
        @configure(@item);
        @selfRef.SpaceConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithVersion(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::Pulumi.AwsNative.Kendra.DataSourceConfluenceVersion version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithVersion(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.DataSourceConfluenceVersion> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Kendra.DataSourceConfluenceVersion>();
        @configure(@item);
        @selfRef.Version = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithVpcConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::Pulumi.AwsNative.Kendra.Inputs.DataSourceVpcConfigurationArgs vpcConfiguration)
    {
        @selfRef.VpcConfiguration = vpcConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs WithVpcConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceConfluenceConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceVpcConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Kendra.Inputs.DataSourceVpcConfigurationArgs();
        @configure(@item);
        @selfRef.VpcConfiguration = @item;
        return @selfRef;
    }

}
