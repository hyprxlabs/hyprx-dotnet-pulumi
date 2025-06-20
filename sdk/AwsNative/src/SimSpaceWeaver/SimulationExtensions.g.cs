// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.SimSpaceWeaver;

public static partial class SimulationExtensions
{

    extension(Simulation)
    {
        public static Simulation New(string @id, global::Pulumi.AwsNative.SimSpaceWeaver.SimulationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Simulation(@id, @args, @options);
        }

        public static Simulation New(string @id, global::System.Action<global::Pulumi.AwsNative.SimSpaceWeaver.SimulationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.SimSpaceWeaver.SimulationArgs @args = new();
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

            return new Simulation(@id, @args, @options);
        }

    }

}
