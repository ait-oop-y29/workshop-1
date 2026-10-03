namespace Workshop1.Expressions.BinaryOperators;

public interface IBinaryOperator
{
    string Format(string left, string right);

    double Evaluate(double left, double right);
}
