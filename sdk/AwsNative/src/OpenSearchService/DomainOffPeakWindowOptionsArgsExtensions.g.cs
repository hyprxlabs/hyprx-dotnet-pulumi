// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.OpenSearchService.Inputs;

namespace Pulumi.AwsNative.OpenSearchService;

public static partial class DomainOffPeakWindowOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainOffPeakWindowOptionsArgs WithEnabled(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainOffPeakWindowOptionsArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainOffPeakWindowOptionsArgs WithOffPeakWindow(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainOffPeakWindowOptionsArgs @selfRef, global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainOffPeakWindowArgs offPeakWindow)
    {
        @selfRef.OffPeakWindow = offPeakWindow;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainOffPeakWindowOptionsArgs WithOffPeakWindow(this global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainOffPeakWindowOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainOffPeakWindowArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.OpenSearchService.Inputs.DomainOffPeakWindowArgs();
        @configure(@item);
        @selfRef.OffPeakWindow = @item;
        return @selfRef;
    }

}
