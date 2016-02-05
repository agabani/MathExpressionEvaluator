namespace MathExpressionEvaluator.Expressions.Unary.Concrete
{
    public class NotUnaryExpression : UnaryExpression
    {
        public NotUnaryExpression(Expression expression)
            : base(expression)
        {
        }

        public override decimal Evaluate()
        {
            return -Expression.Evaluate();
        }
    }
}