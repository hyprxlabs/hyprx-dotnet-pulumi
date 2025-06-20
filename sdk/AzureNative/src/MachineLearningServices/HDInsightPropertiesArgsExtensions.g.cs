// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class HDInsightPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.HDInsightPropertiesArgs WithAddress(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.HDInsightPropertiesArgs @selfRef, global::System.String address)
    {
        @selfRef.Address = address;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.HDInsightPropertiesArgs WithAdministratorAccount(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.HDInsightPropertiesArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.VirtualMachineSshCredentialsArgs administratorAccount)
    {
        @selfRef.AdministratorAccount = administratorAccount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.HDInsightPropertiesArgs WithAdministratorAccount(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.HDInsightPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.VirtualMachineSshCredentialsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.VirtualMachineSshCredentialsArgs();
        @configure(@item);
        @selfRef.AdministratorAccount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.HDInsightPropertiesArgs WithSshPort(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.HDInsightPropertiesArgs @selfRef, global::System.Int32 sshPort)
    {
        @selfRef.SshPort = sshPort;
        return @selfRef;
    }

}
