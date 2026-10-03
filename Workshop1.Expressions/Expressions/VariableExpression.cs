namespace Workshop1.Expressions.Expressions;

public sealed class VariableExpression(
    string name)
    : IExpression
{
    public string Format() => name;

    public ExpressionEvaluationResult Evaluate(ExpressionEvaluationContext context)
    {
        return context.TryGetValue(name, out double value)
            ? new ExpressionEvaluationResult.Full(value)
            : new ExpressionEvaluationResult.Partial(this);
    }
}
