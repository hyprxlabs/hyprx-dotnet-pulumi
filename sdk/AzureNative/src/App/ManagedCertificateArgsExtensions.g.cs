// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.App;

public static partial class ManagedCertificateArgsExtensions
{
    public static global::Pulumi.AzureNative.App.ManagedCertificateArgs WithEnvironmentName(this global::Pulumi.AzureNative.App.ManagedCertificateArgs @selfRef, global::System.String environmentName)
    {
        @selfRef.EnvironmentName = environmentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedCertificateArgs WithLocation(this global::Pulumi.AzureNative.App.ManagedCertificateArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedCertificateArgs WithManagedCertificateName(this global::Pulumi.AzureNative.App.ManagedCertificateArgs @selfRef, global::System.String managedCertificateName)
    {
        @selfRef.ManagedCertificateName = managedCertificateName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedCertificateArgs WithProperties(this global::Pulumi.AzureNative.App.ManagedCertificateArgs @selfRef, global::Pulumi.AzureNative.App.Inputs.ManagedCertificatePropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedCertificateArgs WithProperties(this global::Pulumi.AzureNative.App.ManagedCertificateArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.App.Inputs.ManagedCertificatePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.App.Inputs.ManagedCertificatePropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedCertificateArgs WithResourceGroupName(this global::Pulumi.AzureNative.App.ManagedCertificateArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedCertificateArgs WithTags(this global::Pulumi.AzureNative.App.ManagedCertificateArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedCertificateArgs WithTags(this global::Pulumi.AzureNative.App.ManagedCertificateArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedCertificateArgs WithTags(this global::Pulumi.AzureNative.App.ManagedCertificateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
