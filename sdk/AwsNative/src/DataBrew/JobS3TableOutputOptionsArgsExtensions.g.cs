// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DataBrew.Inputs;

namespace Pulumi.AwsNative.DataBrew;

public static partial class JobS3TableOutputOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.DataBrew.Inputs.JobS3TableOutputOptionsArgs WithLocation(this global::Pulumi.AwsNative.DataBrew.Inputs.JobS3TableOutputOptionsArgs @selfRef, global::Pulumi.AwsNative.DataBrew.Inputs.JobS3LocationArgs location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.Inputs.JobS3TableOutputOptionsArgs WithLocation(this global::Pulumi.AwsNative.DataBrew.Inputs.JobS3TableOutputOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DataBrew.Inputs.JobS3LocationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DataBrew.Inputs.JobS3LocationArgs();
        @configure(@item);
        @selfRef.Location = @item;
        return @selfRef;
    }

}
