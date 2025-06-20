// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class ReferenceSetsArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReferenceSetsArgs WithIpSetReferences(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReferenceSetsArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.AwsConnector.Inputs.IPSetReferenceArgs> ipSetReferences)
    {
        @selfRef.IpSetReferences = ipSetReferences;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReferenceSetsArgs WithIpSetReferences(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReferenceSetsArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.AwsConnector.Inputs.IPSetReferenceArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.AwsConnector.Inputs.IPSetReferenceArgs>();
        @configure(@dict);
        @selfRef.IpSetReferences = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReferenceSetsArgs WithIpSetReferences(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReferenceSetsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.AwsConnector.Inputs.IPSetReferenceArgs>> @create)
    {
        @selfRef.IpSetReferences = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
