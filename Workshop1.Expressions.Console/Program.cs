using Workshop1.Expressions;
using Workshop1.Expressions.BinaryOperators;
using Workshop1.Expressions.Expressions;
using static Workshop1.Expressions.ExpressionExtensions;

IExpression expression = new BinaryOperatorExpression(
     new VariableExpression("x"),
     new ConstantExpression(1),
     new CachingOperatorProxy(new LaggingOperator(new SumOperator())));

// IExpression expression = -(Variable("x") + Constant(1));

var context = new ExpressionEvaluationContext();
context.Add("x", 1);

Console.WriteLine($"1 - {DateTimeOffset.UtcNow.ToUnixTimeSeconds()}");
Console.WriteLine(expression.Evaluate(context));
Console.WriteLine($"2 - {DateTimeOffset.UtcNow.ToUnixTimeSeconds()}");
Console.WriteLine(expression.Evaluate(context));
Console.WriteLine($"3 - {DateTimeOffset.UtcNow.ToUnixTimeSeconds()}");
