namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    internal class NotUnaryExpression : UnaryExpression
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