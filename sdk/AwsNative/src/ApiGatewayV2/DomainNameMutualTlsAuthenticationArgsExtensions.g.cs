// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ApiGatewayV2.Inputs;

namespace Pulumi.AwsNative.ApiGatewayV2;

public static partial class DomainNameMutualTlsAuthenticationArgsExtensions
{
    public static global::Pulumi.AwsNative.ApiGatewayV2.Inputs.DomainNameMutualTlsAuthenticationArgs WithTruststoreUri(this global::Pulumi.AwsNative.ApiGatewayV2.Inputs.DomainNameMutualTlsAuthenticationArgs @selfRef, global::System.String truststoreUri)
    {
        @selfRef.TruststoreUri = truststoreUri;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApiGatewayV2.Inputs.DomainNameMutualTlsAuthenticationArgs WithTruststoreVersion(this global::Pulumi.AwsNative.ApiGatewayV2.Inputs.DomainNameMutualTlsAuthenticationArgs @selfRef, global::System.String truststoreVersion)
    {
        @selfRef.TruststoreVersion = truststoreVersion;
        return @selfRef;
    }

}
