// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class GenerateSecretStringArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs WithExcludeCharacters(this global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs @selfRef, global::System.String excludeCharacters)
    {
        @selfRef.ExcludeCharacters = excludeCharacters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs WithExcludeLowercase(this global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs @selfRef, bool excludeLowercase = true)
    {
        @selfRef.ExcludeLowercase = excludeLowercase;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs WithExcludeNumbers(this global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs @selfRef, bool excludeNumbers = true)
    {
        @selfRef.ExcludeNumbers = excludeNumbers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs WithExcludePunctuation(this global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs @selfRef, bool excludePunctuation = true)
    {
        @selfRef.ExcludePunctuation = excludePunctuation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs WithExcludeUppercase(this global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs @selfRef, bool excludeUppercase = true)
    {
        @selfRef.ExcludeUppercase = excludeUppercase;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs WithGenerateStringKey(this global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs @selfRef, global::System.String generateStringKey)
    {
        @selfRef.GenerateStringKey = generateStringKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs WithIncludeSpace(this global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs @selfRef, bool includeSpace = true)
    {
        @selfRef.IncludeSpace = includeSpace;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs WithPasswordLength(this global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs @selfRef, global::System.Int32 passwordLength)
    {
        @selfRef.PasswordLength = passwordLength;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs WithRequireEachIncludedType(this global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs @selfRef, bool requireEachIncludedType = true)
    {
        @selfRef.RequireEachIncludedType = requireEachIncludedType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs WithSecretStringTemplate(this global::Pulumi.AzureNative.AwsConnector.Inputs.GenerateSecretStringArgs @selfRef, global::System.String secretStringTemplate)
    {
        @selfRef.SecretStringTemplate = secretStringTemplate;
        return @selfRef;
    }

}
