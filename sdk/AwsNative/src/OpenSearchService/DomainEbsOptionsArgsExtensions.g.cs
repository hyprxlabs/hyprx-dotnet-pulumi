// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.OpenSearchService.Inputs;

namespace Pulumi.AwsNative.OpenSearchService;

public static partial class DomainEbsOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainEbsOptionsArgs WithEbsEnabled(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainEbsOptionsArgs @selfRef, bool ebsEnabled = true)
    {
        @selfRef.EbsEnabled = ebsEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainEbsOptionsArgs WithIops(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainEbsOptionsArgs @selfRef, global::System.Int32 iops)
    {
        @selfRef.Iops = iops;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainEbsOptionsArgs WithThroughput(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainEbsOptionsArgs @selfRef, global::System.Int32 throughput)
    {
        @selfRef.Throughput = throughput;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainEbsOptionsArgs WithVolumeSize(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainEbsOptionsArgs @selfRef, global::System.Int32 volumeSize)
    {
        @selfRef.VolumeSize = volumeSize;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainEbsOptionsArgs WithVolumeType(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainEbsOptionsArgs @selfRef, global::System.String volumeType)
    {
        @selfRef.VolumeType = volumeType;
        return @selfRef;
    }

}
