// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Sso;

public static partial class ApplicationArgsExtensions
{
    public static global::Pulumi.AwsNative.Sso.ApplicationArgs WithApplicationProviderArn(this global::Pulumi.AwsNative.Sso.ApplicationArgs @selfRef, global::System.String applicationProviderArn)
    {
        @selfRef.ApplicationProviderArn = applicationProviderArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.ApplicationArgs WithDescription(this global::Pulumi.AwsNative.Sso.ApplicationArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.ApplicationArgs WithInstanceArn(this global::Pulumi.AwsNative.Sso.ApplicationArgs @selfRef, global::System.String instanceArn)
    {
        @selfRef.InstanceArn = instanceArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.ApplicationArgs WithName(this global::Pulumi.AwsNative.Sso.ApplicationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.ApplicationArgs WithPortalOptions(this global::Pulumi.AwsNative.Sso.ApplicationArgs @selfRef, global::Pulumi.AwsNative.Sso.Inputs.ApplicationPortalOptionsConfigurationArgs portalOptions)
    {
        @selfRef.PortalOptions = portalOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.ApplicationArgs WithPortalOptions(this global::Pulumi.AwsNative.Sso.ApplicationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Sso.Inputs.ApplicationPortalOptionsConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Sso.Inputs.ApplicationPortalOptionsConfigurationArgs();
        @configure(@item);
        @selfRef.PortalOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.ApplicationArgs WithStatus(this global::Pulumi.AwsNative.Sso.ApplicationArgs @selfRef, global::Pulumi.AwsNative.Sso.ApplicationStatus status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.ApplicationArgs WithStatus(this global::Pulumi.AwsNative.Sso.ApplicationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Sso.ApplicationStatus> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Sso.ApplicationStatus>();
        @configure(@item);
        @selfRef.Status = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.ApplicationArgs WithTags(this global::Pulumi.AwsNative.Sso.ApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.ApplicationArgs WithTags(this global::Pulumi.AwsNative.Sso.ApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sso.ApplicationArgs WithTags(this global::Pulumi.AwsNative.Sso.ApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
