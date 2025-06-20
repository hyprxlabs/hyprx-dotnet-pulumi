

namespace Pulumi.AzureNative;

public class AzTags : Dictionary<string, string?>
{
    public AzTags()
        : base(StringComparer.OrdinalIgnoreCase)
    {
    }

    public AzTags(IDictionary<string, string?> dictionary)
        : base(dictionary, StringComparer.OrdinalIgnoreCase)
    {
    }

    public AzTags(int capacity)
        : base(capacity, StringComparer.OrdinalIgnoreCase)
    {
    }

    public AzTags(IEqualityComparer<string> comparer)
        : base(comparer)
    {
    }

    public AzTags(int capacity, IEqualityComparer<string> comparer)
        : base(capacity, comparer)
    {
    }

    public AzTags Add((string key, string? value) item)
    {
        this[item.key] = item.value;
        return this;
    }

    public AzTags AddRange(IEnumerable<(string key, string? value)> items)
    {
        foreach (var item in items)
        {
            this[item.key] = item.value;
        }
        return this;
    }

    public static AzTags operator +(AzTags left, AzTags right)
    {
        var result = new AzTags(left);
        foreach (var item in right)
        {
            result[item.Key] = item.Value;
        }
        return result;
    }

    public static AzTags operator -(AzTags left, AzTags right)
    {
        var result = new AzTags(left);
        foreach (var item in right)
        {
            result.Remove(item.Key);
        }
        return result;
    }
    
    public static AzTags Create(IEnumerable<(string key, string? value)> items)
    {
        var result = new AzTags();
        foreach (var item in items)
        {
            result[item.key] = item.value;
        }
        return result;
    }
}