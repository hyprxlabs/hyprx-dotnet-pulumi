// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class LiteralJobInputArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LiteralJobInputArgs WithDescription(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LiteralJobInputArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LiteralJobInputArgs WithJobInputType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LiteralJobInputArgs @selfRef, global::System.String jobInputType)
    {
        @selfRef.JobInputType = jobInputType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LiteralJobInputArgs WithValue(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LiteralJobInputArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
