// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTSiteWise.Inputs;

namespace Pulumi.AwsNative.IoTSiteWise;

public static partial class AssetModelExpressionVariableArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTSiteWise.Inputs.AssetModelExpressionVariableArgs WithName(this global::Pulumi.AwsNative.IoTSiteWise.Inputs.AssetModelExpressionVariableArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTSiteWise.Inputs.AssetModelExpressionVariableArgs WithValue(this global::Pulumi.AwsNative.IoTSiteWise.Inputs.AssetModelExpressionVariableArgs @selfRef, global::Pulumi.AwsNative.IoTSiteWise.Inputs.AssetModelVariableValueArgs value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTSiteWise.Inputs.AssetModelExpressionVariableArgs WithValue(this global::Pulumi.AwsNative.IoTSiteWise.Inputs.AssetModelExpressionVariableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTSiteWise.Inputs.AssetModelVariableValueArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTSiteWise.Inputs.AssetModelVariableValueArgs();
        @configure(@item);
        @selfRef.Value = @item;
        return @selfRef;
    }

}
