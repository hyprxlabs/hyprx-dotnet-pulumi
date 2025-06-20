// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.GuestConfiguration.Inputs;

namespace Pulumi.AzureNative.GuestConfiguration;

public static partial class GuestConfigurationNavigationArgsExtensions
{
    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithAssignmentType(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.GuestConfiguration.AssignmentType> assignmentType)
    {
        @selfRef.AssignmentType = assignmentType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithConfigurationParameter(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.GuestConfiguration.Inputs.ConfigurationParameterArgs> configurationParameter)
    {
        @selfRef.ConfigurationParameter = configurationParameter;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithConfigurationParameter(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.GuestConfiguration.Inputs.ConfigurationParameterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.GuestConfiguration.Inputs.ConfigurationParameterArgs>();
        @configure(@list);
        @selfRef.ConfigurationParameter = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithConfigurationParameter(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.GuestConfiguration.Inputs.ConfigurationParameterArgs>> @create)
    {
        @selfRef.ConfigurationParameter = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithConfigurationProtectedParameter(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.GuestConfiguration.Inputs.ConfigurationParameterArgs> configurationProtectedParameter)
    {
        @selfRef.ConfigurationProtectedParameter = configurationProtectedParameter;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithConfigurationProtectedParameter(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.GuestConfiguration.Inputs.ConfigurationParameterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.GuestConfiguration.Inputs.ConfigurationParameterArgs>();
        @configure(@list);
        @selfRef.ConfigurationProtectedParameter = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithConfigurationProtectedParameter(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.GuestConfiguration.Inputs.ConfigurationParameterArgs>> @create)
    {
        @selfRef.ConfigurationProtectedParameter = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithContentHash(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::System.String contentHash)
    {
        @selfRef.ContentHash = contentHash;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithContentManagedIdentity(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::System.String contentManagedIdentity)
    {
        @selfRef.ContentManagedIdentity = contentManagedIdentity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithContentUri(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::System.String contentUri)
    {
        @selfRef.ContentUri = contentUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithKind(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.GuestConfiguration.Kind> kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithName(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs WithVersion(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
