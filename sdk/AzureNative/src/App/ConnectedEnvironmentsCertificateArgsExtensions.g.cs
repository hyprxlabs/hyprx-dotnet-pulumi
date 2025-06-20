// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.App;

public static partial class ConnectedEnvironmentsCertificateArgsExtensions
{
    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs WithCertificateName(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs @selfRef, global::System.String certificateName)
    {
        @selfRef.CertificateName = certificateName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs WithConnectedEnvironmentName(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs @selfRef, global::System.String connectedEnvironmentName)
    {
        @selfRef.ConnectedEnvironmentName = connectedEnvironmentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs WithLocation(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs WithProperties(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs @selfRef, global::Pulumi.AzureNative.App.Inputs.CertificatePropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs WithProperties(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.App.Inputs.CertificatePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.App.Inputs.CertificatePropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs WithResourceGroupName(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs WithTags(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs WithTags(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs WithTags(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsCertificateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
