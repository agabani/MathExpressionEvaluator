namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal sealed class NotUnaryExpression : UnaryExpression
    {
        internal NotUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        internal override double Evaluate()
        {
            return -Expression.Evaluate();
        }
    }
}