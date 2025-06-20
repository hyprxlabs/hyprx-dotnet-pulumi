// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Web;

public static partial class WebAppPublicCertificateExtensions
{

    extension(WebAppPublicCertificate)
    {
        public static WebAppPublicCertificate New(string @id, global::Pulumi.AzureNative.Web.WebAppPublicCertificateArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new WebAppPublicCertificate(@id, @args, @options);
        }

        public static WebAppPublicCertificate New(string @id, global::System.Action<global::Pulumi.AzureNative.Web.WebAppPublicCertificateArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Web.WebAppPublicCertificateArgs @args = new();
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

            return new WebAppPublicCertificate(@id, @args, @options);
        }

    }

}
