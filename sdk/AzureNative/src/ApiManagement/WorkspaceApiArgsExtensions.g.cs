// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class WorkspaceApiArgsExtensions
{
    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithApiId(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String apiId)
    {
        @selfRef.ApiId = apiId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithApiRevision(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String apiRevision)
    {
        @selfRef.ApiRevision = apiRevision;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithApiRevisionDescription(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String apiRevisionDescription)
    {
        @selfRef.ApiRevisionDescription = apiRevisionDescription;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithApiType(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.ApiType> apiType)
    {
        @selfRef.ApiType = apiType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithApiVersion(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String apiVersion)
    {
        @selfRef.ApiVersion = apiVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithApiVersionDescription(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String apiVersionDescription)
    {
        @selfRef.ApiVersionDescription = apiVersionDescription;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithApiVersionSet(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::Pulumi.AzureNative.ApiManagement.Inputs.ApiVersionSetContractDetailsArgs apiVersionSet)
    {
        @selfRef.ApiVersionSet = apiVersionSet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithApiVersionSet(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ApiManagement.Inputs.ApiVersionSetContractDetailsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ApiManagement.Inputs.ApiVersionSetContractDetailsArgs();
        @configure(@item);
        @selfRef.ApiVersionSet = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithApiVersionSetId(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String apiVersionSetId)
    {
        @selfRef.ApiVersionSetId = apiVersionSetId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithAuthenticationSettings(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::Pulumi.AzureNative.ApiManagement.Inputs.AuthenticationSettingsContractArgs authenticationSettings)
    {
        @selfRef.AuthenticationSettings = authenticationSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithAuthenticationSettings(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ApiManagement.Inputs.AuthenticationSettingsContractArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ApiManagement.Inputs.AuthenticationSettingsContractArgs();
        @configure(@item);
        @selfRef.AuthenticationSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithContact(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::Pulumi.AzureNative.ApiManagement.Inputs.ApiContactInformationArgs contact)
    {
        @selfRef.Contact = contact;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithContact(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ApiManagement.Inputs.ApiContactInformationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ApiManagement.Inputs.ApiContactInformationArgs();
        @configure(@item);
        @selfRef.Contact = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithDescription(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithDisplayName(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithFormat(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.ContentFormat> format)
    {
        @selfRef.Format = format;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithIsCurrent(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, bool isCurrent = true)
    {
        @selfRef.IsCurrent = isCurrent;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithLicense(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::Pulumi.AzureNative.ApiManagement.Inputs.ApiLicenseInformationArgs license)
    {
        @selfRef.License = license;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithLicense(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ApiManagement.Inputs.ApiLicenseInformationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ApiManagement.Inputs.ApiLicenseInformationArgs();
        @configure(@item);
        @selfRef.License = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithPath(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithProtocols(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.Protocol>> protocols)
    {
        @selfRef.Protocols = protocols;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithProtocols(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.Protocol>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.Protocol>>();
        @configure(@list);
        @selfRef.Protocols = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithProtocols(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.Protocol>>> @create)
    {
        @selfRef.Protocols = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithResourceGroupName(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithServiceName(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithServiceUrl(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String serviceUrl)
    {
        @selfRef.ServiceUrl = serviceUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithSoapApiType(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.SoapApiType> soapApiType)
    {
        @selfRef.SoapApiType = soapApiType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithSourceApiId(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String sourceApiId)
    {
        @selfRef.SourceApiId = sourceApiId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithSubscriptionKeyParameterNames(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::Pulumi.AzureNative.ApiManagement.Inputs.SubscriptionKeyParameterNamesContractArgs subscriptionKeyParameterNames)
    {
        @selfRef.SubscriptionKeyParameterNames = subscriptionKeyParameterNames;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithSubscriptionKeyParameterNames(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ApiManagement.Inputs.SubscriptionKeyParameterNamesContractArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ApiManagement.Inputs.SubscriptionKeyParameterNamesContractArgs();
        @configure(@item);
        @selfRef.SubscriptionKeyParameterNames = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithSubscriptionRequired(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, bool subscriptionRequired = true)
    {
        @selfRef.SubscriptionRequired = subscriptionRequired;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithTermsOfServiceUrl(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String termsOfServiceUrl)
    {
        @selfRef.TermsOfServiceUrl = termsOfServiceUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithTranslateRequiredQueryParametersConduct(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.TranslateRequiredQueryParametersConduct> translateRequiredQueryParametersConduct)
    {
        @selfRef.TranslateRequiredQueryParametersConduct = translateRequiredQueryParametersConduct;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithValue(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithWorkspaceId(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.String workspaceId)
    {
        @selfRef.WorkspaceId = workspaceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithWsdlSelector(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::Pulumi.AzureNative.ApiManagement.Inputs.ApiCreateOrUpdatePropertiesWsdlSelectorArgs wsdlSelector)
    {
        @selfRef.WsdlSelector = wsdlSelector;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs WithWsdlSelector(this global::Pulumi.AzureNative.ApiManagement.WorkspaceApiArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ApiManagement.Inputs.ApiCreateOrUpdatePropertiesWsdlSelectorArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ApiManagement.Inputs.ApiCreateOrUpdatePropertiesWsdlSelectorArgs();
        @configure(@item);
        @selfRef.WsdlSelector = @item;
        return @selfRef;
    }

}
