// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.EventSchemas;

public static partial class SchemaExtensions
{

    extension(Schema)
    {
        public static Schema New(string @id, global::Pulumi.AwsNative.EventSchemas.SchemaArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Schema(@id, @args, @options);
        }

        public static Schema New(string @id, global::System.Action<global::Pulumi.AwsNative.EventSchemas.SchemaArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.EventSchemas.SchemaArgs @args = new();
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

            return new Schema(@id, @args, @options);
        }

    }

}
