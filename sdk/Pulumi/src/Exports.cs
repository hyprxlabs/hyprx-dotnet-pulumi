
namespace Pulumi;

public static class Exports
{
    public static List<T> List<T>(params T[] items)
    {
        return new List<T>(items);
    }
}