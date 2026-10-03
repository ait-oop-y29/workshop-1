using System.Globalization;

namespace Workshop1.Expressions.Expressions;

public sealed class ConstantExpression(
    double value)
    : IExpression
{
    public string Format()
    {
        return value.ToString(CultureInfo.InvariantCulture);
    }

    public ExpressionEvaluationResult Evaluate(ExpressionEvaluationContext context)
    {
        return new ExpressionEvaluationResult.Full(value);
    }
}
