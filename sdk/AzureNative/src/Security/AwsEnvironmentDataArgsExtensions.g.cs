// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Security.Inputs;

namespace Pulumi.AzureNative.Security;

public static partial class AwsEnvironmentDataArgsExtensions
{
    public static global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs WithEnvironmentType(this global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs @selfRef, global::System.String environmentType)
    {
        @selfRef.EnvironmentType = environmentType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs WithOrganizationalData(this global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.Security.Inputs.AwsOrganizationalDataMasterArgs, global::Pulumi.AzureNative.Security.Inputs.AwsOrganizationalDataMemberArgs> organizationalData)
    {
        @selfRef.OrganizationalData = organizationalData;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs WithRegions(this global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs @selfRef, global::System.Collections.Generic.List<global::System.String> regions)
    {
        @selfRef.Regions = regions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs WithRegions(this global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Regions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs WithRegions(this global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Regions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs WithScanInterval(this global::Pulumi.AzureNative.Security.Inputs.AwsEnvironmentDataArgs @selfRef, global::System.Double scanInterval)
    {
        @selfRef.ScanInterval = scanInterval;
        return @selfRef;
    }

}
