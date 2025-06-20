
namespace Pulumi;

public class Outputs : Dictionary<string, object?>
{
    public Outputs()
        : base(StringComparer.OrdinalIgnoreCase)
    {
    }

    public Outputs(IDictionary<string, object?> dictionary)
        : base(dictionary, StringComparer.OrdinalIgnoreCase)
    {
    }

    public Outputs(IEnumerable<KeyValuePair<string, object?>> dictionary)
        : base(dictionary, StringComparer.OrdinalIgnoreCase)
    {
    }

    public Outputs(IEnumerable<(string key, object? value)> items)
        : base(items.ToDictionary(x => x.key, x => x.value), StringComparer.OrdinalIgnoreCase)
    {
    }

    public Outputs(int capacity)
        : base(capacity, StringComparer.OrdinalIgnoreCase)
    {
    }

    public Outputs(IEqualityComparer<string> comparer)
        : base(comparer)
    {
    }

    public Outputs(int capacity, IEqualityComparer<string> comparer)
        : base(capacity, comparer)
    {
    }

    public Outputs Add((string key, object? value) item)
    {
        this[item.key] = item.value;
        return this;
    }

    public Outputs AddRange(IEnumerable<(string key, object? value)> items)
    {
        foreach (var item in items)
        {
            this[item.key] = item.value;
        }
        return this;
    }

    public static Outputs operator +(Outputs left, Outputs right)
    {
        var result = new Outputs(left);
        foreach (var item in right)
        {
            result[item.Key] = item.Value;
        }
        return result;
    }

    public static Outputs operator -(Outputs left, Outputs right)
    {
        var result = new Outputs(left);
        foreach (var item in right)
        {
            result.Remove(item.Key);
        }
        return result;
    }

    public static Outputs Create(IEnumerable<(string key, object? value)> items)
    {
        var result = new Outputs();
        foreach (var item in items)
        {
            result[item.key] = item.value;
        }
        return result;
    }
}