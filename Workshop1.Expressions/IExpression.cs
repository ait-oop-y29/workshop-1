namespace Workshop1.Expressions;

public interface IExpression
{
    string Format();

    ExpressionEvaluationResult Evaluate(ExpressionEvaluationContext context);
}
