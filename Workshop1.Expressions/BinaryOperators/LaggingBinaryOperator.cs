namespace Workshop1.Expressions.BinaryOperators;

public sealed class LaggingBinaryOperator(
    IBinaryOperator binaryOperator)
    : IBinaryOperator
{
    public string Format(string left, string right) => binaryOperator.Format(left, right);

    public double Evaluate(double left, double right)
    {
        Thread.Sleep(5000);
        return binaryOperator.Evaluate(left, right);
    }
}
