// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.Random;

public static partial class RandomShuffleExtensions
{

    extension(RandomShuffle)
    {
        public static RandomShuffle New(string @id, global::Pulumi.Random.RandomShuffleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new RandomShuffle(@id, @args, @options);
        }

        public static RandomShuffle New(string @id, global::System.Action<global::Pulumi.Random.RandomShuffleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.Random.RandomShuffleArgs @args = new();
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

            return new RandomShuffle(@id, @args, @options);
        }

    }

}
