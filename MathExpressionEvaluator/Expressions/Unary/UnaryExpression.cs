namespace MathExpressionEvaluator.Expressions.Unary
{
    public abstract class UnaryExpression : Expression
    {
        protected Expression Expression;

        protected UnaryExpression(Expression expression)
        {
            Expression = expression;
        }
    }
}