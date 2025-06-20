// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTTwinMaker.Inputs;

namespace Pulumi.AwsNative.IoTTwinMaker;

public static partial class EntityDefinitionArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithConfiguration(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> configuration)
    {
        @selfRef.Configuration = configuration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithConfiguration(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Configuration = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithConfiguration(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Configuration = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithDataType(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDataTypeArgs dataType)
    {
        @selfRef.DataType = dataType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithDataType(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDataTypeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDataTypeArgs();
        @configure(@item);
        @selfRef.DataType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithDefaultValue(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDataValueArgs defaultValue)
    {
        @selfRef.DefaultValue = defaultValue;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithDefaultValue(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDataValueArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDataValueArgs();
        @configure(@item);
        @selfRef.DefaultValue = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithIsExternalId(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, bool isExternalId = true)
    {
        @selfRef.IsExternalId = isExternalId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithIsFinal(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, bool isFinal = true)
    {
        @selfRef.IsFinal = isFinal;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithIsImported(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, bool isImported = true)
    {
        @selfRef.IsImported = isImported;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithIsInherited(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, bool isInherited = true)
    {
        @selfRef.IsInherited = isInherited;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithIsRequiredInEntity(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, bool isRequiredInEntity = true)
    {
        @selfRef.IsRequiredInEntity = isRequiredInEntity;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithIsStoredExternally(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, bool isStoredExternally = true)
    {
        @selfRef.IsStoredExternally = isStoredExternally;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs WithIsTimeSeries(this global::Pulumi.AwsNative.IoTTwinMaker.Inputs.EntityDefinitionArgs @selfRef, bool isTimeSeries = true)
    {
        @selfRef.IsTimeSeries = isTimeSeries;
        return @selfRef;
    }

}
