namespace Workshop1.Expressions;

public sealed class ExpressionEvaluationContext
{
    private readonly Dictionary<string, double> _values = [];

    public void Add(string variableName, double value)
    {
        _values.Add(variableName, value);
    }

    public bool TryGetVariableValue(string variableName, out double value)
    {
        return _values.TryGetValue(variableName, out value);
    }
}
