// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi;

using Pulumiverse.Acme.Inputs;

namespace Pulumiverse.Acme;

public static partial class CertificateHttpS3ChallengeGetArgsExtensions
{
    public static global::Pulumiverse.Acme.Inputs.CertificateHttpS3ChallengeGetArgs WithS3Bucket(this global::Pulumiverse.Acme.Inputs.CertificateHttpS3ChallengeGetArgs @selfRef, global::System.String s3Bucket)
    {
        @selfRef.S3Bucket = s3Bucket;
        return @selfRef;
    }

}
