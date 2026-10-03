namespace Workshop1.Expressions.BinaryOperators;

public sealed class SubtractOperator : IBinaryOperator
{
    public string Format(string left, string right)
    {
        return $"{left} - {right}";
    }

    public double Evaluate(double left, double right)
    {
        return left - right;
    }
}
