// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Amplify;

public static partial class DomainArgsExtensions
{
    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithAppId(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, global::System.String appId)
    {
        @selfRef.AppId = appId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithAutoSubDomainCreationPatterns(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, global::System.Collections.Generic.List<global::System.String> autoSubDomainCreationPatterns)
    {
        @selfRef.AutoSubDomainCreationPatterns = autoSubDomainCreationPatterns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithAutoSubDomainCreationPatterns(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AutoSubDomainCreationPatterns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithAutoSubDomainCreationPatterns(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AutoSubDomainCreationPatterns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithAutoSubDomainIamRole(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, global::System.String autoSubDomainIamRole)
    {
        @selfRef.AutoSubDomainIamRole = autoSubDomainIamRole;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithCertificateSettings(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, global::Pulumi.AwsNative.Amplify.Inputs.DomainCertificateSettingsArgs certificateSettings)
    {
        @selfRef.CertificateSettings = certificateSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithCertificateSettings(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Amplify.Inputs.DomainCertificateSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Amplify.Inputs.DomainCertificateSettingsArgs();
        @configure(@item);
        @selfRef.CertificateSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithDomainName(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, global::System.String domainName)
    {
        @selfRef.DomainName = domainName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithEnableAutoSubDomain(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, bool enableAutoSubDomain = true)
    {
        @selfRef.EnableAutoSubDomain = enableAutoSubDomain;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithSubDomainSettings(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Amplify.Inputs.DomainSubDomainSettingArgs> subDomainSettings)
    {
        @selfRef.SubDomainSettings = subDomainSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithSubDomainSettings(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Amplify.Inputs.DomainSubDomainSettingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Amplify.Inputs.DomainSubDomainSettingArgs>();
        @configure(@list);
        @selfRef.SubDomainSettings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Amplify.DomainArgs WithSubDomainSettings(this global::Pulumi.AwsNative.Amplify.DomainArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Amplify.Inputs.DomainSubDomainSettingArgs>> @create)
    {
        @selfRef.SubDomainSettings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
