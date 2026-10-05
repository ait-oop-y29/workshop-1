namespace Workshop1.Expressions.BinaryOperators;

public sealed class CachingBinaryOperatorProxy(
    IBinaryOperator binaryOperator)
    : IBinaryOperator
{
    private readonly Dictionary<Key, double> _cache = [];

    public string Format(string left, string right)
    {
        return binaryOperator.Format(left, right);
    }

    public double Evaluate(double left, double right)
    {
        var key = new Key(left, right);

        if (_cache.TryGetValue(key, out double value))
            return value;

        value = binaryOperator.Evaluate(left, right);
        _cache[key] = value;

        return value;
    }

    private readonly record struct Key(double Left, double Right);
}
