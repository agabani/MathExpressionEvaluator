namespace MathExpressionEvaluator.Expressions.Unary
{
    internal abstract class UnaryExpression : Expression
    {
        protected Expression Expression;

        protected UnaryExpression(Expression expression)
        {
            Expression = expression;
        }
    }
}