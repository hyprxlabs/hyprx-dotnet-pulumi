// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.CertificateRegistration;

public static partial class AppServiceCertificateOrderExtensions
{

    extension(AppServiceCertificateOrder)
    {
        public static AppServiceCertificateOrder New(string @id, global::Pulumi.AzureNative.CertificateRegistration.AppServiceCertificateOrderArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new AppServiceCertificateOrder(@id, @args, @options);
        }

        public static AppServiceCertificateOrder New(string @id, global::System.Action<global::Pulumi.AzureNative.CertificateRegistration.AppServiceCertificateOrderArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.CertificateRegistration.AppServiceCertificateOrderArgs @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new AppServiceCertificateOrder(@id, @args, @options);
        }

    }

}
