// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class DataAutomationProjectVideoStandardGenerativeFieldArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoStandardGenerativeFieldArgs WithState(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoStandardGenerativeFieldArgs @selfRef, global::Pulumi.AwsNative.Bedrock.DataAutomationProjectState state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoStandardGenerativeFieldArgs WithState(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoStandardGenerativeFieldArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectState>();
        @configure(@item);
        @selfRef.State = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoStandardGenerativeFieldArgs WithTypes(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoStandardGenerativeFieldArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectVideoStandardGenerativeFieldType> types)
    {
        @selfRef.Types = types;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoStandardGenerativeFieldArgs WithTypes(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoStandardGenerativeFieldArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectVideoStandardGenerativeFieldType>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectVideoStandardGenerativeFieldType>();
        @configure(@list);
        @selfRef.Types = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoStandardGenerativeFieldArgs WithTypes(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectVideoStandardGenerativeFieldArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Bedrock.DataAutomationProjectVideoStandardGenerativeFieldType>> @create)
    {
        @selfRef.Types = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
