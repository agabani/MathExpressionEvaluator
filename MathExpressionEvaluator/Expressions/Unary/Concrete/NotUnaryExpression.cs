namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class NotUnaryExpression : UnaryExpression
    {
        internal NotUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override decimal Evaluate()
        {
            return -Expression.Evaluate();
        }
    }
}