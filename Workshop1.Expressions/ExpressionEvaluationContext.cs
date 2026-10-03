namespace Workshop1.Expressions;

public sealed class ExpressionEvaluationContext
{
    private readonly Dictionary<string, double> _values = [];

    public void Add(string name, double value)
    {
        _values.Add(name, value);
    }

    public bool TryGetValue(string name, out double value)
    {
        return _values.TryGetValue(name, out value);
    }
}
