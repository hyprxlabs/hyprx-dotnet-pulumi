// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.IoT;

public static partial class CaCertificateArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithAutoRegistrationStatus(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::Pulumi.AwsNative.IoT.CaCertificateAutoRegistrationStatus autoRegistrationStatus)
    {
        @selfRef.AutoRegistrationStatus = autoRegistrationStatus;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithAutoRegistrationStatus(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.CaCertificateAutoRegistrationStatus> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.IoT.CaCertificateAutoRegistrationStatus>();
        @configure(@item);
        @selfRef.AutoRegistrationStatus = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithCaCertificatePem(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::System.String caCertificatePem)
    {
        @selfRef.CaCertificatePem = caCertificatePem;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithCertificateMode(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::Pulumi.AwsNative.IoT.CaCertificateCertificateMode certificateMode)
    {
        @selfRef.CertificateMode = certificateMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithCertificateMode(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.CaCertificateCertificateMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.IoT.CaCertificateCertificateMode>();
        @configure(@item);
        @selfRef.CertificateMode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithRegistrationConfig(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::Pulumi.AwsNative.IoT.Inputs.CaCertificateRegistrationConfigArgs registrationConfig)
    {
        @selfRef.RegistrationConfig = registrationConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithRegistrationConfig(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.Inputs.CaCertificateRegistrationConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoT.Inputs.CaCertificateRegistrationConfigArgs();
        @configure(@item);
        @selfRef.RegistrationConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithRemoveAutoRegistration(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, bool removeAutoRegistration = true)
    {
        @selfRef.RemoveAutoRegistration = removeAutoRegistration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithStatus(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::Pulumi.AwsNative.IoT.CaCertificateStatus status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithStatus(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.CaCertificateStatus> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.IoT.CaCertificateStatus>();
        @configure(@item);
        @selfRef.Status = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithTags(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithTags(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithTags(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.CaCertificateArgs WithVerificationCertificatePem(this global::Pulumi.AwsNative.IoT.CaCertificateArgs @selfRef, global::System.String verificationCertificatePem)
    {
        @selfRef.VerificationCertificatePem = verificationCertificatePem;
        return @selfRef;
    }

}
