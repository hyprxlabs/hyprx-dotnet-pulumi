// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DataZone.Inputs;

namespace Pulumi.AwsNative.DataZone;

public static partial class ConnectionPropertiesInput0PropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.DataZone.Inputs.ConnectionPropertiesInput0PropertiesArgs WithAthenaProperties(this global::Pulumi.AwsNative.DataZone.Inputs.ConnectionPropertiesInput0PropertiesArgs @selfRef, global::Pulumi.AwsNative.DataZone.Inputs.ConnectionAthenaPropertiesInputArgs athenaProperties)
    {
        @selfRef.AthenaProperties = athenaProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataZone.Inputs.ConnectionPropertiesInput0PropertiesArgs WithAthenaProperties(this global::Pulumi.AwsNative.DataZone.Inputs.ConnectionPropertiesInput0PropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataZone.Inputs.ConnectionAthenaPropertiesInputArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DataZone.Inputs.ConnectionAthenaPropertiesInputArgs();
        @configure(@item);
        @selfRef.AthenaProperties = @item;
        return @selfRef;
    }

}
