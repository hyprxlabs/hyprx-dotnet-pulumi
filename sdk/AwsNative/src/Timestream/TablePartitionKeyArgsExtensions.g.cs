// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Timestream.Inputs;

namespace Pulumi.AwsNative.Timestream;

public static partial class TablePartitionKeyArgsExtensions
{
    public static global::Pulumi.AwsNative.Timestream.Inputs.TablePartitionKeyArgs WithEnforcementInRecord(this global::Pulumi.AwsNative.Timestream.Inputs.TablePartitionKeyArgs @selfRef, global::Pulumi.AwsNative.Timestream.TablePartitionKeyEnforcementLevel enforcementInRecord)
    {
        @selfRef.EnforcementInRecord = enforcementInRecord;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Timestream.Inputs.TablePartitionKeyArgs WithEnforcementInRecord(this global::Pulumi.AwsNative.Timestream.Inputs.TablePartitionKeyArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Timestream.TablePartitionKeyEnforcementLevel> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Timestream.TablePartitionKeyEnforcementLevel>();
        @configure(@item);
        @selfRef.EnforcementInRecord = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Timestream.Inputs.TablePartitionKeyArgs WithName(this global::Pulumi.AwsNative.Timestream.Inputs.TablePartitionKeyArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Timestream.Inputs.TablePartitionKeyArgs WithType(this global::Pulumi.AwsNative.Timestream.Inputs.TablePartitionKeyArgs @selfRef, global::Pulumi.AwsNative.Timestream.TablePartitionKeyType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Timestream.Inputs.TablePartitionKeyArgs WithType(this global::Pulumi.AwsNative.Timestream.Inputs.TablePartitionKeyArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Timestream.TablePartitionKeyType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Timestream.TablePartitionKeyType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
